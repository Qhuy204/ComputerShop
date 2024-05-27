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
using System.Windows.Interop;
using ZXing.QrCode.Internal;

namespace ĐA1
{
    public partial class GUI_ThongtinKH : Form
    {
        BUS_DSKhachhang buskh = new BUS_DSKhachhang();
        public string id;
        public GUI_ThongtinKH(string id)
        {
            InitializeComponent();
            this.id = id;
            LoadData(id);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadData(string id)
        {
            var data = buskh.GetByID(id);

            if (data != null)
            {
                txtHoten.Text = data.CUS_NAME ?? string.Empty;
                txtSdt.Text = data.CUS_PHONE_NUMBER ?? string.Empty;

                if (DateTime.TryParse(data.CUS_BIRTHDAY?.ToString(), out DateTime birthday))
                {
                    dtpNgaysinh.Value = birthday;
                }
                else
                {
                    dtpNgaysinh.Value = DateTime.Now; // Hoặc giá trị mặc định nào đó
                }

                txtEmail.Text = data.EMAIL ?? string.Empty;
                txtdiachi.Text = data.CUS_ADDRESS ?? string.Empty;
                txtTongtien.Text = data.CUS_TOTAL_SPENDING_MONEY?.ToString() ?? "0";
                txttongdonhang.Text = data.CUS_TOTAL_QUANTITY_OF_ORDER?.ToString() ?? "0";

                if (DateTime.TryParse(data.CUS_DATE_OF_LAST_PURCHASE?.ToString(), out DateTime ngayMua))
                {
                    dtpngaymua.Value = ngayMua;
                }
                else
                {
                    dtpngaymua.Value = DateTime.Now; // Hoặc giá trị mặc định nào đó
                }

                txtTongSP.Text = data.CUS_TOTAL_PRODUCTS_PURCHASED?.ToString() ?? "0";

                if (data.CUS_GENDER != null)
                {
                    if (data.CUS_GENDER.ToString() == "Nam")
                    {
                        rbNam.Checked = true;
                    }
                    else if (data.CUS_GENDER.ToString() == "Nữ")
                    {
                        rbNu.Checked = true;
                    }
                    else
                    {
                        rbKhac.Checked = true;
                    }
                }
                else
                {
                    rbKhac.Checked = true; // Hoặc thiết lập mặc định nào đó
                }
            }
            else
            {
                MessageBox.Show("Không load được thông tin khách hàng.");
                this.Close();
            }
        }



        private void btnXoaKM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                buskh.Delete(id);
                MessageBox.Show("Xóa thành công!");
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cus_id = id;
            string name = txtHoten.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phone = txtSdt.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = txtEmail.Text.Trim();

            if (!DateTime.TryParse(dtpNgaysinh.Text, out DateTime birthday))
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(dtpngaymua.Text, out DateTime ngaymua))
            {
                MessageBox.Show("Ngày mua gần nhất không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string diachi = txtdiachi.Text.Trim();
            if (string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtTongtien.Text, out int tongtien))
            {
                MessageBox.Show("Tổng tiền hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txttongdonhang.Text, out int tongdonhang))
            {
                MessageBox.Show("Tổng đơn hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtTongSP.Text, out int tongsp))
            {
                MessageBox.Show("Tổng sản phẩm đã mua không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gioitinh = "";
            if (rbNam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rbNu.Checked)
            {
                gioitinh = "Nữ";
            }
            else if (rbKhac.Checked)
            {
                gioitinh = "Khác";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CUSTOMER cus = new CUSTOMER
            {
                CUS_ID = cus_id,
                CUS_NAME = name,
                CUS_PHONE_NUMBER = phone,
                CUS_BIRTHDAY = birthday,
                CUS_GENDER = gioitinh,
                CUS_ADDRESS = diachi,
                EMAIL = email,
                CUS_DATE_OF_LAST_PURCHASE = ngaymua,
                CUS_TOTAL_SPENDING_MONEY = tongtien,
                CUS_TOTAL_PRODUCTS_PURCHASED = tongsp,
                CUS_TOTAL_QUANTITY_OF_ORDER = tongdonhang
            };

            if (buskh.Update(cus))
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
}
