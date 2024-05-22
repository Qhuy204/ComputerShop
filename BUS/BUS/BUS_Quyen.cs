using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Quyen
    {
        private DAL_Quyen dalQuyen = new DAL_Quyen();

        public List<AUTHORITY> GetAll()
        {
            return dalQuyen.GetAll();
        }

        public AUTHORITY GetByID(string id)
        {
            return dalQuyen.GetByID(id);
        }

        public List<AUTHORITY> SearchByName(string keyword)
        {
            return GetAll().Where(x => x.AUT_NAME.ToLower().Contains(keyword)).ToList();
        }

        /*public bool Update(POSITION ps)
        {
            if (GetByID(ps.PS_ID) != null)
            {
                dalChucvu.Update(wr);
                return true;
            }
            return false;
        }

        public void AddProductInformation(string id, float importprice, float retailprice, float wholesaleprice)
        {
            dalKhohang.AddProductInformation(id, importprice, retailprice, wholesaleprice);
        }*/

        public AUTHORITY TimKiemQuyen(string keyword)
        {
            return dalQuyen.TimKiemQuyen(keyword);
        }
    }
}
