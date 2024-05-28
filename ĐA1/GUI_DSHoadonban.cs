using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ĐA1
{
    public partial class GUI_DSHoadonban : Form
    {
        BUS_HDBanhang bushdban = new BUS_HDBanhang();
        BUS_DSKhachhang buskhachhang = new BUS_DSKhachhang();
        public string id;
        public GUI_DSHoadonban(string id)
        {
            InitializeComponent();
            this.id = id;
            var data = bushdban.GetAll();
            Loaddgv(data);
            loadcbbKhachhang();
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntaodonhangle_Click(object sender, EventArgs e)
        {
            GUI_Taohdban taohdban = new GUI_Taohdban("Giá lẻ", id);
            taohdban.ShowDialog();
        }

        private void btnTaodonhangsi_Click(object sender, EventArgs e)
        {
            GUI_Taohdban taohdban = new GUI_Taohdban("Giá sỉ", id); 
            taohdban.ShowDialog();
        }

        private void Loaddgv(List<SALEBILL> sl)
        {
            
            dgvhdban.DataSource = sl.Select(x => new { x.CUS_ID, x.PAYMENT, x.NOTE, x.EMP_ID, x.SL_ID, x.PROMOTION_ID, x.DISCOUNT_CODE, x.BANGGIA, x.STATUS, x.MONEY_AFTER_DISCOUNT, x.SL_DATE}).ToList() ;
        }


        private void btXuatdulieu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Danh sách sản phẩm";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        public void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            // Tạo tiêu đề cho các cột
            for (int i = 0; i < dgvhdban.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dgvhdban.Columns[i].HeaderText;
            }

            // Ghi dữ liệu vào các ô trong Excel
            for (int i = 0; i < dgvhdban.Rows.Count; i++)
            {
                for (int j = 0; j < dgvhdban.Columns.Count; j++)
                {
                    if (dgvhdban.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvhdban.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = string.Empty;
                    }
                }
            }

            worksheet.Columns.AutoFit();
            workbook.SaveAs(path);
            workbook.Close();
            application.Quit();

            // Giải phóng đối tượng COM
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
        }

        private void loadcbbKhachhang()
        {
            var data = buskhachhang.GetAll();
            cbbKhachhang.DataSource = data.Select(x => new { x.CUS_NAME }).ToList();
            cbbKhachhang.DisplayMember = "CUS_NAME";
            cbbKhachhang.ValueMember = "CUS_NAME";
            cbbKhachhang.SelectedIndex = -1;
        }


        private void btnsearch_Click(object sender, EventArgs e)
        {
            string khachhang = cbbKhachhang.Text;
            string idkh = buskhachhang.getCUS_ID(khachhang);
            
            string id = txtTimmgg.Text;
            string nhanvien = "";
            DateTime start = dtstartdate.Value;
            DateTime end = dtpendate.Value;
            UpdateDgv(idkh, nhanvien, id, start, end);
        }

        private void UpdateDgv(string khachhang, string nhanvien, string id, DateTime? startDate, DateTime? endDate)
        {
            var dataSource = bushdban.TimKiemHoadonban(khachhang, nhanvien, id, startDate, endDate);
            dgvhdban.DataSource = dataSource.Select(x => new { x.CUS_ID, x.PAYMENT, x.NOTE, x.EMP_ID, x.SL_ID, x.PROMOTION_ID, x.DISCOUNT_CODE, x.BANGGIA, x.STATUS, x.MONEY_AFTER_DISCOUNT, x.SL_DATE }).ToList();

        }

        private void btnxoafilter_Click(object sender, EventArgs e)
        {
            txtTimmgg.Clear();
            cbbKhachhang.SelectedIndex = -1;
            dtpendate.ResetText();
            dtstartdate.ResetText();
            Loaddgv(bushdban.GetAll());
        }
    }
}
