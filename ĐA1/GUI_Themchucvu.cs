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
    public partial class GUI_Themchucvu : Form
    {
        BUS_Quyen busquyen = new BUS_Quyen();
        BUS_Chucvu buscv = new BUS_Chucvu();
        BUS_QuyenofChucvu busqoc = new BUS_QuyenofChucvu();
        public GUI_Themchucvu()
        {
            InitializeComponent();
            var quyen = busquyen.GetAll();
            LoadData(quyen);
            txtma.Text = buscv.GetNewID();
        }

        public void LoadData(List<AUTHORITY> au)
        {
            dgvdsquyen.DataSource = au.Select(x => new { x.AUT_ID, x.AUT_NAME}).ToList();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string id = buscv.GetNewID();
            string name = txtChucvu.Text;
            string note = txtGhichu.Text;

            buscv.NewCV(id, name, note);

            foreach (DataGridViewRow row in dgvdsquyen.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["clcheck"].Value);

                    if (isChecked)
                    {
                        string autID = row.Cells["clMaquyen"].Value.ToString();

                        string newID = busqoc.GetNewID();

                        busqoc.NewCV(newID, id, autID);
                    }
                }
            }

            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
