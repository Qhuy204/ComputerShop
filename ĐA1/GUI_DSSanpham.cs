using BUS;
using DAL;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace ĐA1
{
    public partial class GUI_DSSanpham : Form
    {
        private BUS_DSSanpham busSP = new BUS_DSSanpham();
        private BUS_DSLoaiSP busLoaiSP = new BUS_DSLoaiSP();
        private BUS_QLNhacungcap busNCC = new BUS_QLNhacungcap();

        private PRODUCT spFromform;

        public event EventHandler ThemSanPhamClicked;

        public GUI_DSSanpham()
        {
            InitializeComponent();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            GUI_ThemSP themSP = new GUI_ThemSP();
            themSP.ShowDialog();
        }

        private void GUI_DSSanpham_Load(object sender, EventArgs e)
        {
            var allProducts = busSP.GetAll();
            var allProductTypes = busLoaiSP.GetAll();
            var allBrands = busNCC.GetAll();

            UpdateDgv(allProducts, allBrands, allProductTypes);
            UpdatecbbLoaisp(allProductTypes);
            UpdatecbbNhanhieu(allBrands);
        }

        private void UpdatecbbLoaisp(List<PRODUCTTYPE> pt)
        {
            var dataSource = pt.Select(x => new { x.PRD_TYPE_NAME }).ToList();
            cbbLoaisp.DataSource = dataSource;
            cbbLoaisp.DisplayMember = "PRD_TYPE_NAME";
            cbbLoaisp.ValueMember = "PRD_TYPE_NAME";
            cbbLoaisp.SelectedIndex = -1;
        }

        private void UpdatecbbNhanhieu(List<BRAND> bd)
        {
            var dataSource = bd.Select(x => new { x.BRD_NAME }).ToList();
            cbbNhanhieu.DataSource = dataSource;
            cbbNhanhieu.DisplayMember = "BRD_NAME";
            cbbNhanhieu.ValueMember = "BRD_NAME";
            cbbNhanhieu.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTimkiemSP.Clear();
            cbbLoaisp.SelectedIndex = -1;
            cbbNhanhieu.SelectedIndex = -1;
            var allProducts = busSP.GetAll();
            var allProductTypes = busLoaiSP.GetAll();
            var allBrands = busNCC.GetAll();
            UpdateDgv(allProducts, allBrands, allProductTypes);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string brdid = busNCC.getBRD_ID(cbbNhanhieu.Text.ToLower());
            string ptid = busLoaiSP.getPD_TYPE_ID(cbbLoaisp.Text.ToLower());
            var filteredProducts = busSP.TimKiemSanPham(brdid, ptid, txtTimkiemSP.Text.ToLower());
            var allBrands = busNCC.GetAll();
            var allProductTypes = busLoaiSP.GetAll();
            UpdateDgv(filteredProducts, allBrands, allProductTypes);
        }

        private void UpdateDgv(List<PRODUCT> prd, List<BRAND> brd, List<PRODUCTTYPE> prdt)
        {
            var dataSource = (from p in prd
                              join b in brd on p.BRD_ID equals b.BRD_ID
                              join t in prdt on p.PRD_TYPE_ID equals t.PRD_TYPE_ID
                              select new
                              {
                                  p.PRD_IMG,
                                  p.PRD_ID,
                                  p.PRD_NAME,
                                  b.BRD_NAME,
                                  t.PRD_TYPE_NAME,
                                  p.RDY_FOR_SALE,
                                  p.QUANTITY,
                                  p.PRD_WEIGHT,
                                  p.CREATE_DAY
                              }).ToList();

            dgvSP.DataSource = dataSource;
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvSP.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[1];
                string code = cell.Value.ToString();

                var thongtinSP = Application.OpenForms.OfType<GUI_ThongtinSP>().FirstOrDefault();
                if (thongtinSP != null)
                {
                    thongtinSP.LoadData();
                }
                else
                {
                    MessageBox.Show(code);
                    GUI_ThongtinSP newthongtinSP = new GUI_ThongtinSP(code);
                    newthongtinSP.ShowDialog();
                }
            }
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
            for (int i = 0; i < dgvSP.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvSP.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvSP.Rows.Count; i++)
            {
                for (int j = 0; j < dgvSP.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvSP.Rows[i].Cells[j].Value;
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
                dgvSP.DataSource = dataTable;
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
