using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HDBanhang
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();
        private DataTable dt = new DataTable();

        public void Delete(SALEBILL sl)
        {
            db.SALEBILLs.Remove(sl);
            db.SaveChanges();
        }

        public List<SALEBILL> GetAll()
        {
            return db.SALEBILLs.ToList();
        }

        public SALEBILL GetByID(string id)
        {
            return db.SALEBILLs.Find(id);
        }

        public void Update(SALEBILL sl)
        {
            SALEBILL s = db.SALEBILLs.SingleOrDefault(x => x.SL_ID == sl.SL_ID);
            s.SL_DATE = sl.SL_DATE;
            s.CUS_ID = sl.CUS_ID;
            s.EMP_ID = sl.EMP_ID;
            s.DISCOUNT_CODE = sl.DISCOUNT_CODE;
            s.PROMOTION_ID = sl.PROMOTION_ID;
            s.PAYMENT = sl.PAYMENT;
            s.NOTE = sl.NOTE;
            s.MONEY_CUSTOMER_GIVE = sl.MONEY_CUSTOMER_GIVE;
            s.REFUND = sl.REFUND;
            s.STATUS = sl.STATUS;
            db.SaveChanges();
        }

        public List<SALEBILL> TimKiemHoadonban(string khachhang, string nhanvien, string id, DateTime? startDate, DateTime? endDate)
        {
            var query = db.SALEBILLs.AsQueryable();

            if (!string.IsNullOrEmpty(id))
            {
                query = query.Where(p => p.SL_ID.ToLower().Contains(id.ToLower()));
            }

            if (!string.IsNullOrEmpty(khachhang))
            {
                query = query.Where(p => p.CUS_ID.ToLower().Contains(khachhang.ToLower()));
            }

            if (!string.IsNullOrEmpty(nhanvien))
            {
                query = query.Where(p => p.EMP_ID.ToLower().Contains(nhanvien.ToLower()));
            }

            if (startDate.HasValue)
            {
                query = query.Where(p => p.SL_DATE >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(p => p.SL_DATE <= endDate.Value);
            }

            return query.ToList();
        }


        /*public string getSALEBILL_ID(string prdName)
        {
            var product = db.PRODUCTs.FirstOrDefault(p => p.PRD_NAME == prdName);
            return product != null ? product.PRD_ID : null;
        }*/

        public void NewSalebill(
        string id,
        DateTime date,
        string cusid,
        string empid,
        string discode,
        string promotion,
        string payment,
        string note,
        float moneycusgive,
        float refund,
        string status)
        {
            var salebill = new SALEBILL
            {
                SL_ID = id,
                SL_DATE = date,
                CUS_ID = cusid,
                EMP_ID = empid,
                DISCOUNT_CODE = discode,
                PROMOTION_ID = promotion,
                TOTAL_MONEY = 0,
                PAYMENT = payment,
                NOTE = note,
                MONEY_CUSTOMER_GIVE = moneycusgive,
                REFUND = refund,
                STATUS = status
            };

            db.SALEBILLs.Add(salebill);
            db.SaveChanges();

        }
    }
}
