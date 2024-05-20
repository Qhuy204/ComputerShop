using BUS;
using DAL;
using System;
using System.Collections.Generic;
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
            var allProducts = busSP.GetAll();
            var allProductTypes = busLoaiSP.GetAll();
            var allBrands = busNCC.GetAll();

            UpdateDgv(allProducts, allBrands, allProductTypes);
            UpdatecbbLoaisp(allProductTypes);
            UpdatecbbNhanhieu(allBrands);
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
            var allProducts = busSP.GetAll();
            var allProductTypes = busLoaiSP.GetAll();
            var allBrands = busNCC.GetAll();
            UpdateDgv(allProducts, allBrands, allProductTypes);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string brdid = busNCC.getBRD_ID(cbbNhanhieu.Text.ToLower());
            string ptid = busLoaiSP.getPD_TYPE_ID(cbbLoaisp.Text.ToLower());
            var filteredProducts = busSP.TimKiemSanPham(brdid, ptid, txtTimkiemSP.Text.ToLower());
            var allBrands = busNCC.GetAll();
            var allProductTypes = busLoaiSP.GetAll();
            UpdateDgv(filteredProducts, allBrands, allProductTypes);
        }

        private void UpdateDgv(List<PRODUCT> prd, List<BRAND> brd, List<PRODUCTTYPE> prdt)
        {
            var dataSource = (from p in prd
                              join b in brd on p.BRD_ID equals b.BRD_ID
                              join t in prdt on p.PRD_TYPE_ID equals t.PRD_TYPE_ID
                              select new
                              {
                                  p.PRD_ID,
                                  p.PRD_NAME,
                                  b.BRD_NAME,
                                  t.PRD_TYPE_NAME,
                                  p.RDY_FOR_SALE,
                                  p.QUANTITY,
                                  p.PRD_WEIGHT,
                                  p.CREATE_DAY
                              }).ToList();

            dgvSP.DataSource = dataSource;
        }
    }
}
