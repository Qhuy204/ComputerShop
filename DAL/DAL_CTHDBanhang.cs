using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DAL_CTHDBanhang
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public void Delete(SALEBILL_DETAIL sd)
        {
            db.SALEBILL_DETAIL.Remove(sd);
            db.SaveChanges();
        }

        public List<SALEBILL_DETAIL> GetAll()
        {
            return db.SALEBILL_DETAIL.ToList();
        }

        public SALEBILL_DETAIL GetByID(string id)
        {
            return db.SALEBILL_DETAIL.Find(id);
        }

        public void Update(SALEBILL_DETAIL sd)
        {
            SALEBILL_DETAIL s = db.SALEBILL_DETAIL.SingleOrDefault(x => x.SL_DETAIL_ID == sd.SL_DETAIL_ID);
            s.PRD_ID = sd.PRD_ID;
            s.QUANTITY = sd.QUANTITY;
            s.PRICE = sd.PRICE;
            db.SaveChanges();
        }


        public void NewSalebill(
        string id,
        string slid,
        string prdid,
        int quantity,
        float price)
        {
            var salebillDETAIL = new SALEBILL_DETAIL
            {
                SL_DETAIL_ID = id,
                SL_ID = slid,
                PRD_ID = prdid,
                QUANTITY = quantity,
                PRICE= price
            };

            db.SALEBILL_DETAIL.Add(salebillDETAIL);
            db.SaveChanges();

        }
    }
}
