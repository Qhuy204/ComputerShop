using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_Khohang : Form
    {
        private BUS_Khohang busKhohang = new BUS_Khohang();
        private BUS_DSLoaiSP busLoaiSP = new BUS_DSLoaiSP();
        private BUS_QLNhacungcap busNCC = new BUS_QLNhacungcap();

        public GUI_Khohang()
        {
            InitializeComponent();
        }

        private void GUI_Khohang_Load(object sender, EventArgs e)
        {
            var allProducts = busKhohang.GetAll();
            var allProductTypes = busLoaiSP.GetAll();
            var allBrands = busNCC.GetAll();

            UpdateDgv(allProducts, allBrands, allProductTypes);
        }

        private void UpdateDgv(List<WAREHOUSE> prd)
        {
            dgvKH.DataSource = prd.Select(x => new { x.PRD_IMG, x.PRD_ID, x.PRD_NAME, x.PRD_TYPE_ID, x.BRD_ID, x.RDY_FOR_SALE, x.INVENTORY_QUANTITY, x.CREATE_DAY, x.RETAIL_PRICE, x.IMPORT_PRICE, x.WHOLESALE_PRICE }).ToList();
        }

        private void UpdateDgv(List<WAREHOUSE> prd, List<BRAND> brd, List<PRODUCTTYPE> prdt)
        {
            var dataSource = (from p in prd
                              join b in brd on p.BRD_ID equals b.BRD_ID
                              join t in prdt on p.PRD_TYPE_ID equals t.PRD_TYPE_ID
                              select new
                              {
                                  p.PRD_ID,
                                  p.PRD_NAME,
                                  b.BRD_NAME,
                                  t.PRD_TYPE_NAME,
                                  p.RDY_FOR_SALE,
                                  p.INVENTORY_QUANTITY,
                                  p.RETAIL_PRICE,
                                  p.CREATE_DAY,
                                  p.WHOLESALE_PRICE,
                                  p.IMPORT_PRICE,
                              }).ToList();

            dgvKH.DataSource = dataSource;
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXuatfile_Click(object sender, EventArgs e)
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
                for (int i = excelWorksheet.Dimension.Start.Column; i<= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row+1; i <= excelWorksheet.Dimension.End.Row; i++)
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
            openFileDialog.Title = "Danh sách sản phẩm";
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
