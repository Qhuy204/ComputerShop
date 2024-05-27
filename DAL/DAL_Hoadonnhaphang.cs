using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Hoadonnhaphang
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public void Delete(IMPORTBILL sl)
        {
            db.IMPORTBILLs.Remove(sl);
            db.SaveChanges();
        }

        public List<IMPORTBILL> GetAll()
        {
            return db.IMPORTBILLs.ToList();
        }

        public IMPORTBILL GetByID(string id)
        {
            return db.IMPORTBILLs.Find(id);
        }

        public void Update(IMPORTBILL sl)
        {
            IMPORTBILL s = db.IMPORTBILLs.SingleOrDefault(x => x.IB_ID == sl.IB_ID);
            s.IB_ID = sl.IB_ID;
            s.BRD_ID= sl.BRD_ID;
            s.EMP_ID = sl.EMP_ID;
            s.IB_DATE= sl.IB_DATE;
            s.TOTAL_MONEY = sl.TOTAL_MONEY;
            s.NOTE = sl.NOTE;
            db.SaveChanges();
        }

        public List<IMPORTBILL> TimKiemHoadonnhap(string ncc, string nhanvien, string id, DateTime? startDate, DateTime? endDate)
        {
            var query = db.IMPORTBILLs.AsQueryable();

            if (!string.IsNullOrEmpty(id))
            {
                query = query.Where(p => p.IB_ID.ToLower().Contains(id.ToLower()));
            }

            if (!string.IsNullOrEmpty(ncc))
            {
                query = query.Where(p => p.BRD_ID.ToLower().Contains(ncc.ToLower()));
            }

            if (!string.IsNullOrEmpty(nhanvien))
            {
                query = query.Where(p => p.EMP_ID.ToLower().Contains(nhanvien.ToLower()));
            }

            if (startDate.HasValue)
            {
                query = query.Where(p => p.IB_DATE >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(p => p.IB_DATE <= endDate.Value);
            }

            return query.ToList();
        }


        public void NewImportbill(
        string ibid,
        string brdid,
        string empid,
        DateTime ibdate,
        float totalmoney,
        string note)
        {
            var importbill = new IMPORTBILL
            {
                IB_ID = ibid,
                BRD_ID = brdid,
                EMP_ID = empid,
                IB_DATE = ibdate,
                TOTAL_MONEY = totalmoney,
                NOTE = note
            };

            db.IMPORTBILLs.Add(importbill);
            db.SaveChanges();

        }
    }
}
