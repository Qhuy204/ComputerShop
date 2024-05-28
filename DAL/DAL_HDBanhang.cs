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
            s.STATUS = sl.STATUS;
            s.MONEY_AFTER_DISCOUNT = sl.MONEY_AFTER_DISCOUNT;
            db.SaveChanges();
        }

        public List<SALEBILL> TimKiemHoadonban(string khachhang, string nhanvien, string id, DateTime? startDate, DateTime? endDate)
        {
            // Start with the full queryable set of SALEBILLs
            var query = db.SALEBILLs.AsQueryable();

            // Filter by id if provided
            if (!string.IsNullOrEmpty(id))
            {
                query = query.Where(p => p.SL_ID.ToLower().Contains(id.ToLower()));
            }

            // Filter by khachhang if provided
            if (!string.IsNullOrEmpty(khachhang))
            {
                query = query.Where(p => p.CUS_ID.ToLower().Contains(khachhang.ToLower()));
            }

            // Filter by startDate if provided
            if (startDate.HasValue)
            {
                query = query.Where(p => p.SL_DATE >= startDate.Value);
            }

            // Filter by endDate if provided
            if (endDate.HasValue)
            {
                query = query.Where(p => p.SL_DATE <= endDate.Value);
            }

            // Execute the query and return the results as a list
            return query.ToList();
        }



        public void NewSalebill(
        string id,
        DateTime date,
        string cusid,
        string empid,
        string discode,
        string promotion,
        string payment,
        string note,
        string status,
        float totalmoney, 
        string banggia,
        float moneyafterdiscount)
        {
            var salebill = new SALEBILL
            {
                SL_ID = id,
                SL_DATE = date,
                CUS_ID = cusid,
                EMP_ID = empid,
                DISCOUNT_CODE = discode,
                PROMOTION_ID = promotion,
                TOTAL_MONEY = totalmoney,
                PAYMENT = payment,
                NOTE = note,
                STATUS = status,
                BANGGIA = banggia,
                MONEY_AFTER_DISCOUNT = moneyafterdiscount
            };

            db.SALEBILLs.Add(salebill);
            db.SaveChanges();

        }
    }
}
