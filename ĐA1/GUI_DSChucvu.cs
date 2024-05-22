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
    public partial class GUI_DSChucvu : Form
    {
        DAL_Chucvu cv = new DAL_Chucvu();

        public GUI_DSChucvu()
        {
            InitializeComponent();
        }

        private void GUI_DSChucvu_Load(object sender, EventArgs e)
        {
            var cvu = cv.GetAll();
            Loaddgv(cvu);
        }

        public void Loaddgv(List<POSITION> ps)
        {
            dgvchucvu.DataSource = ps.Select(x => new { x.PS_ID, x.PS_NAME, x.PS_NOTE }).ToList(); ;
        }

        private void dgvchucvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvchucvu.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[0];
                string cv = cell.Value.ToString();
                //MessageBox.Show(cv);
                var chitietCV = Application.OpenForms.OfType<GUI_Chucvu>().FirstOrDefault();
                if (chitietCV != null)
                {
                    // Nếu đã mở, chỉ cần cập nhật dữ liệu
                    chitietCV.LoadData();
                }
                else
                {
                    // Nếu chưa mở, tạo mới và hiển thị
                    GUI_Chucvu chucvu = new GUI_Chucvu(cv);
                    chucvu.ShowDialog();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GUI_Themchucvu themcv = new GUI_Themchucvu();
            themcv.ShowDialog();
        }
    }
}
