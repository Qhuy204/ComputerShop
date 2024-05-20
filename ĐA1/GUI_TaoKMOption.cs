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
    public partial class GUI_TaoKMOption : Form
    {
        public GUI_TaoKMOption()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_TaoKMOption_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoma_Click(object sender, EventArgs e)
        {
            GUI_Khuyenmai km = new GUI_Khuyenmai();
            km.Openform("Taomgg");
            this.Close();

        }

        private void btnTaoctrinh_Click(object sender, EventArgs e)
        {
            GUI_Khuyenmai km = new GUI_Khuyenmai();
            km.Openform("TaoCTKM");
            this.Close();
        }
    }
}
