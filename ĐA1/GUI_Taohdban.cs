using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using ZXing;
using System.Drawing.Drawing2D;

namespace ĐA1
{
    public partial class GUI_Taohdban : Form
    {
        private bool isLoading = true; 
        BUS_DSKhachhang busdskh = new BUS_DSKhachhang();
        BUS_Khohang busdssp = new BUS_Khohang();
        BUS_Payment buspmt = new BUS_Payment();
        BUS_CodeKhuyenmai buscode= new BUS_CodeKhuyenmai();
        BUS_HDBanhang busHDban = new BUS_HDBanhang();
        BUS_CTHDBanhang buscthdbh = new BUS_CTHDBanhang();
        BUS_CTKhuyenmai busctkm = new BUS_CTKhuyenmai();
        BUS_DSLoaiSP busloaisp = new BUS_DSLoaiSP();
        public string banggia;
        public string id;
        public GUI_Taohdban(string giaban, string id)
        {
            InitializeComponent();
            pnThongtinnguoimua.Visible = false;

            var data = busdskh.GetAll();
            Loadcbbkhachhang(data);
            var datapmt = buspmt.GetAll();
            Loadcbbhthuctt(datapmt);
            var datacode = buscode.GetAll();
            Loadcbbmagiamgia(datacode);
            this.id = id;
            isLoading = false;
            this.banggia = giaban;
            lblgia.Text = banggia;
            rbNo.Checked = true;
        }


        private void btnout_Click(object sender, EventArgs e)
        {
            pnThongtinnguoimua.Visible = false;
            cbbKhachhang.SelectedIndex = -1;
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            GUI_ThemKH themkh = new GUI_ThemKH();
            themkh.ShowDialog();
        }

