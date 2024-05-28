using BUS;
using DAL;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_Tongquan : Form
    {
        BUS_StatisticsService  bus = new BUS_StatisticsService();

        public GUI_Tongquan()
        {
            InitializeComponent();
            updatedata();
        }

        private void GUI_Tongquan_Load(object sender, EventArgs e)
        {
            DisplayDoanhthuchart();
            DisplaySalesCountChart();
        }

        private void DisplayDoanhthuchart()
        {
            var data = bus.GetDoanhThuTheogio();
            DataTable chartData = ConvertToDataTabledoanhthu(data);

            var dataset = new GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            foreach (DataRow row in chartData.Rows)
            {
                int hour = (int)row["Giờ"];
                double totalRevenue = (double)row["Tổng doanh thu"];
                dataset.DataPoints.Add(hour.ToString("00") + ":00", totalRevenue);
            }

            // Thêm Dataset vào chart
            chartdoanhthu.Datasets.Add(dataset);

            // Cấu hình thuộc tính của dataset
            dataset.Label = "Doanh thu theo giờ";
            dataset.FillColor = Color.White;
            dataset.BorderColor = Color.FromArgb(22, 130, 187);

            // Cập nhật chart để hiển thị dữ liệu mới
            chartdoanhthu.Update();
        }



        private DataTable ConvertToDataTabledoanhthu(List<GetHourlyRevenue_Result> data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Giờ", typeof(int));
            table.Columns.Add("Tổng doanh thu", typeof(double)); // Sử dụng double thay vì decimal

            foreach (var item in data)
            {
                table.Rows.Add(item.Hour, (double)item.TotalRevenue); // Ép kiểu TotalRevenue thành double
            }
            return table;
        }

        private void DisplaySalesCountChart()
        {
            var data = bus.GetSodonhangtheogio();
            DataTable chartData = ConvertToDataTableSalesCount(data);

            var dataset = new GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            foreach (DataRow row in chartData.Rows)
            {
                int hour = (int)row["Giờ"];
                int salesCount = (int)row["Số lượng đơn hàng"];
                dataset.DataPoints.Add(hour.ToString("00") + ":00", salesCount);
            }

            // Thêm Dataset vào chart
            chartsldonhang.Datasets.Add(dataset);

            // Cấu hình thuộc tính của dataset
            dataset.Label = "Số đơn hàng theo giờ";
            dataset.FillColor = Color.White;
            dataset.BorderColor = Color.FromArgb(22, 130, 187);

            // Cập nhật chart để hiển thị dữ liệu mới
            chartsldonhang.Update();
        }

        private DataTable ConvertToDataTableSalesCount(List<GetHourlySalesCount_Result> data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Giờ", typeof(int));
            table.Columns.Add("Số lượng đơn hàng", typeof(int));

            foreach (var item in data)
            {
                table.Rows.Add(item.Hour, item.SalesCount);
            }
            return table;
        }

        private void updatedata()
        {
            try
            {
                DateTime startDate = DateTime.Today;
                DateTime endDate = DateTime.Today.AddDays(1).AddSeconds(-1);

                // Lấy số lượng đơn hàng trong ngày hiện tại
                var sldonhang = bus.GetSLdonhangnay();
                if (sldonhang != null && sldonhang.Count > 0)
                {
                    int count = sldonhang[0] ?? 0;
                    lblsosp.Text = count.ToString();
                }
                else
                {
                    lblsosp.Text = "0";
                }

                // Lấy tổng doanh thu trong ngày hiện tại
                double tongdoanhthu = bus.GetTotalRevenue(startDate, endDate);
                lbldoanhhu.Text = tongdoanhthu.ToString("N0");
            }
            catch (Exception ex)
            {
                // Log the exception and handle errors gracefully
                MessageBox.Show("An error occurred during update: " + ex.Message);
            }
        }

    }

}
