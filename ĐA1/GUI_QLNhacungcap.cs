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
    public partial class GUI_QLNhacungcap : Form
    {
        private BUS_QLNhacungcap busNCC = new BUS_QLNhacungcap();
        private BRAND brdFromform;
        private string selectedbrdID= "";

        public GUI_QLNhacungcap()
        {
            InitializeComponent();
        }

        private void btnTatcaNCC_Click(object sender, EventArgs e)
        {
            btnTatcaNCC.ForeColor = Color.FromArgb(90, 136, 255);
            btnTatcaNCC.CustomBorderColor = Color.FromArgb(94, 148, 255);
        }

        private void btnTatcaNCC_Leave(object sender, EventArgs e)
        {
            btnTatcaNCC.ForeColor = Color.Black;
            btnTatcaNCC.CustomBorderColor = Color.White;
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GUI_QLNhacungcap_Load(object sender, EventArgs e)
        {
            UpdateDgv(busNCC.GetAll());
        }

        private void UpdateDgv(List<BRAND> customerList)
        {
            dgvNCC.DataSource = customerList.Select(x => new { x.BRD_ID, x.BRD_NAME, x.BRD_ADDRESS, x.BRD_PHONE, x.BRD_EMAIL, x.BRD_STATUS }).ToList();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            UpdateDgv(busNCC.TimKiemNCC(txtTimkiemKH.Text.ToLower()));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTimkiemKH.Clear();
            GUI_QLNhacungcap_Load(sender, e);
;        }
    }
}
