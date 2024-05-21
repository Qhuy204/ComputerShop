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

        public void NewEmployee(
        string id,
        string name,
        string phone,
        DateTime birthday,
        string email,
        string account,
        string password)
        {
            var employee = new EMPLOYEE
            {
                EMP_ID = id,
                EMP_NAME = name,
                EMP_PHONE_NUMBER = phone,
                EMP_BIRTHDAY = birthday,
                EMP_EMAIL = email,
                EMP_ADDRESS = "temp",
                HIRE_DATE = DateTime.Now,
                EMP_ACCOUNT = account,
                EMP_PASSWORD = password,
                PS_ID = "PS002",
                EMP_STATUS = "Đang làm việc"
            };
            db.EMPLOYEES.Add(employee);
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
            s.EMP_ADDRESS = staff.EMP_ADDRESS;
            s.EMP_EMAIL = staff.EMP_EMAIL;
            s.EMP_ACCOUNT= staff.EMP_ACCOUNT;
            s.EMP_PASSWORD = staff.EMP_PASSWORD;
            s.PS_ID = staff.PS_ID;
            s.EMP_STATUS = staff.EMP_STATUS;
            db.SaveChanges();
        }
    }
}
