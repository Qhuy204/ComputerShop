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
    public partial class GUI_Khohang : Form
    {
        private BUS_Khohang busKhohang = new BUS_Khohang();
        private BUS_DSLoaiSP busLoaiSP = new BUS_DSLoaiSP();
        private BUS_QLNhacungcap busNCC = new BUS_QLNhacungcap();

        public GUI_Khohang()
        {
            InitializeComponent();
        }

        private void GUI_Khohang_Load(object sender, EventArgs e)
        {
            var allProducts = busKhohang.GetAll();
            var allProductTypes = busLoaiSP.GetAll();
            var allBrands = busNCC.GetAll();

            UpdateDgv(allProducts, allBrands, allProductTypes);
        }

        private void UpdateDgv(List<WAREHOUSE> prd)
        {
            dgvKH.DataSource = prd.Select(x => new { x.PRD_IMG, x.PRD_ID, x.PRD_NAME, x.PRD_TYPE_ID, x.BRD_ID, x.RDY_FOR_SALE, x.INVENTORY_QUANTITY, x.CREATE_DAY, x.RETAIL_PRICE, x.IMPORT_PRICE, x.WHOLESALE_PRICE }).ToList();
        }

        private void UpdateDgv(List<WAREHOUSE> prd, List<BRAND> brd, List<PRODUCTTYPE> prdt)
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
                                  p.INVENTORY_QUANTITY,
                                  p.RETAIL_PRICE,
                                  p.CREATE_DAY,
                                  p.WHOLESALE_PRICE,
                                  p.IMPORT_PRICE,
                              }).ToList();

            dgvKH.DataSource = dataSource;
        }
    }
}
