using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class UC_SearchResult : UserControl
    {

        public delegate void SearchResultClickedEventHandler(object sender, EventArgs e);

        public static event SearchResultClickedEventHandler SearchResultClicked;

        public UC_SearchResult()
        {
            InitializeComponent();
        }

        public void Details(CUSTOMER ctm)
        {
            btnSearch_result.Text = ctm.CUS_NAME;
            CusName = btnSearch_result.Text;
        }

        public string TempName { get; private set; }
        public static string CusName;

        public void TxtSearchResult(string key)
        {
            BUS_DSKhachhang busctm = new BUS_DSKhachhang();
            List<CUSTOMER> customers = busctm.SearchKhachhangByName(key);

            if (customers != null && customers.Count > 0)
            {
                btnSearch_result.Text = string.Join(", ", customers.Select(c => c.CUS_NAME));
                TempName = string.Join(", ", customers.Select(c => c.CUS_NAME));
            }
            else
            {
                btnSearch_result.Text = "Customer not found";
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

        public static bool Clicked = false;

        private void SearchResult_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_result_Click(object sender, EventArgs e)
        {
            if (SearchResultClicked != null)
            {
                SearchResultClicked(this, e);
            }
        }

        public static bool IsClicked()
        {
            return Clicked;
        }

        public string CustomerName()
        {
            return CusName;
        }
    }
}
