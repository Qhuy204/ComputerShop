using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_Banhang : Form
    {
        private BUS_DSKhachhang busKH = new BUS_DSKhachhang();
        private BUS_DSSanpham busSP = new BUS_DSSanpham();

        public static string CusName;

        public GUI_Banhang()
        {
            InitializeComponent();
        }

        private void GUI_Banhang_Load(object sender, EventArgs e)
        {
            CheckIfClicked();
        }

        private void LoadResultCustomer()
        {
            BUS_DSKhachhang busctm = new BUS_DSKhachhang();
            List<CUSTOMER> customers = busctm.SearchKhachhangByName(txtTimKH.Text.ToLower());

            Cus_resultcontainer.Controls.Clear();

            for (int i = 0; i < customers.Count; i++)
            {
                CUSTOMER cus = customers[i];
                UC_SearchResult res = new UC_SearchResult();
                res.Details(cus);
                Cus_resultcontainer.Controls.Add(res);
            }
        }

        private void LoadResultProduct()
        {
            BUS_Khohang busKhohang = new BUS_Khohang();
            List<WAREHOUSE> wr = busKhohang.SearchByName(txtTimkiemSP.Text.ToLower());

            pnSanpham.Controls.Clear();

            for (int i = 0; i < wr.Count; i++)
            {
                WAREHOUSE wrh = wr[i];
                UC_SearchProduct sp = new UC_SearchProduct();
                sp.Details(wrh);
                pnSanpham.Controls.Add(sp);
            }
        }


        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            /*if (txtTimKH.Text.Length >= 1)
            {
                Cus_resultcontainer.Controls.Clear();
                UC_SearchResult res = new UC_SearchResult();
                res.TxtSearchResult(txtTimKH.Text.ToLower());
                LoadResultCustomer();
                int newHeightKH = Cus_resultcontainer.Controls.Count * 47;

                Cus_resultcontainer.Height = Math.Min(newHeightKH, MaxHeight);
                res.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }
            else
            {
                Cus_resultcontainer.Height = 0;
            }*/

            if (txtTimKH.Text.Length >= 1)
            {
                var ctmList = busKH.GetByName(txtTimKH.Text);
                UpdateDgv(ctmList);
                if (dgvKH.Rows.Count > 0)
                {
                    Cus_resultcontainer.Height = dgvKH.Rows.Count * 30;
                }
                else
                {
                    Cus_resultcontainer.Height = 0;
                }
            }
            else
            {
                Cus_resultcontainer.Height = 0;
            }

        }

        private void UpdateDgv(CUSTOMER ctm)
        {
            dgvKH.DataSource = new List<object> { new { CUS_ID = ctm.CUS_ID, CUS_NAME = ctm.CUS_NAME } };
        }

        private void Cus_resultcontainer_Click(object sender, EventArgs e)
        {
            // Handle click event if needed
        }

        public void CheckIfClicked()
        {
            bool isclicked = UC_SearchResult.IsClicked();
            if (isclicked == true)
            {
                lblHotenKH.Visible = true;
                lblKH.Visible = true;
                lblHotenKH.Text = UC_SearchResult.CusName;
            }
        }

        private void txtTimKH_Leave(object sender, EventArgs e)
        {
            Cus_resultcontainer.Height = 0;
        }

        private void SearchResultControl_SearchResultClicked(object sender, EventArgs e)
        {
            // Gán giá trị cho lblTenKH từ btnSearch_result của user control SearchResult
            lblHotenKH.Text = UC_SearchResult.CusName;
            lblHotenKH.Visible = true;
            lblKH.Visible = true;
        }

        private const int MaxHeight = 400; // Chiều cao tối đa bạn muốn đặt cho pnSanpham

        private void txtTimkiemSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiemSP.Text.Length >= 1)
            {
                pnSanpham.Controls.Clear();
                UC_SearchProduct sp = new UC_SearchProduct();
                sp.TxtSearchResult(txtTimkiemSP.Text.ToLower());
                LoadResultProduct();

                // Tính chiều cao mới
                int newHeightSP = pnSanpham.Controls.Count * 70;

                // Đặt chiều cao của pnSanpham nhưng không vượt quá MaxHeight
                pnSanpham.Height = Math.Min(newHeightSP, MaxHeight);
            }
            else
            {
                pnSanpham.Height = 0;
            }
        }

        private void txtTimkiemSP_Leave(object sender, EventArgs e)
        {
            pnSanpham.Height = 0;
        }

        private void BtnDanhsachSP_Click(object sender, EventArgs e)
        {
            pnDSSanpham.Height = 300;
            pnDSSanpham.Controls.Clear();
            pnDSSanpham.Width = (int)(0.60f * this.Width); 
            var products = GetProducts(); 
            int margin = 10;
            int x = margin;
            int y = margin;

            for (int i = 0; i < products.Count; i++)
            {
                var productControl = new UC_ProductControl();
                productControl.SetProductDetails(products[i].PRD_NAME, products[i].INVENTORY_QUANTITY.ToString());

                // Kiểm tra nếu chiều ngang không đủ thì xuống dòng
                if (x + productControl.Width + margin > pnDSSanpham.Width)
                {
                    x = margin;
                    y += productControl.Height + margin;
                }

                productControl.Location = new Point(x, y);
                pnDSSanpham.Controls.Add(productControl);

                x += productControl.Width + margin;
            }

            pnDSSanpham.Visible = !pnDSSanpham.Visible; // Toggle visibility
        }


        public bool isvible = false;
        private List<WAREHOUSE> GetProducts()
        {
            BUS_Khohang buskhohang = new BUS_Khohang();
            List<WAREHOUSE> wrh = buskhohang.GetAll();
            return wrh;
        }



       
    }
}
