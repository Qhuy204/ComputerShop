using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace ĐA1
{
    public partial class GUI_Banhang : Form
    {
        private BUS_DSKhachhang busKH = new BUS_DSKhachhang();
        private BUS_Khohang busSP = new BUS_Khohang();

        public static string CusName;

        public GUI_Banhang()
        {
            InitializeComponent();
        }

        private void GUI_Banhang_Load(object sender, EventArgs e)
        {
            CheckIfClicked();
            cbbptthanhtoan.SelectedIndex = -1;
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

        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        public void CreateMomoQR()
        {
            // Text to encode in the QR code
            var qrcodeText = $"2|99|{"0856012976"}|{"Trương Quốc Huy"}|{"truongquochuy234@gmail.com"}|0|0|{lblcantra.Text.Trim()}";

            // Create a BarcodeWriter instance
            BarcodeWriter barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Width = 250,
                    Height = 250,
                    Margin = 0,
                    PureBarcode = false,
                    Hints = { { EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H } }
                },
                Renderer = new BitmapRenderer()
            };

            // Generate the QR code bitmap
            Bitmap bitmap = barcodeWriter.Write(qrcodeText);

            // Load and resize the logo
            Bitmap logo = ResizeImage(Properties.Resources.logo_momo, 64, 64) as Bitmap;

            // Draw the logo in the center of the QR code
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                int centerX = (bitmap.Width - logo.Width) / 2;
                int centerY = (bitmap.Height - logo.Height) / 2;
                g.DrawImage(logo, centerX, centerY);
            }

            // Set the QR code with the logo to a PictureBox
            pic_qrcode.Image = bitmap;
        }

        // Helper method to resize an image
        private Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void cbbptthanhtoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CreateMomoQR();
        }
    }
}
