using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CTHoadonnhaphang
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public void Delete(IMPORTBILL_DETAIL sd)
        {
            db.IMPORTBILL_DETAIL.Remove(sd);
            db.SaveChanges();
        }

        public List<IMPORTBILL_DETAIL> GetAll()
        {
            return db.IMPORTBILL_DETAIL.ToList();
        }

        public IMPORTBILL_DETAIL GetByID(string id)
        {
            return db.IMPORTBILL_DETAIL.Find(id);
        }

        public void Update(IMPORTBILL_DETAIL sd)
        {
            IMPORTBILL_DETAIL s = db.IMPORTBILL_DETAIL.SingleOrDefault(x => x.IB_DETAIL_ID == sd.IB_DETAIL_ID);
            s.PRD_ID = sd.PRD_ID;
            s.QUANTITY = sd.QUANTITY;
            s.IB_PRICE = sd.IB_PRICE;
            db.SaveChanges();
        }


        public void Newimportbilldetail(
        string id,
        string ibid,
        string prdid,
        int quantity,
        float price)
        {
            var importbillDetail = new IMPORTBILL_DETAIL
            {
                IB_DETAIL_ID = id,
                IB_ID = ibid,
                PRD_ID = prdid,
                QUANTITY = quantity,
                IB_PRICE = price
            };

            db.IMPORTBILL_DETAIL.Add(importbillDetail);
            db.SaveChanges();

        }
    }
}
