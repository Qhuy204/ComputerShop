using BUS;
using DAL;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ĐA1
{
    public partial class GUI_Thongke : Form
    {
        private BUS_StatisticsService bus;

        public GUI_Thongke()
        {
            InitializeComponent();
            bus = new BUS_StatisticsService();
        }

        private void updatedata()
        {
            try
            {
                DateTime startDate = dtpstart.Value;
                DateTime endDate = dtpend.Value;

                var data = bus.GetSanPhamBanChay(startDate, endDate);
                var data2 = bus.GetNhanVienBanNhieuNhat(startDate, endDate);
                DisplayNhanVienBanNhieuNhatChart(data2);

                var sldonhang = bus.GetTotalSaleBills(startDate, endDate);
                lblSodonhang.Text = sldonhang.ToString();

                var tongdoanhthu = bus.GetTotalRevenue(startDate, endDate);
                lbldoanhthu.Text = tongdoanhthu.ToString("N0");

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = data;
                dgvspbanchay.DataSource = bindingSource;

            }
            catch (Exception ex)
            {
                // Log the exception and handle errors gracefully
                MessageBox.Show("An error occurred during update: " + ex.Message);
            }
        }

        private DataTable ConvertToDataTable(List<sp_ThongKeSanPhamBanRaTheoNgay_Result> data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("SL_DATE", typeof(DateTime));
            table.Columns.Add("TotalQuantity", typeof(int));
            // Thêm các cột khác nếu cần

            foreach (var item in data)
            {
                table.Rows.Add(item.SL_DATE, item.TotalQuantity); // Thêm dữ liệu vào dòng
            }
            return table;
        }

        private void btnThongKeNhanVienBanNhieuNhat_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpstart.Value;
            DateTime endDate = dtpend.Value;

            var data = bus.GetNhanVienBanNhieuNhat(startDate, endDate);
            DisplayNhanVienBanNhieuNhatChart(data);
        }

        private void DisplayNhanVienBanNhieuNhatChart(List<sp_ThongKeNhanVienBanNhieuNhat_Result> data)
        {
            charttopnv.Series.Clear();
            var series = new Series("Nhân viên bán nhiều nhất");
            series.ChartType = SeriesChartType.Column;

            foreach (var item in data)
            {
                series.Points.AddXY(item.EMP_NAME, item.TotalSales);
            }

            charttopnv.Series.Add(series);
        }

        private void DisplayLuongdonhangChart()
        {
            var data = bus.GetSanPhamBanRaTheoNgay(dtpstart.Value, dtpend.Value);
            DataTable chartData = ConvertToDataTable(data);

            var dataset = new GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            foreach (DataRow row in chartData.Rows)
            {
                DateTime date = (DateTime)row["SL_DATE"];
                int count = (int)row["TotalQuantity"];
                dataset.DataPoints.Add(date.ToString("dd-MM-yyyy"), count);
            }

            // Thêm Dataset vào chart
            chartluongdonhang.Datasets.Add(dataset);

            dataset.Label = "Số lượng sản phẩm bán ra theo ngày";
            dataset.FillColor = Color.White;
            dataset.BorderColor = Color.FromArgb(22, 130, 187);


            // Cập nhật chart để hiển thị dữ liệu mới
            chartluongdonhang.Update();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            updatedata();
            chartluongdonhang.Datasets.Clear();
            chartdoanhthu.Datasets.Clear();
            DisplayLuongdonhangChart();
            DisplayDoanhthuchart();
            txtDoanhthu.Text = lbldoanhthu.Text;
            txtSldonhang.Text = lblSodonhang.Text;
        }

        private DataTable ConvertToDataTabledoanhthu(List<sp_ThongKeDoanhThuTheoKhoangThoiGian_Result> data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("TotalRevenue", typeof(int));
            // Thêm các cột khác nếu cần

            foreach (var item in data)
            {
                table.Rows.Add(item.Date, item.TotalRevenue); // Thêm dữ liệu vào dòng
            }
            return table;
        }

        private void DisplayDoanhthuchart()
        {
            var data = bus.GetDoanhThuTheoNgay(dtpstart.Value, dtpend.Value);
            DataTable chartData = ConvertToDataTabledoanhthu(data);

            var dataset = new GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            foreach (DataRow row in chartData.Rows)
            {
                DateTime date = (DateTime)row["Date"];
                int count = (int)row["TotalRevenue"];
                dataset.DataPoints.Add(date.ToString("dd-MM-yyyy"), count);
            }

            // Thêm Dataset vào chart
            chartdoanhthu.Datasets.Add(dataset);

            dataset.Label = "Doanh thu theo ngày";
            dataset.FillColor = Color.White;
            dataset.BorderColor = Color.FromArgb(22, 130, 187);


            // Cập nhật chart để hiển thị dữ liệu mới
            chartdoanhthu.Update();
        }
    }

}
