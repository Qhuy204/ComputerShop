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
    public partial class GUI_TaoCtrinhKm : Form
    {
        BUS_DSSanpham busSP = new BUS_DSSanpham();
        public GUI_TaoCtrinhKm()
        {
            InitializeComponent();
        }

        public void LoadcbbTenSP(List<PRODUCT> prd)
        {
            var sp = prd.Select(x => new { x.PRD_NAME }).ToList();
            cbbTenSP.DataSource = sp;
            cbbTenSP.DisplayMember = "PRD_NAME";
            cbbTenSP.ValueMember = "PRD_NAME";
        }

        private void LoadcbbLoaisp(List<PRODUCTTYPE> pt)
        {
            var dataSource = pt.Select(x => new { x.PRD_TYPE_NAME }).ToList();
            cbbLoaiSP.DataSource = dataSource;
            cbbLoaiSP.DisplayMember = "PRD_TYPE_NAME";
            cbbLoaiSP.ValueMember = "PRD_TYPE_NAME";
            cbbLoaiSP.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Nếu bạn hủy các thay đổi này thì thông tin đã điền. Bạn có muốn tiếp tục thêm không?",
                "Hủy thêm CTKM",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                this.Close(); // 
            }
        }
    }
}
