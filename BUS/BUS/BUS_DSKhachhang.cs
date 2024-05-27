using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DSKhachhang
    {
        private DAL_DSKhachhang dalKH = new DAL_DSKhachhang();

        public void NewCustomer(
        string id,
        string name,
        string phone,
        DateTime birthday,
        string email,
        string gender,
        string address)
        {
            dalKH.NewCustomer(id, name, phone, birthday, email, gender, address);
        }

        public bool Delete(string ctmID)
        {
            CUSTOMER cus = GetByID(ctmID);
            if (cus != null)
            {
                dalKH.Delete(cus);
                return true;
            }
            return false;
        }

        public List<CUSTOMER> GetAll()
        {
            return dalKH.GetAll();
        }

        public CUSTOMER GetByID(string id)
        {
            return dalKH.GetByID(id);
        }

        public string getCUS_ID(string Name)
        {
            return dalKH.getCUS_ID(Name);
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
                                bool success = Int32.TryParse(p.CUS_ID.Substring(2), out id);
                                return success ? id : 0;
                            })
                            .Max();
            }

            return "KH" + (maxID + 1);
        }

        public List<CUSTOMER> SearchKhachhangByName(string keyword)
        {
            return GetAll().Where(x => x.CUS_NAME.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(CUSTOMER brd)
        {
            if (GetByID(brd.CUS_ID) != null)
            {
                dalKH.Update(brd);
                return true;
            }
            return false;
        }

        public List<CUSTOMER> TimKiemKhachang(string keyword)
        {
            return dalKH.TimKiemKhachang(keyword);
        }

    }
}
