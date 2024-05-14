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
        public GUI_MainForm()
        {
            InitializeComponent();
            GUI_Tongquan frm = new GUI_Tongquan();
            FormHelper.HienThiFormCon(frm, pnNoidung);
            lblFuncName.Text = btnTongquan.Text;
        }

        // Giả sử các biến này đã tồn tại và được khởi tạo
        private bool menuExpanded = false; // Trạng thái menu (ban đầu là đóng)
        private const int MENU_HEIGHT_EXPANDED = 235;
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
                    menuExpanded = false;
                    Menutransition.Stop(); // Dừng timer khi menu đã đóng
                }
            }
            else
            {
                // Đang đóng, mở rộng menu
                MenuSanpham.Height += MENU_TRANSITION_SPEED;
                if (MenuSanpham.Height >= MENU_HEIGHT_EXPANDED)
                {
                    menuExpanded = true;
                    Menutransition.Stop(); // Dừng timer khi menu đã mở
                }
            }
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            Menutransition.Start();
            btnSanpham.FillColor = Color.FromArgb(0, 136, 255);
            lblFuncName.Text = btnSanpham.Text;
        }

        // Giả sử các biến này đã được định nghĩa đúng trước đó
        private bool sidebarExpanded = true; // Trạng thái ban đầu: mở
        private const int SIDEBAR_WIDTH_OPEN = 221;
        private const int SIDEBAR_WIDTH_CLOSED = 37;
        private const int SIDEBAR_TRANSITION_SPEED = 5; // Tốc độ thay đổi chiều rộng

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                // Đang mở, chuyển sang trạng thái đóng
                sidebar.Width -= SIDEBAR_TRANSITION_SPEED;
                if (sidebar.Width <= SIDEBAR_WIDTH_CLOSED)
                {
                    sidebarExpanded = false;
                    sidebarTransition.Stop(); // Dừng timer khi đã đóng
                }
            }
            else
            {
                // Đang đóng, chuyển sang trạng thái mở
                sidebar.Width += SIDEBAR_TRANSITION_SPEED;
                if (sidebar.Width >= SIDEBAR_WIDTH_OPEN)
                {
                    sidebarExpanded = true;
                    sidebarTransition.Stop(); // Dừng timer khi đã mở
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
            // Xóa các form con hiện có khỏi panel
            panel.Controls.Clear();

            // Cài đặt thuộc tính cho form con
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            // Thêm form con vào panel
            panel.Controls.Add(frm);

            // Hiển thị form con
            frm.Show();
        }

        private void mainbutton_Click(object sender, EventArgs e)
        {
            
        }
        private void subbutton_Click(object sender, EventArgs e)
        {
            
        }
        private void mainbutton_Leave(object sender, EventArgs e)
        {
            // Lấy button vừa nhấn
            Guna2Button button = (Guna2Button)sender;

            // Thay đổi FillColor và ForeColor của button
            button.FillColor = Color.FromArgb(24, 37, 55);
            lblFuncName.Text = null;
        }
        private void subbutton_Leave(object sender, EventArgs e)
        {
            // Lấy button vừa nhấn
            Guna2Button button = (Guna2Button)sender;

            // Thay đổi FillColor và ForeColor của button
            button.ForeColor = Color.White;
            lblFuncName.Text = null;
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            Chuyendong(sender);
            GUI_DSKhachhang frm = new GUI_DSKhachhang();
            FormHelper.HienThiFormCon(frm, pnNoidung);
            lblFuncName.Text = btnKhachhang.Text;
        }

        private void btnTongquan_Click(object sender, EventArgs e)
        {
            //pnNoidung.Hide();
        }

        private void Chuyenmau(object sender)
        {
            // Lấy button vừa nhấn
            Guna2Button button = (Guna2Button)sender;

            // Thay đổi FillColor và ForeColor của button
            button.ForeColor = Color.FromArgb(0, 136, 255);
            lblFuncName.Text = button.Text;
        }

        private void Chuyendong(object sender)
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
        }

        private void btnDSSP_Click(object sender, EventArgs e)
        {
            Chuyenmau(sender);
            GUI_DSSanpham frm = new GUI_DSSanpham();
            HienThiFormCon(frm);
        }

        private void btnQLkho_Click(object sender, EventArgs e)
        {
            Chuyenmau(sender);
            GUI_Khohang frm = new GUI_Khohang();
            HienThiFormCon(frm);
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Chuyendong(sender);
            lblFuncName.Text = btnbaocao.Text;
        }

        private void btnCauhinh_Click(object sender, EventArgs e)
        {
            Chuyendong(sender);
            GUI_ThongtinTK frm = new GUI_ThongtinTK();
            FormHelper.HienThiFormCon(frm, pnNoidung);
            lblFuncName.Text = btnTongquan.Text;
        }
    }
}
