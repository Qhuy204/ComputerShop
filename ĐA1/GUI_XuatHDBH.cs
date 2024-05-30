using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using OfficeOpenXml;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ĐA1
{
    public partial class GUI_XuatHDBH : Form
    {
        BUS_StatisticsService bussta = new BUS_StatisticsService();
        BUS_DSKhachhang buskh = new BUS_DSKhachhang();
        BUS_HDBanhang bushd = new BUS_HDBanhang();

        private List<List<object>> billData = new List<List<object>>();
        public string id;
        public GUI_XuatHDBH(string id)
        {
            InitializeComponent();
            this.id = id;
            LoadData();
        }

        private void btnxuathd_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }

        public void LoadData()
        {
            // Retrieve the sale bill data using the provided ID
            var datahdbh = bushd.GetbyID(id);
            if (datahdbh == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extract necessary details from the sale bill data
            string makh = datahdbh.CUS_ID;
            string manv = datahdbh.EMP_ID;
            string ngayban = datahdbh.SL_DATE.ToString(); // Format date to dd/MM/yyyy

            // Retrieve customer details using the customer ID from the sale bill
            var datakh = buskh.GetByID(makh);
            if (datakh == null)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenkh = datakh.CUS_NAME ?? "Không có tên";
            string dchi = datakh.CUS_ADDRESS ?? "Không có địa chỉ";
            string sdt = datakh.CUS_PHONE_NUMBER ?? "Không có số điện thoại";
            string email = datakh.EMAIL ?? "Không có email";

            // Retrieve the sale bill details using the sale bill ID
            var datacthd = bussta.GetSaleBillDataz(id);
            if (datacthd == null || !datacthd.Any())
            {
                MessageBox.Show("Không tìm thấy chi tiết hóa đơn bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bind the sale bill details to the DataGridView
            dgvcthd.DataSource = datacthd.Select(x => new { x.STT, x.PRD_ID, x.PRD_NAME, x.QUANTITY, x.PRICE, x.TOTAL_MONEY_DETAIL, x.STATUS }).ToList();

            // Update UI labels with the formatted data
            lbldiachi.Text = dchi;
            lblemail.Text = email;
            lblsdt.Text = sdt;
            lblNV.Text = manv;
            lblNhanvien.Text = manv;
            lbltenkh.Text = tenkh;
            lblKH.Text = tenkh;
            lblNgayban.Text = ngayban;
            lblMaphieu.Text = id;
            lblgiamgia.Text = datahdbh.DISCOUNT_CODE ?? "0"; // DISCOUNT_CODE is a string, no formatting needed

            // MONEY_AFTER_DISCOUNT and TOTAL_MONEY should be numeric values to apply "N0" formatting
            lbltientra.Text = datahdbh.MONEY_AFTER_DISCOUNT.ToString(); // Format as number with commas
            lblTongtien.Text = datahdbh.TOTAL_MONEY.ToString(); // Format as number with commas

            // Lưu dữ liệu chi tiết hóa đơn vào biến billData
            billData = dgvcthd.Rows
                        .Cast<DataGridViewRow>()
                        .Select(row => row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToList())
                        .ToList();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bushd.Delete(id);
                MessageBox.Show("Xóa thành công!");
                this.Close();
            }
        }

        private void ExportToPDF()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.Title = "Lưu hóa đơn";
            saveFileDialog.FileName = $"InvoiceNo.{lblMaphieu.Text}.pdf"; // Default file name

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                doc.Open();

                // Set font for Vietnamese characters
                BaseFont bf = BaseFont.CreateFont("c:\\windows\\fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bf, 12);

                // Add header
                Paragraph headerParagraph = new Paragraph("CỬA HÀNG MÁY TÍNH QHUY STORE", fontHeader);
                headerParagraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(headerParagraph);

                // Add a blank line
                doc.Add(iTextSharp.text.Chunk.NEWLINE); // New line

                // Add invoice information
                doc.Add(new Paragraph($"Mã hóa đơn: {lblMaphieu.Text}", fontNormal));
                doc.Add(new Paragraph($"Ngày bán: {lblNgayban.Text}", fontNormal));

                // Customer information
                doc.Add(new Paragraph("Thông tin khách hàng:", fontNormal));
                doc.Add(new Paragraph($"Tên khách hàng: {lblKH.Text}", fontNormal));
                doc.Add(new Paragraph($"Địa chỉ: {lbldiachi.Text}", fontNormal));
                doc.Add(new Paragraph($"Số điện thoại: {lblsdt.Text}", fontNormal));
                doc.Add(new Paragraph($"Email: {lblemail.Text}", fontNormal));
                doc.Add(iTextSharp.text.Chunk.NEWLINE); // New line

                // Employee information
                doc.Add(new Paragraph("Nhân viên bán:", fontNormal));
                doc.Add(new Paragraph($"Mã: {lblNV.Text}", fontNormal));
                doc.Add(iTextSharp.text.Chunk.NEWLINE); // New line

                // Add DataGridView header to PdfPTable
                PdfPTable dgvHeaderTable = new PdfPTable(dgvcthd.Columns.Count);
                foreach (DataGridViewColumn column in dgvcthd.Columns)
                {
                    dgvHeaderTable.AddCell(new Phrase(column.HeaderText, fontNormal));
                }
                doc.Add(dgvHeaderTable);

                // Add bill details table
                PdfPTable dgvDataTable = new PdfPTable(dgvcthd.Columns.Count);
                foreach (DataGridViewRow dgvRow in dgvcthd.Rows)
                {
                    foreach (DataGridViewCell cell in dgvRow.Cells)
                    {
                        dgvDataTable.AddCell(new Phrase(cell.Value.ToString(), fontNormal));
                    }
                }
                doc.Add(dgvDataTable);

                // Add total amount, discount, amount to pay
                doc.Add(new Paragraph($"Tổng tiền: {lblTongtien.Text}", fontNormal));
                doc.Add(new Paragraph($"Giảm giá: {lblgiamgia.Text}", fontNormal));
                doc.Add(new Paragraph($"Tiền phải trả: {lbltientra.Text}", fontNormal));

                doc.Close();

                MessageBox.Show("Xuất hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(saveFileDialog.FileName);
            }


        }
    }
}
