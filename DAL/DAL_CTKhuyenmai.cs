using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CTKhuyenmai
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public void NewCtrinh(
        string id,
        string name,
        string description,
        DateTime startdate,
        DateTime enddate,
        decimal discountpercent,
        decimal discountamount,
        string prdtypename,
        string prdname,
        decimal minpurchase,
        int minproduct,
        int maximum_use)
        {
            var kmai = new PROMOTION
            {
                PROMOTION_ID = id,
                PROMOTION_NAME= name,
                PROMOTION_DESCRIPTION = description,
                PROMOTION_START_DATE = startdate,
                PROMOTION_END_DATE = enddate,
                DISCOUNT_PERCENT = discountpercent,
                DISCOUNT_AMOUNT = discountamount,
                PRD_TYPE_NAME = prdtypename,
                PRD_NAME = prdname,
                MIN_PURCHASE_VALUE = minpurchase,
                MIN_QUANTITY_OF_PRODUCT = minproduct,
                MAXIMUM_USE = maximum_use,
                USED_COUNT = 0
            };

            db.PROMOTIONs.Add(kmai);
            db.SaveChanges();

        }
        public void Delete(PROMOTION pm)
        {
            db.PROMOTIONs.Remove(pm);
            db.SaveChanges();
        }

        public List<PROMOTION> GetAll()
        {
            return db.PROMOTIONs.ToList();
        }

        public PROMOTION GetByID(string id)
        {
            return db.PROMOTIONs.Find(id);
        }

        public void Update(PROMOTION pm)
        {
            PROMOTION s = db.PROMOTIONs.SingleOrDefault(x => x.PROMOTION_ID == pm.PROMOTION_ID);
            s.PROMOTION_NAME = pm.PROMOTION_NAME;
            s.PROMOTION_DESCRIPTION = pm.PROMOTION_DESCRIPTION;
            s.PROMOTION_START_DATE = pm.PROMOTION_START_DATE;
            s.PROMOTION_END_DATE = pm.PROMOTION_END_DATE;
            s.DISCOUNT_PERCENT = pm.DISCOUNT_PERCENT;
            s.DISCOUNT_AMOUNT = pm.DISCOUNT_AMOUNT;
            s.PRD_TYPE_NAME = pm.PRD_TYPE_NAME;
            s.PRD_NAME = pm.PRD_NAME;
            s.MIN_PURCHASE_VALUE = pm.MIN_PURCHASE_VALUE;
            s.MIN_QUANTITY_OF_PRODUCT = pm.MIN_QUANTITY_OF_PRODUCT;
            s.MAXIMUM_USE = pm.MAXIMUM_USE;
            s.USED_COUNT = pm.USED_COUNT;
            db.SaveChanges();
        }

        public string getCTKM_ID(string name)
        {
            var ctkm = db.PROMOTIONs.FirstOrDefault(p => p.PROMOTION_NAME == name);
            return ctkm != null ? ctkm.PROMOTION_ID : null;
        }

        public List<PROMOTION> GetDiscountPromo(string name, string Status, DateTime? startDate, DateTime? endDate = null)
        {
            var query = db.PROMOTIONs.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(c => c.PROMOTION_NAME.ToLower().Contains(name));
            }

            if (!string.IsNullOrEmpty(Status))
            {
                query = query.Where(c => c.PROMOTION_STATUS.ToLower().Contains(Status));
            }

            if (startDate.HasValue)
            {
                query = query.Where(c => c.PROMOTION_START_DATE >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(c => c.PROMOTION_END_DATE <= endDate.Value);
            }

            return query.ToList();
        }

        public PROMOTION GetbyName(string name)
        {
            return db.PROMOTIONs.FirstOrDefault(p => p.PROMOTION_NAME == name);
        }
    }
}
