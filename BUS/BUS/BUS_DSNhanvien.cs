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

        public bool Add(EMPLOYEE staff)
        {
            staff.EMP_ID = GetNewID(staff.PS_ID);
            dalNhanvien.Add(staff);
            return true;
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

        public string GetNewID(string position)
        {
            int id = GetAll().Count() == 0 ? 1 : Int32.Parse(GetAll().Where(x => x.EMP_ID.Contains(position)).Last().EMP_ID.Substring(2)) + 1;
            return position + id;
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
