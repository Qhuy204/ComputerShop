using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_ThongtinSP : Form
    {
        public string id;
        BUS_Khohang buskho = new BUS_Khohang();
        BUS_DSLoaiSP busDSLoaiSP = new BUS_DSLoaiSP();
        BUS_QLNhacungcap busncc = new BUS_QLNhacungcap();
        public GUI_ThongtinSP(string a)
        {
            InitializeComponent();
            this.id = a;
            pictureBoxes = new PictureBox[] { pbhinhanh };
        }

        private void GUI_ThongtinSP_Load(object sender, EventArgs e)
        {
            var pt = busDSLoaiSP.GetAll();
            LoadcbbLoaisp(pt);
            var ncc = busncc.GetAll();
            Loadcbbnhacc(ncc);
            LoadData();
        }
        private void Loadcbbnhacc(List<BRAND> br)
        {
            var dataSource = br.Select(x => new { x.BRD_NAME }).ToList();
            cbbNcc.DataSource = dataSource;
            cbbNcc.DisplayMember = "BRD_NAME";
            cbbNcc.ValueMember = "BRD_NAME";
            cbbNcc.SelectedIndex = -1;
        }
        private void LoadcbbLoaisp(List<PRODUCTTYPE> pt)
        {
            var dataSource = pt.Select(x => new { x.PRD_TYPE_NAME }).ToList();
            cbbLoaiSP.DataSource = dataSource;
            cbbLoaiSP.DisplayMember = "PRD_TYPE_NAME";
            cbbLoaiSP.ValueMember = "PRD_TYPE_NAME";
            cbbLoaiSP.SelectedIndex = -1;
        }

        public void LoadData()
        {
            var data = buskho.GetByID(id);
            if (data != null)  
            {
                txtTensp.Text = data.PRD_NAME.ToString();
                var ncc = busncc.GetByID(data.BRD_ID);
                int selectedIndex = cbbNcc.FindStringExact(ncc.BRD_NAME.ToString());

                if (selectedIndex != -1)
                {
                    cbbNcc.SelectedIndex = selectedIndex;
                }
                else
                {
                    cbbNcc.SelectedIndex = -1;
                }
                var pt = busDSLoaiSP.GetByID(data.PRD_TYPE_ID);
                int selectedIndex2 = cbbLoaiSP.FindStringExact(pt.PRD_TYPE_ID.ToString());
                if (selectedIndex2 != -1)
                {
                    cbbLoaiSP.SelectedIndex = selectedIndex2;
                }
                else
                {
                    cbbLoaiSP.SelectedIndex = -1;
                }
                txtgianhap.Text = data.IMPORT_PRICE.ToString();
                txtGiabanle.Text = data.RETAIL_PRICE.ToString();
                txtgiabanbuon.Text = data.WHOLESALE_PRICE.ToString();
                if (data.PRD_IMG != null && data.PRD_IMG.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(data.PRD_IMG))
                    {
                        pbhinhanh.Image = Image.FromStream(ms);
                        pbhinhanh.SizeMode = PictureBoxSizeMode.StretchImage; 
                    }
                }
                else
                {
                    pbhinhanh.Image = null;
                }

            }
            else
            {
                MessageBox.Show("Không lấy được dữ liệu sản phẩm.");
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        PictureBox[] pictureBoxes;
        private List<string> link_loaded = new List<string>(); // Declare a list to store loaded image paths
        private int current_picturebox = 0; // Keep track of the current PictureBox index
        private void btnThaydoianh_Click(object sender, EventArgs e)
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
            PictureBox[] pictureBoxes = { pbhinhanh };

            // Load the image into the current PictureBox
            pictureBoxes[current_picturebox].Image = System.Drawing.Image.FromFile(link);
            pictureBoxes[current_picturebox].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra ảnh
                if (pbhinhanh.Image == null)
                {
                    MessageBox.Show("Không thể cập nhật thông tin sản phẩm! Thiếu ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Chuyển đổi ảnh sang dạng byte[]
                byte[] image;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pbhinhanh.Image.Save(memoryStream, pbhinhanh.Image.RawFormat);
                    image = memoryStream.ToArray();
                }

                // Kiểm tra và chuyển đổi dữ liệu đầu vào
                string idsp = id;
                string name = txtTensp.Text;
                string brand_id = busncc.getBRD_ID(cbbNcc.Text);
                string producttype_id = busDSLoaiSP.getPD_TYPE_ID(cbbLoaiSP.Text);
                if (!float.TryParse(txtgianhap.Text, out float importprice) ||
                    !float.TryParse(txtGiabanle.Text, out float retailprice) ||
                    !float.TryParse(txtgiabanbuon.Text, out float wholesaleprice) ||
                    !int.TryParse(txtsltonkho.Text, out int sltonkho) ||
                    !int.TryParse(txtSlcotheban.Text, out int cotheban))
                {
                    MessageBox.Show("Giá trị không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật dữ liệu vào cơ sở dữ liệu
                WAREHOUSE prd = new WAREHOUSE()
                {
                    PRD_ID = idsp,
                    PRD_NAME = name,
                    BRD_ID = brand_id,
                    PRD_TYPE_ID = producttype_id,
                    PRD_IMG = image,
                    IMPORT_PRICE = importprice,
                    RETAIL_PRICE = retailprice,
                    WHOLESALE_PRICE = wholesaleprice,
                    INVENTORY_QUANTITY = sltonkho,
                    RDY_FOR_SALE = cotheban
                };
                buskho.Update(prd);
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật dữ liệu. Hãy kiểm tra lại dữ liệu đầu vào!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
