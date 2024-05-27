using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Security.Cryptography;

namespace DAL
{
    public class DAL_CodeKhuyenmai
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public void NewCode(
        string code,
        decimal discount_percent,
        decimal discount_amount,
        decimal max_discount_amount,
        string code_description,
        decimal min_purchase,
        int min_quantityof_product,
        int maximum_use,
        DateTime start_date,
        DateTime end_date)
        {
            var discount = new DISCOUNT
            {
                CODE = code,
                DISCOUNT_AMOUNT = discount_amount,
                DISCOUNT_PERCENT = discount_percent,
                CODE_DESCRIPTION = code_description,
                MAXIMUM_DISCOUNT_AMOUNT = max_discount_amount,
                MIN_PURCHASE_VALUE = min_purchase,
                MIN_QUANTITY_OF_PRODUCT = min_quantityof_product,
                MAXIMUM_USE = maximum_use,
                USED_COUNT = 0,
                DISCOUNT_START_DATE = start_date,
                DISCOUNT_END_DATE = end_date
            };

            db.DISCOUNTs.Add(discount);
            db.SaveChanges();

        }
        public void Delete(DISCOUNT dc)
        {
            db.DISCOUNTs.Remove(dc);
            db.SaveChanges();
        }

        public List<DISCOUNT> GetAll()
        {
            return db.DISCOUNTs.ToList();
        }

        public DISCOUNT GetByCODE(string id)
        {
            return db.DISCOUNTs.Find(id);
        }

        public void Update(DISCOUNT dt)
        {
            DISCOUNT s = db.DISCOUNTs.SingleOrDefault(x => x.CODE == dt.CODE);
            s.CODE = dt.CODE;
            s.DISCOUNT_PERCENT = dt.DISCOUNT_PERCENT;
            s.DISCOUNT_AMOUNT = dt.DISCOUNT_AMOUNT;
            s.MAXIMUM_DISCOUNT_AMOUNT = dt.MAXIMUM_DISCOUNT_AMOUNT;
            s.CODE_DESCRIPTION = dt.CODE_DESCRIPTION;
            s.MIN_PURCHASE_VALUE = dt.MIN_PURCHASE_VALUE;
            s.MIN_QUANTITY_OF_PRODUCT = dt.MIN_QUANTITY_OF_PRODUCT;
            s.MAXIMUM_USE = dt.MAXIMUM_USE;
            s.DISCOUNT_START_DATE = dt.DISCOUNT_START_DATE;
            s.DISCOUNT_END_DATE = dt.DISCOUNT_END_DATE;
            s.USED_COUNT = dt.USED_COUNT;
            db.SaveChanges();
        }
        public List<DISCOUNT> GetDiscountCodes(string code, string discountStatus, DateTime? startDate, DateTime? endDate = null)
        {
            var query = db.DISCOUNTs.AsQueryable();

            if (!string.IsNullOrEmpty(code))
            {
                query = query.Where(c => c.CODE.ToLower().Contains(code));
            }

            if (!string.IsNullOrEmpty(discountStatus))
            {
                query = query.Where(c => c.DISCOUNT_STATUS.ToLower().Contains(discountStatus));
            }

            if (startDate.HasValue)
            {
                query = query.Where(c => c.DISCOUNT_START_DATE >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(c => c.DISCOUNT_END_DATE <= endDate.Value);
            }

            return query.ToList();
        }
    }
}