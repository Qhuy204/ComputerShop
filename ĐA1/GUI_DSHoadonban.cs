using System;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_DSHoadonban : Form
    {
        public string id;
        public GUI_DSHoadonban(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntaodonhangle_Click(object sender, EventArgs e)
        {
            GUI_Taohdban taohdban = new GUI_Taohdban("Giá lẻ", id);
            taohdban.ShowDialog();
        }

        private void btnTaodonhangsi_Click(object sender, EventArgs e)
        {
            GUI_Taohdban taohdban = new GUI_Taohdban("Giá sỉ", id); 
            taohdban.ShowDialog();
        }
    }
}
