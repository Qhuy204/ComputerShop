using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_Khuyenmai : Form
    {

        BUS_CodeKhuyenmai busMgg = new BUS_CodeKhuyenmai();


        public GUI_Khuyenmai()
        {
            InitializeComponent();
            pnMagiamgia.Enabled = false;
            pnMagiamgia.Visible = false;
            pnCTGG.Enabled = false;
            pnCTGG.Visible = false;
            btnMagiamgia.PerformClick();

        }

        private void btnMagiamgia_Click(object sender, EventArgs e)
        {
            pnMagiamgia.Enabled = true;
            pnMagiamgia.Visible = true;
            pnCTGG.Enabled = false;
            pnCTGG.Visible = false;
            Loaddgvmagg(busMgg.GetAll());
        }

        private void btnCtrinhgiamgia_Click(object sender, EventArgs e)
        {
            pnMagiamgia.Enabled = false;
            pnMagiamgia.Visible = false;
            pnCTGG.Enabled = true;
            pnCTGG.Visible = true;
        }

        private void btnTaokmai_Click(object sender, EventArgs e)
        {
            GUI_TaoKMOption km = new GUI_TaoKMOption();
            km.ShowDialog();
        }

        public void Openform(string keyword)
        {
            if (keyword == "Taomgg")
            {
                GUI_TaoMagiamgia taomgg = new GUI_TaoMagiamgia();
                taomgg.ShowDialog();
            }
            if (keyword == "TaoCTKM")
            {
                GUI_TaoCtrinhKm ctkm = new GUI_TaoCtrinhKm();
                ctkm.ShowDialog();
            }
        }

        public void Loaddgvmagg(List<DISCOUNT> dc)
        {
            dgvmagg.DataSource = dc.Select(x => new { x.CODE, x.CODE_DESCRIPTION, x.DISCOUNT_STATUS, x.MAXIMUM_USE, x.USED_COUNT, x.DISCOUNT_START_DATE, x.DISCOUNT_END_DATE }).ToList();
        }

    }
}
