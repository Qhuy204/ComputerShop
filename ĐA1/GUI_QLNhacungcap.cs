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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvNCC.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[0];
                string code = cell.Value.ToString();

                var thongtinNCC= Application.OpenForms.OfType<GUI_ThongtinNCC>().FirstOrDefault();
                if (thongtinNCC != null)
                {
                    thongtinNCC.LoadData();
                }
                else
                {
                    // Nếu chưa mở, tạo mới và hiển thị
                    GUI_ThongtinNCC newThongtinNCC= new GUI_ThongtinNCC(code, "");
                    newThongtinNCC.ShowDialog();
                }
            }
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

        private void btnThemnhacc_Click(object sender, EventArgs e)
        {
            GUI_ThongtinNCC ttincc = new GUI_ThongtinNCC("", "create");
            ttincc.ShowDialog();
        }

        private void btnThemnhacc_Click_1(object sender, EventArgs e)
        {
            GUI_ThongtinNCC ttinncc = new GUI_ThongtinNCC("", "create");
            ttinncc.ShowDialog();
        }
    }
}
