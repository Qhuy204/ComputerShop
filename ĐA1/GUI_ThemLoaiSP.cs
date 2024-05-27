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
    public partial class GUI_ThemLoaiSP : Form
    {
        BUS_DSLoaiSP busdslsp = new BUS_DSLoaiSP();

        public string id, message;
        public GUI_ThemLoaiSP(string id, string message)
        {
            InitializeComponent();
            this.id = id;
            this.message = message;
            if (message == "create")
            {
                btnXoaKM.Visible = false;
                txtid.Text = busdslsp.GetNewID();
            }
            else
            {
                Loaddata();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string name = txtten.Text;
            if (name == "")
            {
                MessageBox.Show("Tên không được để trống");
                return;
            }
            if (message == "create")
            {
                string id = txtid.Text;
                busdslsp.NewPDT(id, name);
                MessageBox.Show("Lưu loại sản phẩm thành công!");
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục thêm loại sản phẩm mới không?", "Thêm khách hàng", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    Clearform();
                }
            }
            else
            {
                string id = txtid.Text;
                PRODUCTTYPE pdt = new PRODUCTTYPE
                {
                    PRD_TYPE_ID = id,
                    PRD_TYPE_NAME = name,
                };

                if (busdslsp.Update(pdt))
                {
                    MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        public void Clearform()
        {
            txtid.Text = busdslsp.GetNewID();
            txtten.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaKM_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            busdslsp.Delete(id);
            MessageBox.Show("Xóa thành công");
        }

        public void Loaddata()
        {
            txtid.Text = id;
            var data = busdslsp.GetByID(id);
            txtten.Text = data.PRD_TYPE_NAME.ToString();
        }
    }
}
