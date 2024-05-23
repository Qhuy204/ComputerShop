using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ĐA1
{
    public partial class GUI_ThemSP : Form
    {
        PictureBox[] pictureBoxes;
        private BUS_DSSanpham busSP = new BUS_DSSanpham();
        private BUS_DSLoaiSP busLoaiSP = new BUS_DSLoaiSP();
        private BUS_QLNhacungcap busNCC = new BUS_QLNhacungcap();
        private BUS_Khohang busKhohang = new BUS_Khohang();
        public GUI_ThemSP()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pbhinhanh };
        }

        private void ckbVanchuyen_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVanchuyen.Checked )
            {
                lblkhoiluong.Enabled = true;
                txtKhoiluong.Enabled = true;
            }
            else
            {
                lblkhoiluong.Enabled = false;
                txtKhoiluong.Enabled = false;
            }
        }


        private List<string> link_loaded = new List<string>(); // Declare a list to store loaded image paths
        private int current_picturebox = 0; // Keep track of the current PictureBox index

        private void btnThemanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string link = openFileDialog.FileName;

                // Load the image into the current PictureBox
                LoadAnhVaoPictureBox(link);

                // Add the image path to the list
                link_loaded.Add(link);

                // Update the position of the next PictureBox
                current_picturebox = (current_picturebox + 1) % pictureBoxes.Length;
            }
        }

        private void LoadAnhVaoPictureBox(string link)
        {
            // Create an array of PictureBox controls
            PictureBox[] pictureBoxes = { pbhinhanh};

            // Load the image into the current PictureBox
            pictureBoxes[current_picturebox].Image = System.Drawing.Image.FromFile(link);
            pictureBoxes[current_picturebox].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void UpdatecbbLoaisp(List<PRODUCTTYPE> pt)
        {
            var dataSource = pt.Select(x => new { x.PRD_TYPE_NAME }).ToList();
            cbbLoaiSP.DataSource = dataSource;
            cbbLoaiSP.DisplayMember = "PRD_TYPE_NAME";
            cbbLoaiSP.ValueMember = "PRD_TYPE_NAME";
            cbbLoaiSP.SelectedIndex = -1;
        }

        private void UpdatecbbNhanhieu(List<BRAND> bd)
        {
            var dataSource = bd.Select(x => new { x.BRD_NAME }).ToList();
            cbbNcc.DataSource = dataSource;
            cbbNcc.DisplayMember = "BRD_NAME";
            cbbNcc.ValueMember = "BRD_NAME";
            cbbNcc.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] image;
            if (pbhinhanh.Image != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                pbhinhanh.Image.Save(memoryStream, pbhinhanh.Image.RawFormat);
                image = memoryStream.ToArray();
                string id = busSP.GetNewID();
                string name = txtTensp.Text;
                string brand_id = busNCC.getBRD_ID(cbbNcc.Text);
                string producttype_id = busLoaiSP.getPD_TYPE_ID(cbbLoaiSP.Text);
                float importprice = float.Parse(txtgianhap.Text);
                float retailprice = float.Parse(txtGiabanle.Text);
                float wholesaleprice = float.Parse(txtgiabanbuon.Text);
                bool deliveryallowed = ckbVanchuyen.Checked;
                float weight = string.IsNullOrEmpty(txtKhoiluong.Text) ? 0 : float.Parse(txtKhoiluong.Text);
                busSP.NewProduct(image, id, name, brand_id, producttype_id, deliveryallowed, weight);
                busKhohang.AddProductInformation(id, importprice, retailprice, wholesaleprice);
                MessageBox.Show("Product saved successfully.");
            }
            else
            {
                MessageBox.Show("Không thể thêm sản phẩm mới! Lỗi Ảnh");
            }


            
        }

        private void GUI_ThemSP_Load(object sender, EventArgs e)
        {
            UpdatecbbLoaisp(busLoaiSP.GetAll());
            UpdatecbbNhanhieu(busNCC.GetAll());
        }
    }
}
