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
        public GUI_QLNhacungcap()
        {
            InitializeComponent();
        }


        private void btnKQtimkiem_Click(object sender, EventArgs e)
        {
            btnKQtimkiem.ForeColor = Color.FromArgb(90, 136, 255);
            btnKQtimkiem.CustomBorderColor = Color.FromArgb(94, 148, 255);
        }

        private void btnKQtimkiem_Leave(object sender, EventArgs e)
        {
            btnKQtimkiem.ForeColor = Color.Black;
            btnKQtimkiem.CustomBorderColor = Color.White;
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
    }
}
