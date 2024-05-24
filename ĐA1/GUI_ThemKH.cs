using BUS;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_ThemKH : Form
    {
        BUS_DSKhachhang buskh = new BUS_DSKhachhang();
        public GUI_ThemKH()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = buskh.GetNewID();
                string hoten = txtHoten.Text.Trim(); 
                if (string.IsNullOrEmpty(hoten))
                {
                    MessageBox.Show("Họ tên không được để trống!");
                    return;
                }

                string diachi = txtdiachi.Text.Trim(); 
                if (string.IsNullOrEmpty(diachi))
                {
                    MessageBox.Show("Địa chỉ không được để trống!");
                    return;
                }

                string email = txtEmail.Text.Trim();

                string sdt = txtSdt.Text.Trim(); 
                if (string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("Số điện thoại không được để trống!");
                    return;
                }

                string gioitinh = "";
                if (rbNam.Checked)
                {
                    gioitinh = "Nam";
                }
                else if (rbNu.Checked)
                {
                    gioitinh = "Nữ";
                }
                else if (rbKhac.Checked)
                {
                    gioitinh = "Khác";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn giới tính khách hàng");
                    return; 
                }

                DateTime ngaysinh = dtpNgaysinh.Value;

                if (ngaysinh > DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!");
                    return;
                }

                buskh.NewCustomer(ma, hoten, sdt, ngaysinh, email, gioitinh, diachi);
                MessageBox.Show("Lưu khách hàng thành công!");
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục thêm khách hàng mới không?", "Thêm khách hàng", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    Clearform();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message); 
            }
        }
        
        public void Clearform()
        {
            txtdiachi.Clear();
            txtEmail.Clear();
            txtHoten.Clear();
            txtSdt.Clear();
            dtpNgaysinh.ResetText();
            rbKhac.Checked = false;
            rbNam.Checked = false;
            rbNu.Checked = false;
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            rbKhac.Checked = false;
            rbNu.Checked = false;
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            rbNam.Checked = false;
            rbKhac.Checked = false;
        }

        private void rbKhac_CheckedChanged(object sender, EventArgs e)
        {
            rbNam.Checked = false;
            rbNu.Checked = false;
        }

        private void GUI_ThemKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            var frmkh = System.Windows.Forms.Application.OpenForms.OfType<GUI_DSKhachhang>().FirstOrDefault();
            if (frmkh != null)
            {
                frmkh.GUI_DSKhachhang_Load(sender, e);
            }
            var frmbh = System.Windows.Forms.Application.OpenForms.OfType<GUI_Taohdban>().FirstOrDefault();
            if (frmbh != null)
            {
                var listcus = buskh.GetAll();
                frmbh.Loadcbbkhachhang(listcus);
            }
        }
    }
}
