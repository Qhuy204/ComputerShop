using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_QuyenofChucvu
    {
        private DAL_QuyenofChucvu dalqoc = new DAL_QuyenofChucvu();

        public void NewCV(
        string id,
        string ps_id,
        string aut_id)
        {
            dalqoc.NewCV(id, ps_id, aut_id);
        }

        public bool Delete(string position)
        {
            POSITION_AUTHORITY ps = GetByID(position);
            if (ps != null)
            {
                dalqoc.Delete(ps);
                return true;
            }
            return false;
        }

        public List<POSITION_AUTHORITY> GetAll()
        {
            return dalqoc.GetAll();
        }

        public POSITION_AUTHORITY GetByID(string id)
        {
            return dalqoc.GetByID(id);
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
                                bool success = Int32.TryParse(p.ID.Substring(2), out id);
                                return success ? id : 0;
                            })
                            .Max();
            }

            return "PA" + (maxID + 1);
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
    }
}
