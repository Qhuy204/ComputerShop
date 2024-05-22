using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace ĐA1
{
    public partial class GUI_ThongtinTK : Form
    {

        BUS_DSNhanvien busNV = new BUS_DSNhanvien();
        BUS_Chucvu busCV = new BUS_Chucvu();

        public string id;

        public GUI_ThongtinTK(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void GUI_ThongtinTK_Load(object sender, EventArgs e)
        {
            lblemail.Text = txtEmail.Text;
            var cv = busCV.GetAll();
            Loadcbb(cv);
            LoadData();
        }

        public void LoadData()
        {
            var data = busNV.GetByID(id);
            
            if (data != null)
            {
                try
                {
                    txtHoten.Text = data.EMP_NAME.ToString();
                    txtdiachi.Text = data.EMP_ADDRESS.ToString();
                    dtpngaysinh.Value = DateTime.Parse(data.EMP_BIRTHDAY.ToString());
                    txtEmail.Text = data.EMP_EMAIL.ToString();
                    txtSodienthoai.Text = data.EMP_PHONE_NUMBER;
                    txtTaikhoan.Text = data.EMP_ACCOUNT;
                    txtMatkhau.Text = data.EMP_PASSWORD;
                    txttrangthai.Text = data.EMP_STATUS;
                    cbbGioitinh.SelectedIndex = cbbGioitinh.FindStringExact(data.EMP_GENDER);
                    var cvu = busCV.GetByID(data.PS_ID);
                    cbbChucvu.SelectedIndex = cbbChucvu.FindStringExact(cvu.PS_NAME);
                    lblemail.Text = txtEmail.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading employee data: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên.");
                this.Close();
            }
        }

        public void Loadcbb(List<POSITION> cvu)
        {

            var pos_dataSource = cvu.Select(x => new { x.PS_NAME }).ToList();
            cbbChucvu.DataSource = pos_dataSource;
            cbbChucvu.DisplayMember = "PS_NAME";
            cbbChucvu.ValueMember = "PS_NAME";
            cbbChucvu.SelectedIndex = -1;


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

        private void btnXoaKM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                busNV.Delete(id);
                MessageBox.Show("Xóa thành công!");
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string emp_id = id;
            string name = txtHoten.Text;
            if (name == null || name == "")
            {
                MessageBox.Show("Tên không được để trống");
                return;
            }
            string phone = txtSodienthoai.Text;
            string account = txtTaikhoan.Text;
            if (account == null || account == "")
            {
                MessageBox.Show("Tên tài khoản không được để trống");
                return;
            }
            string password = txtMatkhau.Text;
            if (password == null || password == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }
            string email = txtEmail.Text;
            DateTime birthday = DateTime.Parse(dtpngaysinh.Text);
            string gender = cbbGioitinh.Text;
            string diachi = txtdiachi.Text;
            string trangthai = txttrangthai.Text;
            var chucvu = busCV.TimKiemChucvu(cbbChucvu.Text);
            string ps_id = chucvu.PS_ID;
            //MessageBox.Show(ps_id);

            EMPLOYEE emp = new EMPLOYEE
            {
                EMP_ID = emp_id,
                EMP_NAME = name,
                EMP_PHONE_NUMBER = phone,
                EMP_BIRTHDAY = birthday,
                EMP_GENDER = gender,
                EMP_ADDRESS = diachi,
                EMP_EMAIL = email,
                EMP_ACCOUNT = account,
                EMP_PASSWORD = password,
                PS_ID = ps_id,
                EMP_STATUS = trangthai
            };

            if (busNV.Update(emp) == true)
            {
                MessageBox.Show("Cập nhật thông tin thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin.");
            }
        }

        private void btnKhoiphucmk_Click(object sender, EventArgs e)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            Random random = new Random();

            // Tạo mã ngẫu nhiên
            string randomCode = new string(Enumerable.Repeat(chars, 10) 
                                                    .Select(s => s[random.Next(s.Length)]) 
                                                    .ToArray());

            
            string new_password = randomCode;
            EMPLOYEE emp = new EMPLOYEE
            {
                EMP_PASSWORD = new_password
            };
            busNV.Update(emp);

            SendEmail.SendMail_password(txtEmail.Text, new_password);
            MessageBox.Show("Yêu cầu mật khẩu mới thành công");
            this.Close();

        }
    }
}
