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

        public List<GetHourlyRevenue_Result> GetDoanhThuTheogio()
        {
            return dal.GetDoanhThuTheogio().ToList();
        }

        public List<GetHourlySalesCount_Result> GetSodonhangtheogio()
        {
            return dal.GetSodonhangtheogio().ToList();
        }

        public List<int?> GetSLdonhangnay()
        {
            return dal.GetSLdonhangnay().ToList();
        }

        public List<GetSaleBillData_Result> GetSaleBillData(string id)
        {
            return dal.GetSaleBillData(id).ToList();
        }

        public List<GetSaleBillDataz_Result> GetSaleBillDataz(string id)
        {
            return dal.GetSaleBillDataz(id).ToList();
        }

    }

}
