using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DSNhanvien
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public void Add(EMPLOYEE staff)
        {
            db.EMPLOYEES.Add(staff);
            db.SaveChanges();
        }

        public void Delete(EMPLOYEE staff)
        {
            db.EMPLOYEES.Remove(staff);
            db.SaveChanges();
        }

        public List<EMPLOYEE> GetAll()
        {
            return db.EMPLOYEES.ToList();
        }

        public EMPLOYEE GetByID(string id)
        {
            return db.EMPLOYEES.Find(id);
        }

        public void Update(EMPLOYEE staff)
        {
            EMPLOYEE s = db.EMPLOYEES.SingleOrDefault(x => x.EMP_ID == staff.EMP_ID);
            s.EMP_NAME = staff.EMP_NAME;
            s.EMP_PHONE_NUMBER = staff.EMP_PHONE_NUMBER;
            s.EMP_BIRTHDAY = staff.EMP_BIRTHDAY;
            s.EMP_GENDER = staff.EMP_GENDER;
            s.EMP_PROVINCE = staff.EMP_PROVINCE;
            s.EMP_DISTRICT= staff.EMP_DISTRICT;
            s.EMP_WARD = staff.EMP_WARD;
            s.EMP_ADDRESS = staff.EMP_ADDRESS;
            s.EMP_EMAIL = staff.EMP_EMAIL;
            s.EMP_ACCOUNT= staff.EMP_ACCOUNT;
            s.EMP_PASSWORD = staff.EMP_PASSWORD;
            s.HIRE_DATE = staff.HIRE_DATE;
            s.PS_ID = staff.PS_ID;
            s.EMP_STATUS = staff.EMP_STATUS;
            db.SaveChanges();
        }
    }
}
