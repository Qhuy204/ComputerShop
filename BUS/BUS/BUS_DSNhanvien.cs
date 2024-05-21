using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DSNhanvien
    {
        private DAL_DSNhanvien dalNhanvien = new DAL_DSNhanvien();

        public void NewEmployee(
        string id,
        string name,
        string phone,
        DateTime birthday,
        string email,
        string account,
        string password)
        {
            dalNhanvien.NewEmployee(id, name, phone, birthday, email, account, password);
        }

        public bool Delete(string id)
        {
            EMPLOYEE emp = GetByID(id);
            if (emp != null)
            {
                dalNhanvien.Delete(emp);
                return true;
            }
            else return false;
        }

        public List<EMPLOYEE> GetAll()
        {
            return dalNhanvien.GetAll();
        }

        public EMPLOYEE GetByID(string id)
        {
            return dalNhanvien.GetByID(id);
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
                                bool success = Int32.TryParse(p.EMP_ID.Substring(3), out id);
                                return success ? id : 0;
                            })
                            .Max();
            }

            return "EMP" + (maxID + 1);
        }

        public List<EMPLOYEE> SearchStaffsByName(string keyword)
        {
            return GetAll().Where(x => x.EMP_NAME.ToLower().Contains(keyword)).ToList();
        }

        public List<EMPLOYEE> SearchStaffsByPosition(string id)
        {
            return GetAll()
                    .Where(x => x.PS_ID == id).ToList();
        }

        public bool Update(EMPLOYEE staff)
        {
            if (GetByID(staff.EMP_ID) != null)
            {
                dalNhanvien.Update(staff);
                return true;
            }
            else return false;
        }
    }
}
