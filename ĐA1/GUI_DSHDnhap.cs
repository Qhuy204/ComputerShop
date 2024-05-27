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
    public partial class GUI_DSHDnhap : Form
    {
        BUS_Hoadonnhaphang bushdnh = new BUS_Hoadonnhaphang();
        BUS_CTHoadonnhaphang busctnh = new BUS_CTHoadonnhaphang();

        public GUI_DSHDnhap()
        {
            InitializeComponent();
            var data = bushdnh.GetAll();
            Loaddgv(data);
        }

        private void Loaddgv(List<IMPORTBILL> sl)
        {

            dgvhdban.DataSource = sl.Select(x => new { x.IB_ID, x.BRD_ID, x.NOTE, x.EMP_ID, x.IB_DATE, x.TOTAL_MONEY}).ToList();
        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            GUI_ThemCTHDNhap cthdn = new GUI_ThemCTHDNhap();
            cthdn.ShowDialog();
        }
    }
}
