using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_Dangnhap : Form
    {
        BUS_DSNhanvien busnv = new BUS_DSNhanvien();
        BUS_Chucvu buscv = new BUS_Chucvu();
        public GUI_Dangnhap()
        {
            InitializeComponent();
        }

        public bool ischecked = false;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string quyen;

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            // Lấy tất cả dữ liệu nhân viên một lần duy nhất
            var employees = busnv.GetAll();
            string matkhau = txtMatkhau.Text;
            string taikhoan = txtTaikhoan.Text;

            // Biến cờ để theo dõi trạng thái đăng nhập
            bool found = false;

            foreach (var emp in employees)
            {
                if (emp.EMP_ACCOUNT == taikhoan)
                {
                    found = true;
                    if (emp.EMP_PASSWORD == matkhau)
                    {
                        var role = buscv.GetByID(emp.PS_ID).PS_NAME;
                        MessageBox.Show("Đăng nhập thành công với quyền " + role);
                        quyen = role;
                        this.Hide();
                        GUI_MainForm main = new GUI_MainForm(quyen);
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu! Vui lòng nhập lại");
                    }
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Kiểm tra lại tài khoản hoặc mật khẩu của bạn!");
            }



        }

        private void swAdmin_CheckedChanged(object sender, EventArgs e)
        {
            ischecked = true;
        }
    }
}
