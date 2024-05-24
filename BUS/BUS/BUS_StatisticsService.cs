using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_StatisticsService
    {
        private DAL_StatisticsService dal;

        public BUS_StatisticsService()
        {
            dal = new DAL_StatisticsService();
        }

        public List<sp_ThongKeSanPhamBanChay_Result> GetSanPhamBanChay(DateTime startDate, DateTime endDate)
        {
            return dal.GetSanPhamBanChay(startDate, endDate);
        }

        public List<sp_ThongKeNhanVienBanNhieuNhat_Result> GetNhanVienBanNhieuNhat(DateTime startDate, DateTime endDate)
        {
            return dal.GetNhanVienBanNhieuNhat(startDate, endDate);
        }

        public int GetTotalSaleBills(DateTime startDate, DateTime endDate)
        {
            return dal.GetTotalSaleBills(startDate, endDate);
        }

        public double GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            return dal.GetTotalRevenue(startDate, endDate);
        }

        public List<sp_ThongKeSanPhamBanRaTheoNgay_Result> GetSanPhamBanRaTheoNgay(DateTime startDate, DateTime endDate)
        {
            return dal.GetSanPhamBanRaTheoNgay(startDate, endDate);
        }

        public List<sp_ThongKeDoanhThuTheoKhoangThoiGian_Result> GetDoanhThuTheoNgay(DateTime startDate, DateTime endDate)
        {
            return dal.GetDoanhThuTheoNgay(startDate, endDate);
        }
    }

}
