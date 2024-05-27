using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CodeKhuyenmai
    {
        private DAL_CodeKhuyenmai dalMgg = new DAL_CodeKhuyenmai();

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
            dalMgg.NewCode(code, discount_percent, discount_amount, max_discount_amount, code_description, min_purchase, min_quantityof_product, maximum_use, start_date, end_date);
        }

        public bool Delete(string dc)
        {
            DISCOUNT discount = GetByCODE(dc);
            if (discount != null)
            {
                dalMgg.Delete(discount);
                return true;
            }
            return false;
        }

        public List<DISCOUNT> GetAll()
        {
            return dalMgg.GetAll();
        }

        public DISCOUNT GetByCODE(string code)
        {
            return dalMgg.GetByCODE(code);
        }

        public List<DISCOUNT> SearchCode(string keyword)
        {
            return GetAll().Where(x => x.CODE.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(DISCOUNT dc)
        {
            if (GetByCODE(dc.CODE) != null)
            {
                dalMgg.Update(dc);
                return true;
            }
            return false;
        }
        public List<DISCOUNT> GetDiscountCodes(string code, string discountStatus, DateTime? startDate, DateTime? endDate = null)
        {
            return dalMgg.GetDiscountCodes(code, discountStatus, startDate, endDate);
        }
    }
}
