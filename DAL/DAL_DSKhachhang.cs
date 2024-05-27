using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DSKhachhang
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public void NewCustomer(
        string id,
        string name,
        string phone,
        DateTime birthday,
        string email,
        string gender,
        string address)
        {
            var customer = new CUSTOMER
            {
                CUS_ID = id,
                CUS_NAME = name,
                CUS_PHONE_NUMBER = phone,
                CUS_BIRTHDAY = birthday,
                EMAIL = email,
                CUS_ADDRESS = address,
                CUS_GENDER = gender,
                CUS_TOTAL_SPENDING_MONEY = 0,
                CUS_TOTAL_PRODUCTS_PURCHASED = 0,
                CUS_TOTAL_QUANTITY_OF_ORDER = 0
            };
            db.CUSTOMERs.Add(customer);
            db.SaveChanges();
        }

        public void Delete(CUSTOMER ct)
        {
            db.CUSTOMERs.Remove(ct);
            db.SaveChanges();
        }

        public List<CUSTOMER> GetAll()
        {
            return db.CUSTOMERs.ToList();
        }

        public CUSTOMER GetByID(string id)
        {
            return db.CUSTOMERs.Find(id);
        }

        public void Update(CUSTOMER ct)
        {
            CUSTOMER s = db.CUSTOMERs.SingleOrDefault(x => x.CUS_ID == ct.CUS_ID);
            s.CUS_NAME = ct.CUS_NAME;
            s.CUS_BIRTHDAY = ct.CUS_BIRTHDAY;
            s.CUS_GENDER = ct.CUS_GENDER;
            s.CUS_PHONE_NUMBER = ct.CUS_PHONE_NUMBER;
            s.CUS_ADDRESS = ct.CUS_ADDRESS;
            s.CUS_TOTAL_SPENDING_MONEY = ct.CUS_TOTAL_SPENDING_MONEY;
            s.CUS_TOTAL_PRODUCTS_PURCHASED = ct.CUS_TOTAL_PRODUCTS_PURCHASED;
            s.CUS_TOTAL_QUANTITY_OF_ORDER = ct.CUS_TOTAL_QUANTITY_OF_ORDER;
            db.SaveChanges();
        }

        public List<CUSTOMER> TimKiemKhachang(string keyword)
        {
            var query = db.CUSTOMERs.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                keyword = keyword.ToLower(); // Chuyển từ khóa thành chữ thường để tìm kiếm không phân biệt chữ hoa/chữ thường
                query = query.Where(p => p.CUS_ID.ToLower().Contains(keyword) ||
                                         p.CUS_PHONE_NUMBER.ToLower().Contains(keyword) ||
                                         p.CUS_NAME.ToLower().Contains(keyword) ||
                                         p.CUS_ADDRESS.ToLower().Contains(keyword));
            }

            return query.ToList();
        }


        public string getCUS_ID(string Name)
        {
            var product = db.CUSTOMERs.FirstOrDefault(p => p.CUS_NAME == Name);
            return product != null ? product.CUS_ID : null;
        }
    }
}
