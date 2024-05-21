using BUS;
using DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_ThongtinMGG : Form
    {
        BUS_CodeKhuyenmai mgg = new BUS_CodeKhuyenmai();

        public string code;

        public GUI_ThongtinMGG(string code)
        {
            InitializeComponent();
            this.code = code;
            LoadData();
        }

        private void GUI_ThongtinMGG_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        public void LoadData()
        {
            var data = mgg.GetByCODE(code);

            if (data != null)  // Kiểm tra null
            {
                txtMakm.Text = data.CODE.ToString();
                txtMota.Text = data.CODE_DESCRIPTION.ToString();

                // Định dạng ngày tháng
                dtpBatdau.Value = DateTime.Parse(data.DISCOUNT_START_DATE.ToString());
                dtpKetthuc.Value = DateTime.Parse(data.DISCOUNT_END_DATE.ToString());

                txtTrangthai.Text = data.DISCOUNT_STATUS.ToString();

                // Kiểm tra kiểu dữ liệu và chuyển đổi nếu cần
                if (data.DISCOUNT_AMOUNT != null)
                {
                    txtMucgiam.Text = data.DISCOUNT_AMOUNT.Value.ToString();
                    if (data.DISCOUNT_AMOUNT.Value >= 100)
                    {
                        cbbdonvi1.SelectedIndex = 0;
                    }
                    else
                    {
                        cbbdonvi1.SelectedIndex = 1;
                    }
                }

                txtGiamtoida.Text = data.MAXIMUM_DISCOUNT_AMOUNT?.ToString();
                cbbdonvi2.SelectedIndex = 0;
                txtgtritoithieu.Text = data.MIN_PURCHASE_VALUE?.ToString();
                txtsoluongtoithieu.Text = data.MIN_QUANTITY_OF_PRODUCT.ToString();
                txtSLsudung.Text = data.MAXIMUM_USE.ToString();
                txtDasd.Text = data.USED_COUNT.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã khuyến mãi.");
                this.Close();
            }
        }

        private void btnXoaKM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mgg.Delete(code);
                MessageBox.Show("Xóa thành công!");
                this.Close();
            }
        }

        private void GUI_ThongtinMGG_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Lấy form GUI_Khuyenmai
            var mainForm = Application.OpenForms.OfType<GUI_Khuyenmai>().FirstOrDefault();

            if (mainForm != null)
            {
                // Gọi PerformClick trên btnMagiamgia của form GUI_Khuyenmai
                mainForm.GUI_Khuyenmai_Load(sender, e);
                mainForm.btnMagiamgia.PerformClick();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Thông tin đã thay đổi sẽ không được lưu. Bạn có muốn tiếp tục chỉnh sửa không?",
                "Chỉnh sửa thông tin",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                this.Close(); // 
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string code = txtMakm.Text;
            string code_description = txtMota.Text;
            DateTime start_date, end_date;

            start_date = DateTime.Parse(dtpBatdau.Text);
            end_date = DateTime.Parse(dtpKetthuc.Text);

            if (start_date > end_date)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc.");
                return;
            }

            decimal discount_percent = 0;
            decimal discount_amount = 0;

            // Validate discount value based on unit
            if (!string.IsNullOrWhiteSpace(cbbdonvi1.Text))
            {
                if (cbbdonvi1.Text == "%")
                {
                    if (!decimal.TryParse(txtMucgiam.Text, out discount_percent))
                    {
                        MessageBox.Show("Giá trị mức giảm theo % không hợp lệ.");
                        return;
                    }
                }
                else if (cbbdonvi1.Text == "đ")
                {
                    if (!decimal.TryParse(txtMucgiam.Text, out discount_amount))
                    {
                        MessageBox.Show("Giá trị mức giảm theo tiền không hợp lệ.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Đơn vị mức giảm không hợp lệ.");
                    return;
                }
            }

            if (!decimal.TryParse(txtGiamtoida.Text, out decimal max_discount_amount))
            {
                MessageBox.Show("Giá trị giảm tối đa không hợp lệ.");
                return;
            }

            if (!decimal.TryParse(txtgtritoithieu.Text, out decimal min_purchase))
            {
                MessageBox.Show("Giá trị đơn hàng tối thiểu không hợp lệ.");
                return;
            }

            if (!int.TryParse(txtsoluongtoithieu.Text, out int min_quantityof_product))
            {
                MessageBox.Show("Số lượng sản phẩm tối thiểu không hợp lệ.");
                return;
            }

            if (!int.TryParse(txtSLsudung.Text, out int maximum_use))
            {
                MessageBox.Show("Giới hạn sử dụng không hợp lệ.");
                return;
            }

            if (!int.TryParse(txtDasd.Text, out int used_count))
            {
                MessageBox.Show("Số lượng đã sử dụng không hợp lệ.");
                return;
            }

            DISCOUNT discount = new DISCOUNT
            {
                CODE = code,
                CODE_DESCRIPTION = code_description,
                DISCOUNT_PERCENT = discount_percent,
                DISCOUNT_AMOUNT = discount_amount,
                MAXIMUM_DISCOUNT_AMOUNT = max_discount_amount,
                MIN_PURCHASE_VALUE = min_purchase,
                MIN_QUANTITY_OF_PRODUCT = min_quantityof_product,
                MAXIMUM_USE = maximum_use,
                DISCOUNT_START_DATE = start_date,
                DISCOUNT_END_DATE = end_date,
                USED_COUNT = used_count
            };

            if (mgg.Update(discount) == true)
            {
                MessageBox.Show("Mã giảm giá được lưu thành công.");
                this.Close();   
            }
            else
            {
                MessageBox.Show("Không thể cập nhật mã giảm giá.");
            }
        }
    }
}
