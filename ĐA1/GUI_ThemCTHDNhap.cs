using BUS;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_ThemCTHDNhap : Form
    {
        BUS_QLNhacungcap busncc = new BUS_QLNhacungcap();
        BUS_Hoadonnhaphang bushdnh = new BUS_Hoadonnhaphang();
        BUS_CTHoadonnhaphang buscthd = new BUS_CTHoadonnhaphang();
        BUS_Khohang bussp = new BUS_Khohang();
        public string mahd, id;

        public GUI_ThemCTHDNhap(string id)
        {
            InitializeComponent();
            this.id = id;
            txtnhanviennhap.Text = id;
            mahd = bushdnh.GetNewID();
            loadcbbncc();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CreateImportBill();
        }

        private void loadcbbncc()
        {
            var data = busncc.GetAll();
            cbbNhacc.DataSource = data.Select(x => new { x.BRD_NAME }).ToList();
            cbbNhacc.DisplayMember = "BRD_NAME";
            cbbNhacc.ValueMember = "BRD_NAME";
            cbbNhacc.SelectedIndex = -1;
            dgvhdban.DataSource = null;

        }

        private void loadcbbdssp()
        {
            string id = busncc.getBRD_ID(cbbNhacc.Text);
            var data = bussp.getPRD_NAME(id);
            cbbdssp.DataSource = data.Select(x => new { x.PRD_NAME }).ToList();
            cbbdssp.DisplayMember = "PRD_NAME";
            cbbdssp.ValueMember = "PRD_NAME";
            cbbdssp.SelectedIndex = -1;

            // Xóa tất cả các dòng trong dgvhdban
            dgvhdban.Rows.Clear();
        }

        private void cbbNhacc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNhacc.SelectedIndex != -1 )
            {
                cbbdssp.Enabled = true;
                loadcbbdssp();
            }
        }

        private void cbbdssp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /*private void cbbdssp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNhacc.SelectedIndex != -1)
            {
                string id = buscthd.GetNewID();

                string masp = bussp.getPRD_ID(cbbdssp.Text);
                int sl = 1;

                double? gianhap = bussp.getPRD_IMPORT_PRICE(masp);

                if (!string.IsNullOrEmpty(masp) && gianhap.HasValue)
                {
                    dgvhdban.Rows.Add(masp, sl, gianhap.Value);
                }
                else
                {
                    return;
                }
            }
        }*/

        private void checkreferences()
        {

            for (int i = 0; i < dgvhdban.Rows.Count; i++)
            {
                DataGridViewRow row = dgvhdban.Rows[i];
                string productId = row.Cells["clMasp"].Value?.ToString();
                if (string.IsNullOrEmpty(productId))
                {
                    return;
                }

                
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem nhà cung cấp có được chọn hay không
            if (cbbNhacc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy ID nhà cung cấp
            string brd_id = busncc.getBRD_ID(cbbNhacc.Text);

            // Kiểm tra xem sản phẩm có được chọn hay không
            if (cbbdssp.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy mã sản phẩm
            string masp = bussp.getPRD_ID(cbbdssp.Text);

            // Lấy thông tin sản phẩm
            var ssp = bussp.GetByID(masp);

            // Kiểm tra số lượng nhập
            if (!int.TryParse(txtslnhap.Text, out int sl) || sl <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy giá nhập
            double? gianhap = bussp.getPRD_IMPORT_PRICE(masp);

            // Kiểm tra tính hợp lệ của mã sản phẩm và giá nhập
            if (!string.IsNullOrEmpty(masp) && gianhap.HasValue)
            {
                dgvhdban.Rows.Add(masp, sl, gianhap.Value);
            }
            else
            {
                MessageBox.Show("Không thể thêm sản phẩm vào bảng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateImportBill()
        {
            try
            {
                // Get new ID for the import bill
                string ibid = bushdnh.GetNewID();

                string brdname = cbbNhacc.SelectedValue.ToString();
                string brdId = busncc.getBRD_ID(brdname);
                string empId = id;
                DateTime importDate = DateTime.Now;
                string note = txtghichu.Text;

                float totalMoney = 0;

                // Iterate through DataGridView rows to calculate total money
                foreach (DataGridViewRow row in dgvhdban.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (float.TryParse(row.Cells["clIBprice"].Value?.ToString(), out float importPrice) &&
                        int.TryParse(row.Cells["clsoluong"].Value?.ToString(), out int quantity))
                    {
                        totalMoney += importPrice * quantity;
                    }
                    else
                    {
                        MessageBox.Show("Giá nhập hoặc số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // Create a new import bill
                bushdnh.NewImportbill(ibid, brdId, empId, importDate, totalMoney, note);

                // Iterate through DataGridView rows to save import bill details
                for (int i = 0; i < dgvhdban.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvhdban.Rows[i];
                    if (row.IsNewRow) continue;

                    string detailId = buscthd.GetNewID();
                    string importBillId = ibid;
                    string productId = row.Cells["clMasp"].Value?.ToString();
                    if (string.IsNullOrEmpty(productId))
                    {
                        MessageBox.Show("Mã sản phẩm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(row.Cells["clsoluong"].Value?.ToString(), out int quantity))
                    {
                        MessageBox.Show("Số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!float.TryParse(row.Cells["clIBprice"].Value?.ToString(), out float importPrice))
                    {
                        MessageBox.Show("Giá nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create a new import bill detail
                    buscthd.Newimportbilldetail(detailId, importBillId, productId, quantity, importPrice);
                }

                MessageBox.Show("Tạo hóa đơn nhập và chi tiết hóa đơn nhập thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
