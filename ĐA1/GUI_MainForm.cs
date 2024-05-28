using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_MainForm : Form
    {
        public string quyen;
        public string hoten;
        public string id;
        public GUI_MainForm(string a, string b, string c)
        {
            InitializeComponent();
            GUI_Tongquan frm = new GUI_Tongquan();
            FormHelper.HienThiFormCon(frm, pnNoidung);
            lblFuncName.Text = btnTongquan.Text;
            this.quyen = a;
            this.hoten = b;
            lblTenquyen.Text = a;
            lblten.Text = b;
            id = c;
            if (quyen == "Nhân viên quản lý kho")
            {
                btnBanhang.Visible = false;
                btnbaocao.Visible = false;
                btnDsnhanvien.Visible = false;
                btndonbanhang.Visible = false;
                btnKhachhang.Visible = false;
                btnKhuyenmai.Visible = false;
                btnNhaphang.Visible = false;
                btnqlchucvu.Visible = false;
            }
        }

        // Giả sử các biến này đã tồn tại và được khởi tạo
        private bool menuExpanded = false; // Trạng thái menu (ban đầu là đóng)
        private const int MENU_HEIGHT_EXPANDED = 282;
        private const int MENU_HEIGHT_COLLAPSED = 47;
        private const int MENU_TRANSITION_SPEED = 5;

        private void Menutransition_Tick(object sender, EventArgs e)
        {
            if (menuExpanded)
            {
                // Đang mở, thu gọn menu
                MenuSanpham.Height -= MENU_TRANSITION_SPEED;
                if (MenuSanpham.Height <= MENU_HEIGHT_COLLAPSED)
                {
                    MenuSanpham.Height = MENU_HEIGHT_COLLAPSED; 
                    menuExpanded = false; 
                    Menutransition.Stop(); 
                }
            }
            else
            {
                MenuSanpham.Height += MENU_TRANSITION_SPEED;
                if (MenuSanpham.Height >= MENU_HEIGHT_EXPANDED)
                {
                    MenuSanpham.Height = MENU_HEIGHT_EXPANDED; 
                    menuExpanded = true; 
                    Menutransition.Stop(); 
                }
            }
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            Chuyendong(sender);
            Menutransition.Start(); 
            btnSanpham.FillColor = Color.FromArgb(0, 136, 255);
            lblFuncName.Text = btnSanpham.Text;
        }

        private bool sidebarExpanded = false; 
        private const int HEIGHT_EXPANDED = 141;
        private const int HEIGHT_COLLAPSED = 47;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                // Đang mở, thu gọn menu
                pnDonhang.Height -= MENU_TRANSITION_SPEED;
                if (pnDonhang.Height <= HEIGHT_COLLAPSED)
                {
                    pnDonhang.Height = HEIGHT_COLLAPSED; 
                    sidebarExpanded = false; 
                    sidebarTransition.Stop();
                }
            }
            else
            {
                // Đang đóng, mở rộng menu
                pnDonhang.Height += MENU_TRANSITION_SPEED;
                if (pnDonhang.Height >= HEIGHT_EXPANDED)
                {
                    pnDonhang.Height = HEIGHT_EXPANDED; 
                    sidebarExpanded = true; 
                    sidebarTransition.Stop();
                }
            }
        }

        private void HienThiFormCon(Form frm)
        {
            pnNoidung.Controls.Clear();

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnNoidung.Controls.Add(frm);

            frm.Show();
        }

        public void HienThiFormCon(Form frm, Panel panel)
        {
            panel.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }


        private void mainbutton_Leave(object sender, EventArgs e)
        {
            // Lấy button vừa nhấn
            Guna2Button button = (Guna2Button)sender;

            // Thay đổi FillColor và ForeColor của button
            button.FillColor = Color.FromArgb(24, 37, 55);
        }
        private void subbutton_Leave(object sender, EventArgs e)
        {
            // Lấy button vừa nhấn
            Guna2Button button = (Guna2Button)sender;

            // Thay đổi FillColor và ForeColor của button
            button.ForeColor = Color.White;
        }

        public void btnKhachhang_Click(object sender, EventArgs e)
        {
            Chuyendong(sender);
            GUI_DSKhachhang frm = new GUI_DSKhachhang();
            FormHelper.HienThiFormCon(frm, pnNoidung);
            lblFuncName.Text = btnKhachhang.Text;
        }

        public void btnTongquan_Click(object sender, EventArgs e)
        {
            Chuyendong(sender);
            GUI_Tongquan frm = new GUI_Tongquan();
            FormHelper.HienThiFormCon(frm, pnNoidung);
            lblFuncName.Text = btnTongquan.Text;
        }

        public void Chuyendong(object sender)
        {
            // Lấy button vừa nhấn
            Guna2Button button = (Guna2Button)sender;

            // Thay đổi FillColor và ForeColor của button
            button.FillColor = Color.FromArgb(0, 136, 255);
            lblFuncName.Text = button.Text;
            if (menuExpanded == true)
            {
                Menutransition.Start();
            }
            if (sidebarExpanded == true)
            {
                sidebarTransition.Start();
            }
        }

        public void btnDSSP_Click(object sender, EventArgs e)
        {
            GUI_DSSanpham frm = new GUI_DSSanpham();
            HienThiFormCon(frm);
            lblFuncName.Text = btnDSSP.Text;

        }

        public void btnQLkho_Click(object sender, EventArgs e)
        {
            GUI_Khohang frm = new GUI_Khohang();
            HienThiFormCon(frm);
            lblFuncName.Text = btnQLkho.Text;

        }

        public void btnbaocao_Click(object sender, EventArgs e)
        {
            Chuyendong(sender);
            lblFuncName.Text = btnbaocao.Text;
            GUI_Thongke km = new GUI_Thongke();
            HienThiFormCon(km);
        }

        public void btnCauhinh_Click(object sender, EventArgs e)
        {
            Chuyendong(sender);
            GUI_DSNhanvien frm = new GUI_DSNhanvien();
            FormHelper.HienThiFormCon(frm, pnNoidung);
            lblFuncName.Text = btnTongquan.Text;
        }

        public void btnNhacc_Click(object sender, EventArgs e)
        {
            GUI_QLNhacungcap frm = new GUI_QLNhacungcap();
            HienThiFormCon(frm);
            lblFuncName.Text = btnNhacc.Text;
        }

        public void btnBanle_Click(object sender, EventArgs e)
        {
            GUI_Taohdban frm = new GUI_Taohdban("Giá bán lẻ", id);
            FormHelper.HienThiFormCon(frm, pnNoidung);
            lblFuncName.Text = btnBanhang.Text; 
        }

        public void btnDonhang_Click(object sender, EventArgs e)
        {
            Chuyendong(sender);
            lblFuncName.Text = btnDonhang.Text;
            sidebarTransition.Start();
        }

        public void btnLoaiSP_Click(object sender, EventArgs e)
        {
            lblFuncName.Text = btnLoaiSP.Text;
            GUI_DSLoaiSP dsloaisp = new GUI_DSLoaiSP();
            FormHelper.HienThiFormCon(dsloaisp, pnNoidung);
        }

        public void btnLogout_Click(object sender, EventArgs e)
        {
            GUI_Dangnhap dn = new GUI_Dangnhap();
            dn.Show();
            this.Close();

        }

        public void btnqlchucvu_Click(object sender, EventArgs e)
        {
            Chuyendong(sender);
            GUI_DSChucvu frm = new GUI_DSChucvu();
            FormHelper.HienThiFormCon(frm, pnNoidung);
            HienThiFormCon(frm);
            lblFuncName.Text = btnqlchucvu.Text;
        }

        public void btndonbanhang_Click(object sender, EventArgs e)
        {
            GUI_DSHoadonban frm = new GUI_DSHoadonban(id);
            FormHelper.HienThiFormCon(frm, pnNoidung);
            HienThiFormCon(frm);
            lblFuncName.Text = btndonbanhang.Text;
        }

        public void btnKhuyenmai_Click(object sender, EventArgs e)
        {
            Chuyendong(sender);
            GUI_Khuyenmai frm = new GUI_Khuyenmai();
            FormHelper.HienThiFormCon(frm, pnNoidung);
            HienThiFormCon(frm);
            lblFuncName.Text = btnKhuyenmai.Text;
        }

        public void btnDonnhap_Click(object sender, EventArgs e)
        {
            lblFuncName.Text = btnDonnhap.Text;
            GUI_DSHDnhap frm = new GUI_DSHDnhap(id);
            FormHelper.HienThiFormCon(frm, pnNoidung);
        }
    }
}