        public void Loadcbbkhachhang(List<CUSTOMER> cus)
        {
            if (cus == null || cus.Count == 0)
            {
                MessageBox.Show("Không có khách hàng để hiển thị", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbbKhachhang.DataSource = cus;
            cbbKhachhang.DisplayMember = "CUS_NAME";
            cbbKhachhang.ValueMember = "CUS_NAME";
            cbbKhachhang.SelectedIndex = -1;
        }

        public void Loadcbbhthuctt(List<PAYMENT> pmt)
        {
            cbbHtthanhtoan.DataSource = pmt;
            cbbHtthanhtoan.DisplayMember = "PMT_NAME";
            cbbHtthanhtoan.ValueMember = "PMT_NAME";
            cbbHtthanhtoan.SelectedIndex = -1;
        }

        public void Loadcbbctkm(List<PROMOTION> prm)
        {
            cbbctkm.DataSource = prm;
            cbbctkm.DisplayMember = "PROMOTION_NAME";
            cbbctkm.ValueMember = "PROMOTION_NAME";
            cbbctkm.SelectedIndex = -1;
        }

        public void Loadcbbmagiamgia(List<DISCOUNT> dc)
        {
            List<DISCOUNT> dskm = new List<DISCOUNT>(); 

            for (int i = 0; i < dc.Count; i++)
            {
                if (dc[i].USED_COUNT < dc[i].MAXIMUM_USE)
                {
                    if(dc[i].DISCOUNT_STATUS != "Đã kết thúc")
                    {
                        dskm.Add(dc[i]);
                    }
                }
            }

            cbbMagiamgia.DataSource = dskm;
            cbbMagiamgia.DisplayMember = "CODE";
            cbbMagiamgia.ValueMember = "CODE";
            cbbMagiamgia.SelectedIndex = -1;
        }



        private void cbbKhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return; 

            if (cbbKhachhang.SelectedIndex >= 0)
            {
                pnThongtinnguoimua.Visible = true;
                var customerId = busdskh.getCUS_ID(cbbKhachhang.Text);

                if (customerId != null)
                {
                    var customerInfo = busdskh.GetByID(customerId);
                    if (customerInfo != null)
                    {
                        lblmakh.Text = customerInfo.CUS_ID;
                        lblName.Text = customerInfo.CUS_NAME;
                        lblemail.Text = customerInfo.EMAIL;
                        lblsdt.Text = customerInfo.CUS_PHONE_NUMBER;
                        lbldchi.Text = customerInfo.CUS_ADDRESS;
                    }
                    else
                    {
                        ClearCustomerInfo();
                        MessageBox.Show("Không tìm thấy thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ClearCustomerInfo();
                    MessageBox.Show("Không tìm thấy ID khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                pnThongtinnguoimua.Visible = false;
                ClearCustomerInfo();
            }
        }

        private void ClearCustomerInfo()
        {
            lblName.Text = "";
            lblemail.Text = "";
            lblsdt.Text = "";
            lbldchi.Text = "";
        }

        private void txtSanpham_TextChanged(object sender, EventArgs e)
        {
            if (txtSanpham.Text.Length == 0)
            {
                dgvfindsp.Visible = false;
            }
        }

        private void txtSanpham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1())
                {
                    dgvfindsp.Visible = true;
                    dgvfindsp.DataSource = db.WAREHOUSEs
                                            .Where(p => p.PRD_NAME.Contains(txtSanpham.Text))
                                            .Select(c => new
                                            {
                                                c.PRD_ID,
                                                c.RDY_FOR_SALE,
                                                c.PRD_NAME,
                                                c.RETAIL_PRICE,
                                                c.WHOLESALE_PRICE
                                            })
                                            .ToList();
                    dgvfindsp.Height = dgvfindsp.Rows.Count * 40;
                }
            }
        }

        private void dgvfindsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dgvfindsp.Rows[e.RowIndex];
                var ctkm = busctkm.GetAll();

                // Retrieve the data from the clicked row
                var prdId = clickedRow.Cells["clID"].Value.ToString();
                var name = clickedRow.Cells["clName"].Value.ToString();
                var soluong = 1;
                var retailprice = string.Empty;
                var sltonkho = clickedRow.Cells["clSoluong"].Value.ToString();
                if (lblgia.Text == "Giá sỉ")
                {
                    retailprice = clickedRow.Cells["clgiasi"].Value.ToString();
                }
                else
                {
                    retailprice = clickedRow.Cells["clgiabanle"].Value.ToString();
                }

                var tongtien = soluong * float.Parse(retailprice);

                // Format the retail price and total amount as currency
                var retailpriceFormatted = float.Parse(retailprice).ToString("N0");
                var tongtienFormatted = tongtien.ToString("N0");

                bool found = false;

                // Check if prdId already exists in dgvchitiet
                foreach (DataGridViewRow row in dgvchitiet.Rows)
                {
                    var cellValue = row.Cells["clmasp"].Value;
                    if (cellValue != null && cellValue.ToString() == prdId)
                    {
                        // Update the existing row with new values
                        var currentSoluong = int.Parse(row.Cells["clSoluongmua"].Value.ToString());
                        var newSoluong = currentSoluong + soluong;
                        row.Cells["clSoluongmua"].Value = newSoluong;
                        row.Cells["clsltonkho"].Value = sltonkho;
                        var currentTongtien = float.Parse(row.Cells["clThanhtien"].Value.ToString());
                        var newTongtien = newSoluong * float.Parse(retailprice);
                        row.Cells["clThanhtien"].Value = newTongtien.ToString("N0");

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    // Add a new row for prdId
                    dgvchitiet.Rows.Add(null, prdId, name, sltonkho, soluong, retailpriceFormatted, tongtienFormatted);
                    UpdateTotalAmount();
                    UpdateTotalQuantity();
                }
            }
        }
        private void dgvchitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột được nhấn có phải là cột clxoa hay không
            if (e.ColumnIndex == dgvchitiet.Columns["clxoa"].Index && e.RowIndex >= 0)
            {
                // Xác nhận với người dùng trước khi xóa
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Commit any pending changes to the DataGridView
                        if (dgvchitiet.IsCurrentRowDirty)
                        {
                            dgvchitiet.CommitEdit(DataGridViewDataErrorContexts.Commit);
                        }

                        // Xóa hàng tại vị trí đã nhấn
                        dgvchitiet.Rows.RemoveAt(e.RowIndex);
                        UpdateTotalAmount();
                        UpdateTotalQuantity();
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("Không thể xóa hàng này: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvchitiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvchitiet.Columns["clSoluongmua"].Index)
            {
                // Lấy giá trị số lượng được cập nhật
                var quantityCellValue = dgvchitiet.Rows[e.RowIndex].Cells["clSoluongmua"].Value.ToString();
                int updatedQuantity;
                if (int.TryParse(quantityCellValue, out updatedQuantity))
                {
                    // Lấy giá trị tồn kho và tên sản phẩm
                    var stockCellValue = dgvchitiet.Rows[e.RowIndex].Cells["clsltonkho"].Value.ToString();
                    var productName = dgvchitiet.Rows[e.RowIndex].Cells["cltensp"].Value.ToString();
                    int stockQuantity;

                    if (int.TryParse(stockCellValue, out stockQuantity))
                    {
                        // Kiểm tra nếu số lượng cập nhật lớn hơn số lượng tồn kho
                        if (updatedQuantity > stockQuantity)
                        {
                            MessageBox.Show($"Lỗi: {productName} chỉ còn {stockQuantity} sản phẩm. Vui lòng không chọn vượt quá số lượng tồn kho.",
                                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Đặt lại giá trị số lượng về giá trị tồn kho
                            dgvchitiet.Rows[e.RowIndex].Cells["clSoluongmua"].Value = stockQuantity;
                            updatedQuantity = stockQuantity; // Cập nhật lại giá trị updatedQuantity để tính lại tổng tiền
                        }

                        // Tính toán lại tổng số tiền cho hàng
                        var retailPrice = float.Parse(dgvchitiet.Rows[e.RowIndex].Cells["clgia"].Value.ToString());
                        var updatedTotalAmount = updatedQuantity * retailPrice;

                        // Cập nhật lại cột tổng số tiền với giá trị mới
                        dgvchitiet.Rows[e.RowIndex].Cells["clthanhtien"].Value = updatedTotalAmount.ToString("N0");

                        // Cập nhật tổng số tiền và tổng số lượng
                        UpdateTotalAmount();
                        UpdateTotalQuantity();
                    }
                    else
                    {
                        MessageBox.Show("Giá trị tồn kho không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Xử lý trường hợp giá trị ô không thể được phân tích cú pháp thành số nguyên
                    MessageBox.Show("Số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void UpdateTotalAmount()
        {
            float totalAmount = 0;

            foreach (DataGridViewRow row in dgvchitiet.Rows)
            {
                var totalAmountCell = row.Cells["clThanhtien"].Value;
                if (totalAmountCell != null)
                {
                    totalAmount += float.Parse(totalAmountCell.ToString());
                }
            }

            txttongtienhang.Text = totalAmount.ToString("N0");
        }

        private void UpdateTotalQuantity()
        {
            int totalQuantity = 0;

            foreach (DataGridViewRow row in dgvchitiet.Rows)
            {
                var quantityCell = row.Cells["clSoluongmua"].Value;
                if (quantityCell != null)
                {
                    totalQuantity += int.Parse(quantityCell.ToString());
                }
            }

            txtslsp.Text = totalQuantity.ToString();
        }

        private void txtslsp_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var magg = buscode.GetAll();

                // Tạo hóa đơn mới
                string hdid = busHDban.GetNewID();
                string banggia = lblgia.Text;
                string makh = lblmakh.Text;
                string manv = id;
                DateTime ngaytao = DateTime.Now;
                string ghichu = txtghichu.Text;
                string status = "Đã hoàn thành";

                if (!int.TryParse(txtslsp.Text, out int slsanpham))
                {
                    MessageBox.Show("Số lượng sản phẩm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!float.TryParse(txttongtienhang.Text, out float tongtien))
                {
                    MessageBox.Show("Tổng tiền hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string magiamgia = cbbMagiamgia.Text;
                string ctgiamgia = cbbctkm.Text;
                string htthanhtoan = cbbHtthanhtoan.Text;

                var mgg = buscode.GetByCODE(magiamgia);
                decimal? discount_value = mgg?.DISCOUNT_AMOUNT;
                decimal? max_discount_value = mgg?.MAXIMUM_DISCOUNT_AMOUNT;
                float moneyafterdiscount = 0;

                if (discount_value.HasValue)
                {
                    txtdescribe.Text = mgg.CODE_DESCRIPTION;
                    if (discount_value > 100)
                    {
                        // Nếu giá trị giảm giá là một số tiền trực tiếp
                        float discount = (float)discount_value.Value;
                        moneyafterdiscount = tongtien - discount;
                    }
                    else
                    {
                        // Nếu giá trị giảm giá là phần trăm
                        float discount = (float)discount_value.Value;
                        float _discount = (discount / 100) * tongtien;

                        // Kiểm tra giá trị giảm giá tối đa nếu có
                        if (max_discount_value.HasValue)
                        {
                            float maxDiscount = (float)max_discount_value.Value;
                            if (_discount > maxDiscount)
                            {
                                _discount = maxDiscount;
                            }
                        }
                        txtgiamgia.Text = _discount.ToString("N0");
                        moneyafterdiscount = tongtien - _discount;
                    }
                }
                else
                {
                    // Xử lý trường hợp không có giá trị giảm giá
                    moneyafterdiscount = tongtien;
                    txtgiamgia.Text = "0";
                }
                txttongtien.Text = moneyafterdiscount.ToString("N0");



                busHDban.NewSalebill(hdid, ngaytao, makh, manv, magiamgia, ctgiamgia, htthanhtoan, ghichu, status, tongtien, banggia, moneyafterdiscount);

                // Duyệt từng dòng trong dgvchitiet để lưu chi tiết hóa đơn
                for (int i = 0; i < dgvchitiet.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvchitiet.Rows[i];
                    if (row.IsNewRow) continue;

                    string detailId = buscthdbh.GetNewID();
                    string slid = hdid;
                    string prdid = row.Cells["clmasp"].Value?.ToString();
                    if (string.IsNullOrEmpty(prdid))
                    {
                        MessageBox.Show("Mã sản phẩm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(row.Cells["clSoluongmua"].Value?.ToString(), out int quantity))
                    {
                        MessageBox.Show("Số lượng mua không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!float.TryParse(row.Cells["clGia"].Value?.ToString(), out float price))
                    {
                        MessageBox.Show("Giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    buscthdbh.NewSalebilldetail(detailId, slid, prdid, quantity, price);
                }

                MessageBox.Show("Tạo hóa đơn và chi tiết hóa đơn thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cbbHtthanhtoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHtthanhtoan.SelectedIndex == 0)
            {
                btnTaoQR.Enabled = true;
            }
            else
            {
                btnTaoQR.Enabled = false;
            }
        }

        private void btnTaoQR_Click(object sender, EventArgs e)
        {
            CreateMomoQR();
        }

        public void CreateMomoQR()
        {
            // Text to encode in the QR code
            var qrcodeText = $"2|99|{"0856012976"}|{"Trương Quốc Huy"}|{"truongquochuy234@gmail.com"}|0|0|{txttongtienhang.Text.Trim()}";

            // Create a BarcodeWriter instance
            BarcodeWriter barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Width = 250,
                    Height = 250,
                    Margin = 0,
                    PureBarcode = false,
                    Hints = { { EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H } }
                },
                Renderer = new BitmapRenderer()
            };

            // Generate the QR code bitmap
            Bitmap bitmap = barcodeWriter.Write(qrcodeText);

            // Load and resize the logo
            Bitmap logo = ResizeImage(Properties.Resources.logo_momo, 64, 64) as Bitmap;

            // Draw the logo in the center of the QR code
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                int centerX = (bitmap.Width - logo.Width) / 2;
                int centerY = (bitmap.Height - logo.Height) / 2;
                g.DrawImage(logo, centerX, centerY);
            }

            // Set the QR code with the logo to a PictureBox
            pbQR.Image = bitmap;
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        private void cbbMagiamgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dskm = buscode.GetByCODE(cbbMagiamgia.Text);
            if (dskm != null)
            {
                txtdescribe.Text = dskm.CODE_DESCRIPTION.ToString().Trim();
                string magiamgia = cbbMagiamgia.Text;
                if (!float.TryParse(txttongtienhang.Text, out float tongtienhang))
                {
                    return;
                }

                decimal? discount_value = dskm.DISCOUNT_AMOUNT;
                decimal? max_discount_value = dskm.MAXIMUM_DISCOUNT_AMOUNT;
                float moneyafterdiscount = tongtienhang;

                if (discount_value.HasValue)
                {
                    if (discount_value > 100)
                    {
                        // Nếu giá trị giảm giá là một số tiền trực tiếp
                        float discount = (float)discount_value.Value;
                        moneyafterdiscount = tongtienhang - discount;
                        txtgiamgia.Text = discount.ToString("N0");
                    }
                    else
                    {
                        // Nếu giá trị giảm giá là phần trăm
                        float discount = (float)discount_value.Value;
                        float _discount = (discount / 100) * tongtienhang;

                        // Kiểm tra giá trị giảm giá tối đa nếu có
                        if (max_discount_value.HasValue)
                        {
                            float maxDiscount = (float)max_discount_value.Value;
                            if (_discount > maxDiscount)
                            {
                                _discount = maxDiscount;
                            }
                        }
                        txtgiamgia.Text = _discount.ToString("N0");
                        moneyafterdiscount = tongtienhang - _discount;
                    }
                }
                else
                {
                    txtgiamgia.Text = "0";
                }

                txttongtien.Text = moneyafterdiscount.ToString("N0");
            }
            else
            {
                txtdescribe.Text = string.Empty;
                txtgiamgia.Text = "0";
                if (float.TryParse(txttongtienhang.Text, out float tongtienhang))
                {
                    txttongtien.Text = tongtienhang.ToString("N0");
                }
                else
                {
                    txttongtien.Text = "0";
                }
            }
        }


        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYes.Checked == true)
            {
                rbNo.Checked = false;
                var ctkmdata = busctkm.GetAll();
                cbbctkm.DataSource = ctkmdata.Select(x => new { x.PROMOTION_NAME }).ToList();
                cbbctkm.DisplayMember = "PROMOTION_NAME";
                cbbctkm.ValueMember = "PROMOTION_NAME";
            }

            cbbMagiamgia.Enabled = false;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNo.Checked == true)
            {
                rbYes.Checked = false;
                cbbctkm.DataSource = null;
            }
            cbbMagiamgia.Enabled = true;
        }

        private void GUI_Taohdban_Load(object sender, EventArgs e)
        {

        }

        private void cbbctkm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbctkm.SelectedIndex == -1)
            {
                // Nếu không có mã giảm giá được chọn, đặt lại giá trị các ô tương ứng
                for (int i = 0; i < dgvchitiet.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvchitiet.Rows[i];
                    row.Cells["clCTKM"].Value = null;

                    string retailprice = string.Empty;
                    if (lblgia.Text == "Giá sỉ")
                    {
                        if (row.Cells["clgiasi"].Value != null)
                        {
                            retailprice = row.Cells["clgiasi"].Value.ToString();
                        }
                    }
                    else
                    {
                        if (row.Cells["clGia"].Value != null)
                        {
                            retailprice = row.Cells["clGia"].Value.ToString();
                        }
                    }

                    if (!string.IsNullOrEmpty(retailprice))
                    {
                        int newSoluong = 0;
                        if (row.Cells["clSoluongmua"].Value != null)
                        {
                            int.TryParse(row.Cells["clSoluongmua"].Value.ToString(), out newSoluong);
                        }

                        float parsedPrice;
                        if (float.TryParse(retailprice, out parsedPrice))
                        {
                            var Tongtien = newSoluong * parsedPrice;
                            row.Cells["clThanhtien"].Value = Tongtien.ToString("N0");
                        }
                        else
                        {
                            // Xử lý trường hợp retailprice không phải là số hợp lệ
                            row.Cells["clThanhtien"].Value = "0";
                        }
                    }
                }
                return;
            }

            var datactkm = busctkm.GetbyName(cbbctkm.Text);

            if (datactkm != null)
            {
                string loaisp = datactkm.PRD_TYPE_NAME?.ToString() ?? string.Empty;
                string tensp = datactkm.PRD_NAME?.ToString() ?? string.Empty;

                var loaispdata = busloaisp.GetbyName(loaisp);
                if (loaispdata != null)
                {
                    string idloaisp = loaispdata.PRD_TYPE_ID?.ToString() ?? string.Empty;
                    for (int i = 0; i < dgvchitiet.Rows.Count; i++)
                    {
                        DataGridViewRow row = dgvchitiet.Rows[i];
                        string masp = row.Cells["clmasp"].Value?.ToString() ?? string.Empty;
                        var datasp = busdssp.GetByID(masp);
                        if (datasp != null && (datasp.PRD_TYPE_ID?.ToString() == idloaisp || datasp.PRD_NAME?.ToString() == tensp))
                        {
                            dgvchitiet.Rows[i].Cells["clCTKM"].Value = cbbctkm.Text;
                            var currentTongtien = float.Parse(row.Cells["clThanhtien"].Value.ToString());
                            float newTongtien = 0;

                            if (datactkm.DISCOUNT_AMOUNT.HasValue)
                            {
                                float discountAmount = (float)datactkm.DISCOUNT_AMOUNT.Value;
                                if (discountAmount <= 100)
                                {
                                    newTongtien = currentTongtien - (currentTongtien * discountAmount / 100);
                                }
                                else
                                {
                                    newTongtien = currentTongtien - discountAmount;
                                }
                            }
                            else
                            {
                                newTongtien = currentTongtien;
                            }

                            row.Cells["clThanhtien"].Value = newTongtien.ToString("N0");
                        }
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
