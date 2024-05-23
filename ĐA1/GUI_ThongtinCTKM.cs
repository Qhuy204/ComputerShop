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
    public partial class GUI_ThongtinCTKM : Form
    {
        BUS_CTKhuyenmai busCtkm = new BUS_CTKhuyenmai();
        BUS_DSLoaiSP busDSLoaiSP = new BUS_DSLoaiSP();
        BUS_DSSanpham busDSSP = new BUS_DSSanpham();

        public string id;

        public GUI_ThongtinCTKM(string id)
        {
            InitializeComponent();
            this.id = id;
            LoadData();
        }

        public void LoadcbbTenSP(List<PRODUCT> prd)
        {
            var sp = prd.Select(x => new { x.PRD_NAME }).ToList();
            cbbTenSP.DataSource = sp;
            cbbTenSP.DisplayMember = "PRD_NAME";
            cbbTenSP.ValueMember = "PRD_NAME";
        }

        private void LoadcbbLoaisp(List<PRODUCTTYPE> pt)
        {
            var dataSource = pt.Select(x => new { x.PRD_TYPE_NAME }).ToList();
            cbbLoaiSP.DataSource = dataSource;
            cbbLoaiSP.DisplayMember = "PRD_TYPE_NAME";
            cbbLoaiSP.ValueMember = "PRD_TYPE_NAME";
            cbbLoaiSP.SelectedIndex = -1;
        }

        private void GUI_ThongtinCTKM_Load(object sender, EventArgs e)
        {
            var loaisp = busDSLoaiSP.GetAll();
            var tensp = busDSSP.GetAll();
            LoadcbbLoaisp(loaisp);
            LoadcbbTenSP(tensp);
            txtMakm.Focus();
            LoadData();
        }

        public void LoadData()
        {
            var data = busCtkm.GetByID(id);

            if (data != null)  // Kiểm tra null
            {
                txtMakm.Text = data.PROMOTION_NAME.ToString();
                txtMota.Text = data.PROMOTION_DESCRIPTION.ToString();

                // Định dạng ngày tháng
                dtpBatdau.Value = DateTime.Parse(data.PROMOTION_START_DATE.ToString());
                dtpKetthuc.Value = DateTime.Parse(data.PROMOTION_END_DATE.ToString());

                txtTrangthai.Text = data.PROMOTION_STATUS.ToString();

                // Kiểm tra kiểu dữ liệu và chuyển đổi nếu cần
                if (data.DISCOUNT_AMOUNT != null)
                {
                    txtMucgiam.Text = data.DISCOUNT_AMOUNT.Value.ToString();
                    if (data.DISCOUNT_AMOUNT.Value >= 100)
                    {
                        cbbdonvi1.SelectedIndex = 0;
                    }
                    else
                    {
                        cbbdonvi1.SelectedIndex = 1;
                    }
                }

                if (data.PRD_TYPE_NAME != null)
                {
                    int selectedIndex = cbbLoaiSP.FindStringExact(data.PRD_TYPE_NAME);

                    if (selectedIndex != -1)
                    {
                        cbbLoaiSP.SelectedIndex = selectedIndex;
                    }
                    else
                    {
                        cbbLoaiSP.SelectedIndex = -1;
                    }
                }

                if (data.PRD_NAME != null)
                {
                    int selectedIndex = cbbTenSP.FindStringExact(data.PRD_NAME);

                    if (selectedIndex != -1)
                    {
                        cbbTenSP.SelectedIndex = selectedIndex;
                    }
                    else
                    {
                        cbbTenSP.SelectedIndex = -1;
                    }
                }

                txtgtritoithieu.Text = data.MIN_PURCHASE_VALUE.ToString();
                txtsoluongtoithieu.Text = data.MIN_QUANTITY_OF_PRODUCT.ToString();
                txtSLsudung.Text = data.MAXIMUM_USE.ToString();
                txtDasd.Text = data.USED_COUNT.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã khuyến mãi.");
                this.Close();
            }
        }

        private void GUI_ThongtinCTKM_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Lấy form GUI_Khuyenmai
            var mainForm = Application.OpenForms.OfType<GUI_Khuyenmai>().FirstOrDefault();

            if (mainForm != null)
            {
                // Gọi PerformClick trên btnCtrinhgiamgia của form GUI_Khuyenmai
                mainForm.btnCtrinhgiamgia.PerformClick();
            }
        }

        private void btnXoaKM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                busCtkm.Delete(id);
                MessageBox.Show("Xóa thành công!");
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
