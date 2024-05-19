using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DSLoaiSP
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public void Add(PRODUCTTYPE pt)
        {
            db.PRODUCTTYPEs.Add(pt);
            db.SaveChanges();
        }

        public void Delete(PRODUCTTYPE pt)
        {
            db.PRODUCTTYPEs.Remove(pt);
            db.SaveChanges();
        }

        public List<PRODUCTTYPE> GetAll()
        {
            return db.PRODUCTTYPEs.ToList();
        }

        public PRODUCTTYPE GetByID(string id)
        {
            return db.PRODUCTTYPEs.Find(id);
        }

        public void Update(PRODUCTTYPE pt)
        {
            PRODUCTTYPE s = db.PRODUCTTYPEs.SingleOrDefault(x => x.PRD_TYPE_ID== pt.PRD_TYPE_ID);
            s.PRD_TYPE_ID = pt.PRD_TYPE_ID;
            s.PRD_TYPE_NAME = pt.PRD_TYPE_NAME;

            db.SaveChanges();
        }

        public string getPD_TYPE_ID(string ptName)
        {
            var ptid = db.PRODUCTTYPEs.FirstOrDefault(p => p.PRD_TYPE_NAME == ptName);
            return ptid != null ? ptid.PRD_TYPE_ID : null;
        }
    }
}
