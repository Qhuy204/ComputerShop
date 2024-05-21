using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CTKhuyenmai
    {
        private DAL_CTKhuyenmai dalkm = new DAL_CTKhuyenmai();

        public string GetNewID()
        {
            var allItems = GetAll();
            int maxID = 0;

            if (allItems.Any())
            {
                maxID = allItems
                            .Select(p =>
                            {
                                int id;
                                bool success = Int32.TryParse(p.PROMOTION_ID.Substring(3), out id);
                                return success ? id : 0;
                            })
                            .Max();
            }

            return "PMT" + (maxID + 1);
        }

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
            dalkm.NewCtrinh(id, name, description, startdate, enddate, discountpercent, discountamount, prdtypename, prdname, minpurchase, minproduct, maximum_use);
        }

        public bool Delete(string dc)
        {
            PROMOTION promo = GetByID(dc);
            if (promo != null)
            {
                dalkm.Delete(promo);
                return true;
            }
            return false;
        }


        public List<PROMOTION> GetAll()
        {
            return dalkm.GetAll();
        }

        public PROMOTION GetByID(string id)
        {
            return dalkm.GetByID(id);
        }

        public List<PROMOTION> SearchCTKM(string keyword)
        {
            return GetAll().Where(x => x.PROMOTION_ID.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(PROMOTION pm)
        {
            if (GetByID(pm.PROMOTION_ID) != null)
            {
                dalkm.Update(pm);
                return true;
            }
            return false;
        }

        public string getCTKM_ID(string name)
        {
            return dalkm.getCTKM_ID(name);
        }
    }
}
