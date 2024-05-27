using BUS;
using DAL;
using System;
using System.Windows.Forms;


namespace ĐA1
{
    public partial class GUI_ThongtinNCC : Form
    {
        BUS_QLNhacungcap busncc = new BUS_QLNhacungcap();
        public string id;
        public string message;
        public GUI_ThongtinNCC(string id, string message)
        {
            InitializeComponent();
            this.id = id;
            this.message = message;
            if (message != "create")
            {
                LoadData();
            }
            else
            {
                btnXoaKM.Visible = false;
                txtid.Text = busncc.GetNewID();
            }
        }

        public void LoadData()
        {
            var data = busncc.GetByID(id);

            if (data != null)
            {
                try
                {
                    txtten.Text = data.BRD_NAME.ToString();
                    txtdiachi.Text = data.BRD_ADDRESS.ToString();
                    txtEmail.Text = data.BRD_EMAIL.ToString();
                    txtSdt.Text = data.BRD_PHONE;
                    txtid.Text = data.BRD_ID;
                    txttrangthai.Text = data.BRD_STATUS;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhà cung cấp.");
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string name = txtten.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phone = txtSdt.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = txtEmail.Text.Trim();

            string diachi = txtdiachi.Text.Trim();
            if (string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string trangthai = txttrangthai.Text.Trim();
            if (string.IsNullOrEmpty(trangthai))
            {
                MessageBox.Show("Trạng thái không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (message == "create")
            {
                string ncc_id = busncc.GetNewID();
                busncc.NewNCC(ncc_id, name, phone, email, diachi, trangthai);
                MessageBox.Show("Lưu nhà cung cấp thành công!");
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục thêmnhà cung cấp mới không?", "Thêm khách hàng", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    Clearform();
                }
            }
            else
            {
                string ncc_id = txtid.Text.Trim();
                BRAND brd = new BRAND
                {
                    BRD_ID = ncc_id,
                    BRD_NAME = name,
                    BRD_PHONE = phone,
                    BRD_ADDRESS = diachi,
                    BRD_EMAIL = email,
                    BRD_STATUS = trangthai
                };

                if (busncc.Update(brd))
                {
                    MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Clearform()
        {
            txtdiachi.Clear();
            txtid.Text = busncc.GetNewID();
            txtSdt.Clear();
            txtten.Clear();
            txttrangthai.Clear();
            txtEmail.Clear();
        }

        private void btnXoaKM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    busncc.Delete(id);
                    MessageBox.Show("Xóa thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa lỗi: Còn kinh doanh sản phẩm của nhà cung cấp này. Trước khi xóa, vui lòng xóa hết sản phẩm của nhà cung cấp này trước!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttrangthai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
