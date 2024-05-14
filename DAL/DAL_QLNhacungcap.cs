using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_QLNhacungcap
    {
        private CuaHangMayTinhEntities db = new CuaHangMayTinhEntities();

        public void Add(BRAND brd)
        {
            db.BRANDs.Add(brd);
            db.SaveChanges();
        }

        public void Delete(BRAND brd)
        {
            db.BRANDs.Remove(brd);
            db.SaveChanges();
        }

        public List<BRAND> GetAll()
        {
            return db.BRANDs.ToList();
        }

        public BRAND GetByID(string id)
        {
            return db.BRANDs.Find(id);
        }

        public void Update(BRAND brd)
        {
            BRAND s = db.BRANDs.SingleOrDefault(x => x.BRD_ID == brd.BRD_ID);
            s.Ten = customer.Ten;
            s.GioiTinh = customer.GioiTinh;
            s.SDT = customer.SDT;
            s.Email = customer.Email;
            s.DiaChi = customer.DiaChi;
            db.SaveChanges();
        }
    }
}
