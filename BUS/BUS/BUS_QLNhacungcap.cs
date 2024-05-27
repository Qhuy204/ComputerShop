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

        public void NewNCC(
        string id,
        string name,
        string phone,
        string email,
        string address,
        string status)
        {
            dalNCC.NewNCC(id, name, phone, email, address, status);
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
            var allItems = GetAll();
            int maxID = 0;

            if (allItems.Any())
            {
                maxID = allItems
                            .Select(p =>
                            {
                                int id;
                                bool success = Int32.TryParse(p.BRD_ID.Substring(3), out id);
                                return success ? id : 0;
                            })
                            .Max();
            }

            return "NCC" + (maxID + 1);
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

        public List<BRAND> TimKiemNCC(string keyword)
        {
            return dalNCC.TimKiemNCC(keyword);
        }
    }
}
  