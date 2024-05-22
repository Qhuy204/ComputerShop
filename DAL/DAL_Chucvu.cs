using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Chucvu
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public void NewCV(
        string id,
        string name,
        string note)
        {
            var chucvu = new POSITION
            {
                PS_ID = id,
                PS_NAME = name,
                PS_NOTE = note
            };

            db.POSITIONs.Add(chucvu);
            db.SaveChanges();

        }

        public void Delete(POSITION ps)
        {
            db.POSITIONs.Remove(ps);
            db.SaveChanges();
        }

        public List<POSITION> GetAll()
        {
            return db.POSITIONs.ToList();
        }

        public POSITION GetByID(string id)
        {
            return db.POSITIONs.Find(id);
        }

        public void Update(POSITION ps)
        {
            POSITION s = db.POSITIONs.SingleOrDefault(x => x.PS_ID == ps.PS_ID);
            s.PS_ID = ps.PS_ID;
            s.PS_NAME = ps.PS_NAME;
            s.PS_NOTE = ps.PS_NOTE;
            db.SaveChanges();
        }

        public POSITION TimKiemChucvu(string keyword)
        {
            return db.POSITIONs.FirstOrDefault(p => p.PS_NAME.ToLower() == keyword.ToLower());
        }

    }
}
