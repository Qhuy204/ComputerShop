using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_ThemNV : Form
    {

        BUS_DSNhanvien busNV = new BUS_DSNhanvien();

        public GUI_ThemNV()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string id = busNV.GetNewID();
            string name = txtHoten.Text;
            if (name == null || name == "")
            {
                MessageBox.Show("Tên không được để trống");
                return;
            }
            string phone = txtSodienthoai.Text;
            string account = txtTenTK.Text;
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
            DateTime birthday = DateTime.Parse(dtpNgaysinh.Text);


            busNV.NewEmployee(id, name, phone, birthday, email, password, account);
            MessageBox.Show("Thêm nhân viên thành công.");
            bool sendemail = SendEmail.SendMail(email, account, password);

            if (sendemail == true)
            {
                MessageBox.Show("Gửi Email thành công");
            }
        }

        private void GUI_ThemNV_Load(object sender, EventArgs e)
        {

        }
    }
}
