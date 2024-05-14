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
    public partial class GUI_ThemSP : Form
    {
        PictureBox[] pictureBoxes;

        public GUI_ThemSP()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pb1, pb2, pb3, pb4 };
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
            PictureBox[] pictureBoxes = { pb1, pb2, pb3, pb4 };

            // Load the image into the current PictureBox
            pictureBoxes[current_picturebox].Image = Image.FromFile(link);
            pictureBoxes[current_picturebox].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
