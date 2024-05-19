using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Khohang
    {
        private DAL_Khohang dalKhohang= new DAL_Khohang();

        public void Add(WAREHOUSE wr)
        {
            wr.PRD_ID = GetNewID();
            dalKhohang.Add(wr);
        }

        public bool Delete(string wrID)
        {
            WAREHOUSE warehouse = GetByID(wrID);
            if (warehouse != null)
            {
                dalKhohang.Delete(warehouse);
                return true;
            }
            return false;
        }

        public List<WAREHOUSE> GetAll()
        {
            return dalKhohang.GetAll();
        }

        public WAREHOUSE GetByID(string id)
        {
            return dalKhohang.GetByID(id);
        }

        public string GetNewID()
        {
            int id = GetAll().Count() == 0 ? 1 : Int32.Parse(GetAll().Last().PRD_ID.Substring(3)) + 1;
            return "PRD" + id;
        }

        public List<WAREHOUSE> SearchByName(string keyword)
        {
            return GetAll().Where(x => x.PRD_NAME.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(WAREHOUSE wr)
        {
            if (GetByID(wr.PRD_ID) != null)
            {
                dalKhohang.Update(wr);
                return true;
            }
            return false;
        }

        public void AddProductInformation(string id, float importprice, float retailprice, float wholesaleprice)
        {
            dalKhohang.AddProductInformation(id, importprice, retailprice, wholesaleprice);
        }


    }
}
