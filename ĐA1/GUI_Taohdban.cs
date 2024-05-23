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
    public partial class GUI_Taohdban : Form
    {
        public GUI_Taohdban()
        {
            InitializeComponent();
            cbbBanggia.SelectedIndex = 1;
            pnThongtinnguoimua.Visible = false;
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            pnThongtinnguoimua.Visible = false;
            cbbKhachhang.SelectedIndex = -1;
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
