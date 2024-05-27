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

        public void NewCV(
        string id,
        string name,
        string note)
        {
            dalChucvu.NewCV(id, name, note);
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
            var allItems = GetAll();
            int maxID = 0;

            if (allItems.Any())
            {
                maxID = allItems
                            .Select(p =>
                            {
                                int id;
                                bool success = Int32.TryParse(p.PS_ID.Substring(2), out id);
                                return success ? id : 0;
                            })
                            .Max();
            }

            return "PS" + (maxID + 1);
        }

        public List<POSITION> SearchByName(string keyword)
        {
            return GetAll().Where(x => x.PS_NAME.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(POSITION ps)
        {
            if (GetByID(ps.PS_ID) != null)
            {
                dalChucvu.Update(ps);
                return true;
            }
            return false;
        }

        public POSITION TimKiemChucvu(string keyword)
        {
            return dalChucvu.TimKiemChucvu(keyword);
        }
    }
}
