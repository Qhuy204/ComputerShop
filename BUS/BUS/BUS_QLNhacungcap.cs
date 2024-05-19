using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_QLNhacungcap
    {
        private DAL_QLNhacungcap dalNCC = new DAL_QLNhacungcap();

        public void Add(BRAND brd)
        {
            brd.BRD_ID = GetNewID();
            dalNCC.Add(brd);
        }

        public bool Delete(string brdID)
        {
            BRAND brand = GetByID(brdID);
            if (brand != null)
            {
                dalNCC.Delete(brand);
                return true;
            }
            return false;
        }

        public List<BRAND> GetAll()
        {
            return dalNCC.GetAll();
        }

        public BRAND GetByID(string id)
        {
            return dalNCC.GetByID(id);
        }

        public string GetNewID()
        {
            int id = GetAll().Count() == 0 ? 1 : Int32.Parse(GetAll().Last().BRD_ID.Substring(3)) + 1;
            return "NCC" + id;
        }

        public List<BRAND> SearchBrandByName(string keyword)
        {
            return GetAll().Where(x => x.BRD_NAME.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(BRAND brd)
        {
            if (GetByID(brd.BRD_ID) != null)
            {
                dalNCC.Update(brd);
                return true;
            }
            return false;
        }

        public string getBRD_ID(string brdName)
        {
            return dalNCC.getBRD_ID(brdName);
        }
    }
}
  