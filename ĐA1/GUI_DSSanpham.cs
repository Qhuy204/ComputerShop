using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_DSSanpham : Form
    {
        private BUS_DSSanpham busSP = new BUS_DSSanpham();
        private BUS_DSLoaiSP busLoaiSP = new BUS_DSLoaiSP();
        private BUS_QLNhacungcap busNCC = new BUS_QLNhacungcap();
        
        private PRODUCT spFromform;

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

        private void GUI_DSSanpham_Load(object sender, EventArgs e)
        {
            UpdateDgv(busSP.GetAll());
            UpdatecbbLoaisp(busLoaiSP.GetAll());
            UpdatecbbNhanhieu(busNCC.GetAll());
        }

        private void UpdatecbbLoaisp(List<PRODUCTTYPE> pt)
        {
            var dataSource = pt.Select(x => new { x.PRD_TYPE_NAME }).ToList();
            cbbLoaisp.DataSource = dataSource;
            cbbLoaisp.DisplayMember = "PRD_TYPE_NAME"; 
            cbbLoaisp.ValueMember = "PRD_TYPE_NAME";
            cbbLoaisp.SelectedIndex = -1;
        }

        private void UpdatecbbNhanhieu(List<BRAND> bd)
        {
            var dataSource = bd.Select(x => new { x.BRD_NAME }).ToList();
            cbbNhanhieu.DataSource = dataSource;
            cbbNhanhieu.DisplayMember = "BRD_NAME";
            cbbNhanhieu.ValueMember = "BRD_NAME";
            cbbNhanhieu.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTimkiemSP.Clear();
            cbbLoaisp.SelectedIndex = -1;
            cbbNhanhieu.SelectedIndex = -1;
            UpdateDgv(busSP.GetAll());
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string brdid = busNCC.getBRD_ID(cbbNhanhieu.Text);
            string ptid = busLoaiSP.getPD_TYPE_ID(cbbLoaisp.Text);
            UpdateDgv(busSP.TimKiemSanPham(brdid, ptid, txtTimkiemSP.Text));
        }
        private void UpdateDgv(List<PRODUCT> prd)
        {
            dgvSP.DataSource = prd.Select(x => new { x.PRD_ID, x.PRD_NAME, x.PRD_TYPE_ID, x.BRD_ID, x.RDY_FOR_SALE, x.QUANTITY }).ToList();
        }

        
    }
}
