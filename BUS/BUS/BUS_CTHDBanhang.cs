using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class BUS_CTHDBanhang
    {
        private DAL_CTHDBanhang dalcthdbh = new DAL_CTHDBanhang();

        public bool Delete(string id)
        {
            SALEBILL_DETAIL cthdbanhang = GetbyID(id);
            if (cthdbanhang != null)
            {
                dalcthdbh.Delete(cthdbanhang);
                return true;
            }
            return false;
        }

        public List<SALEBILL_DETAIL> GetAll()
        {
            return dalcthdbh.GetAll();
        }

        public SALEBILL_DETAIL GetbyID(string id)
        {
            return dalcthdbh.GetByID(id);
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
                                bool success = Int32.TryParse(p.SL_DETAIL_ID.Substring(3), out id);
                                return success ? id : 0;
                            })
                            .Max();
            }

            return "SBD" + (maxID + 1);
        }
        public List<SALEBILL_DETAIL> SearchSalebilldetail(string keyword)
        {
            return GetAll().Where(x => x.SL_ID.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(SALEBILL_DETAIL sld)
        {
            if (GetbyID(sld.SL_DETAIL_ID) != null)
            {
                dalcthdbh.Update(sld);
                return true;
            }
            return false;
        }

        public void NewSalebilldetail(
        string id,
        string slid,
        string prdid,
        int quantity,
        float prices)
        {
            dalcthdbh.NewSalebill(id, slid, prdid, quantity, prices);
        }

        public List<SALEBILL_DETAIL> TimKiemCTHoadonban(string mahd)
        {
            return dalcthdbh.TimKiemCTHoadonban(mahd);
        }
    }
}
