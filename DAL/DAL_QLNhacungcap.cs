using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_QLNhacungcap
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

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
            s.BRD_NAME = brd.BRD_NAME;
            s.BRD_ADDRESS= brd.BRD_ADDRESS;
            s.BRD_PHONE= brd.BRD_PHONE;
            s.BRD_EMAIL= brd.BRD_EMAIL;
            s.BRD_STATUS = brd.BRD_STATUS;
            db.SaveChanges();
        }

        public string getBRD_ID(string brdName)
        {
            var brandid = db.BRANDs.FirstOrDefault(p => p.BRD_NAME == brdName);
            return brandid != null ? brandid.BRD_ID : null;
        }
    }
}
