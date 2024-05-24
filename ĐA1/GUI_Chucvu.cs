using BUS;
using DAL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_Chucvu : Form
    {
        BUS_Chucvu buscvu = new BUS_Chucvu();
        BUS_Quyen busquyen = new BUS_Quyen();
        BUS_QuyenofChucvu busqoc = new BUS_QuyenofChucvu();
        public GUI_Chucvu(string id)
        {
            InitializeComponent();
            this.id = id;
            LoadData();
        }

        public string id;

        public void LoadData()
        {
            var data = buscvu.GetByID(id);

            if (data != null)
            {
                txtChucvu.Text = data.PS_NAME.ToString();
                txtma.Text = data.PS_ID.ToString();
                txtGhichu.Text = data.PS_NOTE.ToString();

                var qoc = busqoc.GetAll()
                                .Where(pa => pa.PS_ID == data.PS_ID)
                                .Join(busquyen.GetAll(), pa => pa.AUT_ID, a => a.AUT_ID, (pa, a) => a)
                                .ToList();

                dgvdsquyen.DataSource = qoc.Select(x => new{x.AUT_ID, x.AUT_NAME}).ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                buscvu.Delete(id);
                MessageBox.Show("Xóa thành công!");
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Thông tin đã thay đổi sẽ không được lưu. Bạn có muốn tiếp tục chỉnh sửa không?",
                "Chỉnh sửa thông tin",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                this.Close(); // 
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string id = txtma.Text;

            if (string.IsNullOrWhiteSpace(txtChucvu.Text))
            {
                MessageBox.Show("Tên chức vụ không được để trống.");
                return;
            }
            string name = txtChucvu.Text;

            string ghichu = txtGhichu.Text;



            POSITION ps = new POSITION
            {
                PS_ID = id,
                PS_NAME = name,
                PS_NOTE = ghichu
            };



            if (buscvu.Update(ps) == true)
            {
                MessageBox.Show("Cập nhật thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin chức vụ");
            }
        }


    }
}
