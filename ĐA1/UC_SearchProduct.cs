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
    public partial class UC_SearchProduct : UserControl
    {
        public UC_SearchProduct()
        {
            InitializeComponent();
        }

        public void Details(WAREHOUSE wr)
        {
            lblTensp.Text = wr.PRD_NAME;
            lblGiaban.Text = wr.RETAIL_PRICE.ToString();
            lblSoluong.Text = wr.INVENTORY_QUANTITY.ToString();

        }

        public string TempName { get; private set; }
        public static string CusName;

        public void TxtSearchResult(string key)
        {
            BUS_Khohang buskhohang = new BUS_Khohang();
            List<WAREHOUSE> wrh = buskhohang.SearchByName(key);

            if (wrh != null && wrh.Count > 0)
            {
                lblTensp.Text = string.Join(", ", wrh.Select(c => c.PRD_NAME));
                lblGiaban.Text = string.Join(", ", wrh.Select(c => c.RETAIL_PRICE));
                lblSoluong.Text = string.Join(", ", wrh.Select(c => c.INVENTORY_QUANTITY));
                TempName = string.Join(", ", wrh.Select(c => c.PRD_NAME));
            }
            else
            {
                lblTensp.Text = "Customer not found";
                TempName = string.Empty;
            }
        }

        private void SearchResult_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void SearchResult_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
