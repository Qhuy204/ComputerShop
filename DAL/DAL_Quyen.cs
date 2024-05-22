using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Quyen
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public void Add(AUTHORITY au)
        {
            db.AUTHORITies.Add(au);
            db.SaveChanges();
        }

        public List<AUTHORITY> GetAll()
        {
            return db.AUTHORITies.ToList();
        }

        public AUTHORITY GetByID(string id)
        {
            return db.AUTHORITies.Find(id);
        }

        public AUTHORITY TimKiemQuyen(string keyword)
        {
            return db.AUTHORITies.FirstOrDefault(p => p.AUT_NAME.ToLower() == keyword.ToLower());
        }
    }
}
