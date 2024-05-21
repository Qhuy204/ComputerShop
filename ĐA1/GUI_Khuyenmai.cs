using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_Khuyenmai : Form
    {

        BUS_CodeKhuyenmai busMgg = new BUS_CodeKhuyenmai();
        BUS_CTKhuyenmai busCtkm = new BUS_CTKhuyenmai();

        public GUI_Khuyenmai()
        {
            InitializeComponent();
            

        }

        private void btnMagiamgia_Click(object sender, EventArgs e)
        {
            pnMagiamgia.Enabled = true;
            pnMagiamgia.Visible = true;
            pnCTGG.Enabled = false;
            pnCTGG.Visible = false;
            Loaddgvmagg(busMgg.GetAll());
        }

        public void btnCtrinhgiamgia_Click(object sender, EventArgs e)
        {
            pnMagiamgia.Enabled = false;
            pnMagiamgia.Visible = false;
            pnCTGG.Enabled = true;
            pnCTGG.Visible = true;
            Loaddgvctrinhgg(busCtkm.GetAll());
        }

        private void btnTaokmai_Click(object sender, EventArgs e)
        {
            GUI_TaoKMOption km = new GUI_TaoKMOption();
            km.ShowDialog();
        }

        public void Openform(string keyword)
        {
            if (keyword == "Taomgg")
            {
                GUI_TaoMagiamgia taomgg = new GUI_TaoMagiamgia();
                taomgg.ShowDialog();
            }
            if (keyword == "TaoCTKM")
            {
                GUI_TaoCtrinhKm ctkm = new GUI_TaoCtrinhKm();
                ctkm.ShowDialog();
            }
        }

        public void Loaddgvmagg(List<DISCOUNT> dc)
        {
            dgvmagg.DataSource = dc.Select(x => new { x.CODE, x.CODE_DESCRIPTION, x.DISCOUNT_STATUS, x.MAXIMUM_USE, x.USED_COUNT, x.DISCOUNT_START_DATE, x.DISCOUNT_END_DATE }).ToList();
        }

        public void Loaddgvctrinhgg(List<PROMOTION> pm)
        {
            dgvctrinhgg.DataSource = pm.Select(x => new { x.PROMOTION_NAME, x.PROMOTION_DESCRIPTION, x.PROMOTION_STATUS, x.USED_COUNT, x.MAXIMUM_USE, x.PROMOTION_START_DATE, x.PROMOTION_END_DATE }).ToList();
        }

        private void dgvmagg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvmagg.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[0];
                string code = cell.Value.ToString();

                // Kiểm tra xem form GUI_ThongtinMGG đã mở hay chưa
                var thongtinMGGForm = Application.OpenForms.OfType<GUI_ThongtinMGG>().FirstOrDefault();
                if (thongtinMGGForm != null)
                {
                    // Nếu đã mở, chỉ cần cập nhật dữ liệu
                    thongtinMGGForm.LoadData();
                }
                else
                {
                    // Nếu chưa mở, tạo mới và hiển thị
                    GUI_ThongtinMGG newThongtinMGGForm = new GUI_ThongtinMGG(code);
                    newThongtinMGGForm.ShowDialog();
                }
            }
        }

        private void dgvctrinhgg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvctrinhgg.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[0];
                string name = cell.Value.ToString();
                var data = busCtkm.getCTKM_ID(name);
                string id = data;

                // Kiểm tra xem form GUI_ThongtinMGG đã mở hay chưa
                var thongtinMGGForm = Application.OpenForms.OfType<GUI_ThongtinMGG>().FirstOrDefault();
                if (thongtinMGGForm != null)
                {
                    // Nếu đã mở, chỉ cần cập nhật dữ liệu
                    thongtinMGGForm.LoadData();
                }
                else
                {
                    // Nếu chưa mở, tạo mới và hiển thị
                    GUI_ThongtinCTKM newThongtinCTKM= new GUI_ThongtinCTKM(id);
                    newThongtinCTKM.ShowDialog();
                }
            }
        }

        public void GUI_Khuyenmai_Load(object sender, EventArgs e)
        {
            pnMagiamgia.Enabled = false;
            pnMagiamgia.Visible = false;
            pnCTGG.Enabled = false;
            pnCTGG.Visible = false;
            btnMagiamgia.PerformClick();
        }
    }
}
