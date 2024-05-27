using BUS;
using DAL;
using OfficeOpenXml;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace ĐA1
{
    public partial class GUI_DSKhachhang : Form
    {
        BUS_DSKhachhang busKH = new BUS_DSKhachhang();
        public GUI_DSKhachhang()
        {
            InitializeComponent();
        }

        private void btnNhapfile_MouseLeave(object sender, EventArgs e)
        {
            btnNhapfile.ForeColor = Color.Black;
        }

        private void btnNhapfile_MouseEnter(object sender, EventArgs e)
        {
            btnNhapfile.ForeColor = Color.FromArgb(0, 136, 255);
        }

        private void btnXuatfile_MouseLeave(object sender, EventArgs e)
        {
            btnXuatfile.ForeColor = Color.Black;
        }

        private void btnXuatfile_MouseEnter(object sender, EventArgs e)
        {
            btnXuatfile.ForeColor = Color.FromArgb(0, 136, 255);
        }

        private void btnTatcakh_Click(object sender, EventArgs e)
        {
            btnTatcakh.ForeColor = Color.FromArgb(90, 136, 255);
            btnTatcakh.CustomBorderColor = Color.FromArgb(94, 148, 255);
        }

        private void btnTatcakh_Leave(object sender, EventArgs e)
        {
            btnTatcakh.ForeColor = Color.Black;
            btnTatcakh.CustomBorderColor = Color.White;
        }

        private void txtTimkiemKH_Click(object sender, EventArgs e)
        {
            txtTimkiemKH.Text = null;
        }

        public void GUI_DSKhachhang_Load(object sender, EventArgs e)
        {
            UpdateDgv(busKH.GetAll());
        }

        private void UpdateDgv(List<CUSTOMER> ctm)
        {
            dgvKH.DataSource = ctm.Select(x => new { x.CUS_ID, x.CUS_NAME, x.CUS_BIRTHDAY, x.CUS_GENDER, x.CUS_PHONE_NUMBER, x.CUS_ADDRESS, x.CUS_TOTAL_SPENDING_MONEY, x.CUS_TOTAL_PRODUCTS_PURCHASED, x.CUS_TOTAL_QUANTITY_OF_ORDER }).ToList();
        }

        private void ThemKH_Click(object sender, EventArgs e)
        {
            GUI_ThemKH themkh = new GUI_ThemKH();
            themkh.ShowDialog();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiemKH.Text.ToLower().Trim();
            var filteredKH = busKH.TimKiemKhachang(keyword);
            UpdateDgv(filteredKH);
        }

        private void btnXoafilter_Click(object sender, EventArgs e)
        {
            txtTimkiemKH.Clear();
            UpdateDgv(busKH.GetAll());
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvKH.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[0];
                string code = cell.Value.ToString();

                // Kiểm tra xem form GUI_ThongtinMGG đã mở hay chưa
                var thongtinKh = Application.OpenForms.OfType<GUI_ThongtinKH>().FirstOrDefault();
                if (thongtinKh != null)
                {
                    // Nếu đã mở, chỉ cần cập nhật dữ liệu
                    thongtinKh.LoadData(code);
                }
                else
                {
                    // Nếu chưa mở, tạo mới và hiển thị
                    GUI_ThongtinKH newthongtinKh = new GUI_ThongtinKH(code);
                    newthongtinKh.ShowDialog();
                }
            }
        }

        private void btnXuatfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Danh sách khách hàng";
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
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvKH.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvKH.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvKH.Rows.Count; i++)
            {
                for (int j = 0; j < dgvKH.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvKH.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        public void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                }
                dgvKH.DataSource = dataTable;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Danh sách khách hàng";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công!\n" + ex.Message);
                }
            }
        }
    }
}
