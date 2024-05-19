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

        public void Add(PRODUCTTYPE pt)
        {
            pt.PRD_TYPE_ID= GetNewID();
            dalLSP.Add(pt);
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
            int id = GetAll().Count() == 0 ? 1 : Int32.Parse(GetAll().Last().PRD_TYPE_ID.Substring(2)) + 1;
            return "PT" + id;
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
    }
}
