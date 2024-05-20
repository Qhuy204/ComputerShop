using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_TaoMagiamgia : Form
    {
        BUS_CodeKhuyenmai busKM = new BUS_CodeKhuyenmai();
        public GUI_TaoMagiamgia()
        {
            InitializeComponent();
        }

        private void btnTaoma_Click(object sender, EventArgs e)
        {
            // Tạo chuỗi chứa các ký tự chữ và số
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Tạo đối tượng Random để sinh số ngẫu nhiên
            Random random = new Random();

            // Tạo mã ngẫu nhiên
            string randomCode = new string(Enumerable.Repeat(chars, 15) // Lặp lại chuỗi chars 15 lần
                                                    .Select(s => s[random.Next(s.Length)]) // Chọn ngẫu nhiên 1 ký tự từ chuỗi chars
                                                    .ToArray()); // Chuyển thành mảng ký tự

            // Điền mã vào textbox
            txtMakm.Text = randomCode;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Nếu bạn hủy các thay đổi này thì thông tin đã điền. Bạn có muốn tiếp tục thêm không?",
                "Hủy thêm mã giảm giá",
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
            string format = "MM/dd/yyyy";
            DateTime start_date, end_date;

            start_date = DateTime.Parse(dtpBatdau.Text);
            end_date = DateTime.Parse(dtpKetthuc.Text);

            MessageBox.Show(start_date.ToString());

            

            if (start_date > end_date)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc.");
                return;
            }

            decimal discount_percent = 0;
            decimal discount_amount = 0;

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

            busKM.NewCode(code, discount_percent, discount_amount, max_discount_amount, code_description, min_purchase, min_quantityof_product, maximum_use, start_date, end_date);
            MessageBox.Show("Mã giảm giá được lưu thành công.");
        }
    }
}
