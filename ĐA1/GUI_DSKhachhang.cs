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
    public partial class GUI_DSKhachhang : Form
    {
        BUS_DSKhachhang busKH = new BUS_DSKhachhang();
        public GUI_DSKhachhang()
        {
            InitializeComponent();
        }

        private void btnNhapfile_MouseLeave(object sender, EventArgs e)
        {
            btnNhapfile.ForeColor = Color.Black;
        }

        private void btnNhapfile_MouseEnter(object sender, EventArgs e)
        {
            btnNhapfile.ForeColor = Color.FromArgb(0, 136, 255);
        }

        private void btnXuatfile_MouseLeave(object sender, EventArgs e)
        {
            btnXuatfile.ForeColor = Color.Black;
        }

        private void btnXuatfile_MouseEnter(object sender, EventArgs e)
        {
            btnXuatfile.ForeColor = Color.FromArgb(0, 136, 255);
        }

        private void btnKQtimkiem_Leave(object sender, EventArgs e)
        {
            btnKQtimkiem.ForeColor = Color.Black;
            btnKQtimkiem.CustomBorderColor = Color.White;
        }

        private void btnKQtimkiem_Click(object sender, EventArgs e)
        {
            btnKQtimkiem.ForeColor = Color.FromArgb(90, 136, 255);
            btnKQtimkiem.CustomBorderColor = Color.FromArgb(94, 148, 255);
        }

        private void btnTatcakh_Click(object sender, EventArgs e)
        {
            btnTatcakh.ForeColor = Color.FromArgb(90, 136, 255);
            btnTatcakh.CustomBorderColor = Color.FromArgb(94, 148, 255);
        }

        private void btnTatcakh_Leave(object sender, EventArgs e)
        {
            btnTatcakh.ForeColor = Color.Black;
            btnTatcakh.CustomBorderColor = Color.White;
        }

        private void txtTimkiemKH_Click(object sender, EventArgs e)
        {
            txtTimkiemKH.Text = null;
        }

        private void GUI_DSKhachhang_Load(object sender, EventArgs e)
        {
            UpdateDgv(busKH.GetAll());
        }

        private void UpdateDgv(List<CUSTOMER> ctm)
        {
            dgvKH.DataSource = ctm.Select(x => new { x.CUS_ID, x.CUS_NAME, x.CUS_BIRTHDAY, x.CUS_GENDER, x.CUS_PHONE_NUMBER, x.CUS_ADDRESS, x.CUS_TOTAL_SPENDING_MONEY, x.CUS_TOTAL_PRODUCTS_PURCHASED, x.CUS_TOTAL_QUANTITY_OF_ORDER }).ToList();
        }
    }
}
