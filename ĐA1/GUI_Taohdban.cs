using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Windows.Forms;

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

        public void Loadcbbmagiamgia(List<DISCOUNT> dc)
        {
            cbbMagiamgia.DataSource = dc;
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
                // Retrieve the clicked row
                DataGridViewRow clickedRow = dgvfindsp.Rows[e.RowIndex];

                // Retrieve the data from the clicked row
                var prdId = clickedRow.Cells["clID"].Value.ToString();
                var name = clickedRow.Cells["clName"].Value.ToString();
                var soluong = 1;
                var retailprice = string.Empty; // Declare the variable outside the if-else blocks
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
            string ctgiamgia = ""; // Assuming ctgiamgia is calculated or set somewhere else
            string htthanhtoan = cbbHtthanhtoan.Text;

            // Gọi hàm tạo hóa đơn mới
            busHDban.NewSalebill(hdid, ngaytao, makh, manv, magiamgia, ctgiamgia, htthanhtoan, ghichu, status, tongtien, banggia);

            // Duyệt từng dòng trong dgvchitiet để lưu chi tiết hóa đơn
            for (int i = 0; i < dgvchitiet.Rows.Count; i++)
            {
                DataGridViewRow row = dgvchitiet.Rows[i];
                if (row.IsNewRow) continue;

                string detailId = buscthdbh.GetNewID();
                string slid = hdid;
                string prdid = row.Cells["clmasp"].Value.ToString();
                int quantity = int.Parse(row.Cells["clSoluongmua"].Value.ToString());
                float price = float.Parse(row.Cells["clGia"].Value.ToString());

                buscthdbh.NewSalebilldetail(detailId, slid, prdid, quantity, price);
            }

            MessageBox.Show("Tạo hóa đơn và chi tiết hóa đơn thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


    
}
