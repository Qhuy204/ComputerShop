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
    public partial class UC_ProductControl : UserControl
    {

        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string Supplier { get; set; }
        public Image ProductImage { get; set; }


        public UC_ProductControl()
        {
            InitializeComponent();
        }

        public void SetProductDetails(string name, string quantity)
        {
            BUS_Khohang buskhohang = new BUS_Khohang();
            List<WAREHOUSE> wrh = buskhohang.GetAll();

            ProductName = name;
            Quantity = quantity;
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblTensp.Text = ProductName;
            lblSoluong.Text = Quantity;
        }
    }
}
