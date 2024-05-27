using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DSLoaiSP
    {
        private DAL_DSLoaiSP dalLSP = new DAL_DSLoaiSP();

        public void NewPDT(
        string id,
        string name)
        {
            dalLSP.NewPDT(id, name);
        }

        public bool Delete(string ptID)
        {
            PRODUCTTYPE pt = GetByID(ptID);
            if (pt != null)
            {
                dalLSP.Delete(pt);
                return true;
            }
            return false;
        }

        public List<PRODUCTTYPE> GetAll()
        {
            return dalLSP.GetAll();
        }

        public PRODUCTTYPE GetByID(string id)
        {
            return dalLSP.GetByID(id);
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
                                bool success = Int32.TryParse(p.PRD_TYPE_ID.Substring(2), out id);
                                return success ? id : 0;
                            })
                            .Max();
            }

            return "PT" + (maxID + 1);
        }

        public List<PRODUCTTYPE> SearchProductTypeByName(string keyword)
        {
            return GetAll().Where(x => x.PRD_TYPE_NAME.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(PRODUCTTYPE pt)
        {
            if (GetByID(pt.PRD_TYPE_ID) != null)
            {
                dalLSP.Update(pt);
                return true;
            }
            return false;
        }

        public string getPD_TYPE_ID(string ptName)
        {
            return dalLSP.getPD_TYPE_ID(ptName);
        }

        public PRODUCTTYPE GetbyName(string name)
        {
            return dalLSP.GetbyName(name);
        }
    }
}
