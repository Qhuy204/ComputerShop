using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class BUS_CTHoadonnhaphang
    {
        private DAL_CTHoadonnhaphang dalcthdnh = new DAL_CTHoadonnhaphang();

        public bool Delete(string id)
        {
            IMPORTBILL_DETAIL cthdnhaphang = GetbyID(id);
            if (cthdnhaphang != null)
            {
                dalcthdnh.Delete(cthdnhaphang);
                return true;
            }
            return false;
        }

        public List<IMPORTBILL_DETAIL> GetAll()
        {
            return dalcthdnh.GetAll();
        }

        public IMPORTBILL_DETAIL GetbyID(string id)
        {
            return dalcthdnh.GetByID(id);
        }
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
                                bool success = Int32.TryParse(p.IB_DETAIL_ID.Substring(3), out id);
                                return success ? id : 0;
                            })
                            .Max();
            }

            return "IBD" + (maxID + 1);
        }
        public List<IMPORTBILL_DETAIL> Searchimportbilldetail(string keyword)
        {
            return GetAll().Where(x => x.IB_ID.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(IMPORTBILL_DETAIL sld)
        {
            if (GetbyID(sld.IB_DETAIL_ID) != null)
            {
                dalcthdnh.Update(sld);
                return true;
            }
            return false;
        }

        public void Newimportbilldetail(
        string id,
        string slid,
        string prdid,
        int quantity,
        float prices)
        {
            dalcthdnh.Newimportbilldetail(id, slid, prdid, quantity, prices);
        }
    }
}
