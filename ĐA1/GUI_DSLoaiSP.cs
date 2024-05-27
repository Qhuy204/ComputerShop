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
    public partial class GUI_DSLoaiSP : Form
    {
        BUS_DSLoaiSP busloaisp = new BUS_DSLoaiSP();

        public GUI_DSLoaiSP()
        {
            InitializeComponent();
            var data = busloaisp.GetAll();
            Loaddgv(data);

        }

        public void Loaddgv(List<PRODUCTTYPE> pdt)
        {
            dgvloaisp.DataSource = pdt.Select(x => new {x.PRD_TYPE_ID, x.PRD_TYPE_NAME}).ToList();
        }

        private void bththemlsp_Click(object sender, EventArgs e)
        {
            GUI_ThemLoaiSP themlsp = new GUI_ThemLoaiSP("", "create");
            themlsp.ShowDialog();
        }

        private void dgvloaisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvloaisp.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[0];
                string code = cell.Value.ToString();

                var thongtinLSP = Application.OpenForms.OfType<GUI_ThemLoaiSP>().FirstOrDefault();
                if (thongtinLSP != null)
                {
                    thongtinLSP.Loaddata();
                }
                else
                {
                    // Nếu chưa mở, tạo mới và hiển thị
                    GUI_ThemLoaiSP newThongtinLSP = new GUI_ThemLoaiSP(code, "");
                    newThongtinLSP.ShowDialog();
                }
            }
        }
    }
}
