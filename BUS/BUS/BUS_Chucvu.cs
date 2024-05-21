using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Chucvu
    {
        private DAL_Chucvu dalChucvu = new DAL_Chucvu();

        public void Add(POSITION ps)
        {
            ps.PS_ID= GetNewID();
            dalChucvu.Add(ps);
        }

        public bool Delete(string position)
        {
            POSITION ps = GetByID(position);
            if (ps != null)
            {
                dalChucvu.Delete(ps);
                return true;
            }
            return false;
        }

        public List<POSITION> GetAll()
        {
            return dalChucvu.GetAll();
        }

        public POSITION GetByID(string id)
        {
            return dalChucvu.GetByID(id);
        }

        public string GetNewID()
        {
            int id = GetAll().Count() == 0 ? 1 : Int32.Parse(GetAll().Last().PS_ID.Substring(2)) + 1;
            return "PS" + id;
        }

        public List<POSITION> SearchByName(string keyword)
        {
            return GetAll().Where(x => x.PS_NAME.ToLower().Contains(keyword)).ToList();
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

        public POSITION TimKiemChucvu(string keyword)
        {
            return dalChucvu.TimKiemChucvu(keyword);
        }
    }
}
