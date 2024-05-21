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
    public partial class GUI_TaoCtrinhKm : Form
    {
        BUS_CTKhuyenmai busCtkm = new BUS_CTKhuyenmai();
        BUS_DSLoaiSP busDSLoaiSP = new BUS_DSLoaiSP();
        BUS_DSSanpham busDSSP = new BUS_DSSanpham();

        public GUI_TaoCtrinhKm()
        {
            InitializeComponent();
        }

        private GUI_Khuyenmai _parentForm;

        private void GUI_TaoCtrinhKm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Lấy form GUI_Khuyenmai
            var mainForm = Application.OpenForms.OfType<GUI_Khuyenmai>().FirstOrDefault();

            if (mainForm != null)
            {
                // Gọi PerformClick trên btnCtrinhgiamgia của form GUI_Khuyenmai
                mainForm.btnCtrinhgiamgia.PerformClick();
            }
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Nếu bạn hủy các thay đổi này thì thông tin đã điền. Bạn có muốn tiếp tục thêm không?",
                "Hủy thêm CTKM",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                this.Close(); // 
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string id = busCtkm.GetNewID();
            string name = txtMakm.Text;
            string description = txtMota.Text;
            DateTime start_date, end_date;

            start_date = DateTime.Parse(dtpBatdau.Text);
            end_date = DateTime.Parse(dtpKetthuc.Text);

            if(txtMakm.Text == "" || txtMakm.Text == null)
            {
                MessageBox.Show("Tên chương trình giảm giá không được để trống");
                return;
            }

            if (start_date > end_date)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc.");
                return;
            }

            decimal discount_percent = 0;
            decimal discount_amount = 0;

            if (!string.IsNullOrWhiteSpace(cbbdonvi1.Text))
            {
                if (cbbdonvi1.Text == "%")
                {
                    if (!decimal.TryParse(txtMucgiam.Text, out discount_percent))
                    {
                        MessageBox.Show("Giá trị mức giảm theo % không hợp lệ.");
                        return;
                    }
                }
                else if (cbbdonvi1.Text == "đ")
                {
                    if (!decimal.TryParse(txtMucgiam.Text, out discount_amount))
                    {
                        MessageBox.Show("Giá trị mức giảm theo tiền không hợp lệ.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Đơn vị mức giảm không hợp lệ.");
                    return;
                }
            }

            if (!decimal.TryParse(txtgtritoithieu.Text, out decimal min_purchase))
            {
                MessageBox.Show("Giá trị đơn hàng tối thiểu không hợp lệ.");
                return;
            }

            if (!int.TryParse(txtsoluongtoithieu.Text, out int min_quantityof_product))
            {
                MessageBox.Show("Số lượng sản phẩm tối thiểu không hợp lệ.");
                return;
            }

            if (!int.TryParse(txtSLsudung.Text, out int maximum_use))
            {
                MessageBox.Show("Giới hạn sử dụng không hợp lệ.");
                return;
            }

            string prd_type_name = cbbLoaiSP.Text;
            string prd_name = cbbTenSP.Text;

            busCtkm.NewCtrinh(id, name, description, start_date, end_date, discount_percent, discount_amount, prd_type_name, prd_name, min_purchase, min_quantityof_product, maximum_use);
            MessageBox.Show("Chương trình giảm giá được lưu thành công.");
            DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục thêm chương trình giảm giá khác không?", "Thêm chương trình giảm giá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                Clearform();
            }

        }

        private void GUI_TaoCtrinhKm_Load(object sender, EventArgs e)
        {
            var loaisp = busDSLoaiSP.GetAll();
            var tensp = busDSSP.GetAll();
            LoadcbbLoaisp(loaisp);
            LoadcbbTenSP(tensp);
            Clearform();
            txtMakm.Focus();
        }

        private void Clearform()
        {
            txtMakm.Clear();
            txtgtritoithieu.Clear();
            txtMota.Clear();
            txtMucgiam.Clear();
            txtSLsudung.Clear();
            txtsoluongtoithieu.Clear();
            dtpBatdau.ResetText();
            dtpKetthuc.ResetText();
            cbbdonvi1.SelectedIndex = -1;
            cbbLoaiSP.SelectedIndex = -1;
            cbbTenSP.SelectedIndex = -1;
            txtMakm.Focus();
        }

        private void cbbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiSP.SelectedIndex != -1)
            {
                cbbTenSP.SelectedIndex = -1;
            }
        }

        private void cbbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenSP.SelectedIndex != -1)
            {
                cbbLoaiSP.SelectedIndex = -1;
            }
        }

        
    }
}
