using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_StatisticsService
    {
        private CuaHangMayTinhEntities1 db;

        public DAL_StatisticsService()
        {
            db = new CuaHangMayTinhEntities1();
        }

        public List<sp_ThongKeSanPhamBanChay_Result> GetSanPhamBanChay(DateTime startDate, DateTime endDate)
        {
            return db.sp_ThongKeSanPhamBanChay(startDate, endDate).ToList();
        }

        public List<sp_ThongKeNhanVienBanNhieuNhat_Result> GetNhanVienBanNhieuNhat(DateTime startDate, DateTime endDate)
        {
            return db.sp_ThongKeNhanVienBanNhieuNhat(startDate, endDate).ToList();
        }

        public int GetTotalSaleBills(DateTime startDate, DateTime endDate)
        {
            return db.Database.SqlQuery<int>("SELECT dbo.fn_TotalSaleBills(@StartDate, @EndDate)",
                                           new SqlParameter("@StartDate", startDate),
                                           new SqlParameter("@EndDate", endDate))
                                  .FirstOrDefault();
        }

        public double GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            var result = db.Database.SqlQuery<double?>(
                "SELECT dbo.fn_TotalRevenue(@StartDate, @EndDate)",
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate))
                .FirstOrDefault();

            return result ?? 0;
        }


        public List<sp_ThongKeSanPhamBanRaTheoNgay_Result> GetSanPhamBanRaTheoNgay(DateTime startDate, DateTime endDate)
        {
            return db.sp_ThongKeSanPhamBanRaTheoNgay(startDate, endDate).ToList();
        }

        public List<sp_ThongKeDoanhThuTheoKhoangThoiGian_Result> GetDoanhThuTheoNgay(DateTime startDate, DateTime endDate)
        {
            return db.sp_ThongKeDoanhThuTheoKhoangThoiGian(startDate, endDate).ToList();
        }
    }
}
