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
        BUS_StatisticsService BUS_StatisticsService = new BUS_StatisticsService();

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
            var data = BUS_StatisticsService.GetSaleBillData(txtmahd.Text);
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

            var datasp = bushdban.GetAll();

            // Tìm kiếm thông tin khách hàng
            var datakh = buskh.GetByID(datasb.CUS_ID.ToString());
            if (datakh == null)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng cho mã khách hàng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thiết lập các tham số cho báo cáo
            List<ReportParameter> parametersList = new List<ReportParameter>
    {
        new ReportParameter("SL_ID", datasb?.SL_ID.ToString() ?? ""),
        new ReportParameter("SL_DATE", datasb?.SL_DATE?.ToString("dd/MM/yyyy") ?? ""),
        new ReportParameter("EMP_ID", datasb?.EMP_ID.ToString() ?? ""),
        new ReportParameter("CUS_NAME", datakh?.CUS_NAME ?? "Không có tên"),
        new ReportParameter("CUS_ADDRESS", datakh?.CUS_ADDRESS ?? "Không có địa chỉ"),
        new ReportParameter("CUS_PHONE_NUMBER", datakh?.CUS_PHONE_NUMBER ?? "Không có số điện thoại"),
        new ReportParameter("EMAIL", datakh?.EMAIL ?? ""),
        new ReportParameter("TOTAL_MONEY", datasb?.TOTAL_MONEY.ToString() ?? ""),
        new ReportParameter("DISCOUNT_CODE", datasb?.DISCOUNT_CODE ?? ""),
        new ReportParameter("MONEY_AFTER_DISCOUNT", datasb?.MONEY_AFTER_DISCOUNT.ToString() ?? ""),
        new ReportParameter("CUS_NAME", datakh?.CUS_NAME ?? "Không có tên")
    };

            ReportParameter[] parameters = parametersList.ToArray();

            // Cập nhật nguồn dữ liệu cho báo cáo
            this.rpvHoadonban.LocalReport.ReportPath = "HDBH.rdlc";

            // Assuming 'data' is a list of sale bill items, which should match DataSet1
            var reportDataSource1 = new ReportDataSource("DataSet1", data);

            // Wrap datasb in a list to make it compatible as a data source
            var reportDataSource2 = new ReportDataSource("DataSet2", new List<object> { datasb });

            // Assuming 'datasp' is a list of all products, which should match DataSet4
            var reportDataSource4 = new ReportDataSource("DataSet4", datasp);

            // Clear existing data sources
            this.rpvHoadonban.LocalReport.DataSources.Clear();

            // Add new data sources
            this.rpvHoadonban.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvHoadonban.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvHoadonban.LocalReport.DataSources.Add(reportDataSource4);

            // Set the parameters for the report
            this.rpvHoadonban.LocalReport.SetParameters(parameters);

            // Refresh the report
            this.rpvHoadonban.RefreshReport();
        }



    }
}
