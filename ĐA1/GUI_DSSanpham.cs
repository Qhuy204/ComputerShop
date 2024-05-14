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
    public partial class GUI_DSSanpham : Form
    {
        public event EventHandler ThemSanPhamClicked;

        public GUI_DSSanpham()
        {
            InitializeComponent();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            GUI_ThemSP themSP = new GUI_ThemSP();
            themSP.ShowDialog();
        }
    }
}
