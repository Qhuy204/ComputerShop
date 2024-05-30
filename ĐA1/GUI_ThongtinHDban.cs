using BUS;
using DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_ThongtinHDban : Form
    {
        BUS_CTHDBanhang buscthd = new BUS_CTHDBanhang();
        BUS_HDBanhang bushdban = new BUS_HDBanhang();
        BUS_DSKhachhang buskh = new BUS_DSKhachhang();
        BUS_Khohang buskho = new BUS_Khohang();
        public GUI_ThongtinHDban()
        {
            InitializeComponent();
        }

        private void btnxuathd_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã hóa đơn có rỗng hay không
            if (string.IsNullOrWhiteSpace(txtmahd.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm kiếm chi tiết hóa đơn bán
            var data = buscthd.TimKiemCTHoadonban(txtmahd.Text);
            if (data == null || !data.Any())
            {
                MessageBox.Show("Không tìm thấy chi tiết hóa đơn bán cho mã hóa đơn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm kiếm hóa đơn bán
            var datasb = bushdban.GetbyID(txtmahd.Text);
            if (datasb == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn bán cho mã hóa đơn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm kiếm thông tin khách hàng
            var datakh = buskh.GetByID(datasb.CUS_ID.ToString());
            if (datakh == null)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng cho mã khách hàng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var datacthd = buscthd.SearchSalebilldetail(txtmahd.Text).ToList();
            // Assuming PRD_ID is a string type, you can join the IDs into a comma-separated string
            string mahd = string.Join(",", datacthd.Select(x => x.PRD_ID));
            // Corrected line to call GetByID method
            var datasp = buskho.GetByID(mahd);


            // Thiết lập các tham số cho báo cáo
            List<ReportParameter> parametersList = new List<ReportParameter>();

            parametersList.Add(new ReportParameter("SL_ID", datasb?.SL_ID.ToString() ?? ""));
            parametersList.Add(new ReportParameter("SL_DATE", datasb?.SL_DATE?.ToString("dd/MM/yyyy") ?? ""));
            parametersList.Add(new ReportParameter("EMP_ID", datasb?.EMP_ID.ToString() ?? ""));
            parametersList.Add(new ReportParameter("CUS_NAME", datakh?.CUS_NAME ?? "Không có tên"));
            parametersList.Add(new ReportParameter("CUS_ADDRESS", datakh?.CUS_ADDRESS ?? "Không có địa chỉ"));
            parametersList.Add(new ReportParameter("CUS_PHONE_NUMBER", datakh?.CUS_PHONE_NUMBER ?? "Không có số điện thoại"));
            parametersList.Add(new ReportParameter("EMAIL", datakh?.EMAIL ?? ""));
            parametersList.Add(new ReportParameter("TOTAL_MONEY", datasb?.TOTAL_MONEY.ToString() ?? ""));
            parametersList.Add(new ReportParameter("DISCOUNT_CODE", datasb?.DISCOUNT_CODE ?? ""));
            parametersList.Add(new ReportParameter("MONEY_AFTER_DISCOUNT", datasb?.MONEY_AFTER_DISCOUNT.ToString() ?? ""));
            parametersList.Add(new ReportParameter("CUS_NAME", datakh?.CUS_NAME ?? "Không có tên"));
            parametersList.Add(new ReportParameter("PRD_NAME", datasp?.PRD_NAME ?? "Không có tên"));

            ReportParameter[] parameters = parametersList.ToArray();


            // Cập nhật nguồn dữ liệu cho báo cáo
            this.rpvHoadonban.LocalReport.ReportPath = "HDBH.rdlc";
            var reportDataSource1 = new ReportDataSource("DataSet1", data);
            var reportDataSource2 = new ReportDataSource("DataSet2", new List<object>()); // Thay thế danh sách rỗng này bằng dữ liệu thực tế nếu cần
            var reportDataSource3 = new ReportDataSource("DataSet3", new List<object>()); // Thay thế danh sách rỗng này bằng dữ liệu thực tế nếu cần
            var reportDataSource4 = new ReportDataSource("DataSet4", new List<object>()); // Thay thế danh sách rỗng này bằng dữ liệu thực tế nếu cần

            this.rpvHoadonban.LocalReport.DataSources.Clear();
            this.rpvHoadonban.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvHoadonban.LocalReport.DataSources.Add(reportDataSource2); // Thêm DataSet2 vào
            this.rpvHoadonban.LocalReport.DataSources.Add(reportDataSource3); // Thêm DataSet3 vào
            this.rpvHoadonban.LocalReport.DataSources.Add(reportDataSource4); // Thêm DataSet3 vào

            this.rpvHoadonban.LocalReport.SetParameters(parameters);
            this.rpvHoadonban.RefreshReport();
        }
    }
}
