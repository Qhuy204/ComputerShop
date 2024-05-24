using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Payment
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public List<PAYMENT> GetAll()
        {
            return db.PAYMENTs.ToList();
        }
    }
}
