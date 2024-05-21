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

        public void Add(POSITION ps)
        {
            db.POSITIONs.Add(ps);
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

        /*public void Update(WAREHOUSE wr)
        {
            WAREHOUSE s = db.WAREHOUSEs.SingleOrDefault(x => x.PRD_ID == wr.PRD_ID);
            s.PRD_IMG = wr.PRD_IMG;
            s.PRD_ID = wr.PRD_ID;
            s.PRD_NAME = wr.PRD_NAME;
            s.PRD_TYPE_ID = wr.PRD_TYPE_ID;
            s.BRD_ID = wr.BRD_ID;
            s.RDY_FOR_SALE = wr.RDY_FOR_SALE;
            s.INVENTORY_QUANTITY = wr.INVENTORY_QUANTITY;
            s.CREATE_DAY = wr.CREATE_DAY;
            s.RETAIL_PRICE = wr.RETAIL_PRICE;
            s.IMPORT_PRICE = wr.IMPORT_PRICE;
            s.WHOLESALE_PRICE = wr.WHOLESALE_PRICE;
            db.SaveChanges();
        }

        public void AddProductInformation(string id, float importprice, float retailprice, float wholesaleprice)
        {
            var product = db.WAREHOUSEs.FirstOrDefault(p => p.PRD_ID == id);
            if (product != null)
            {
                product.IMPORT_PRICE = importprice;
                product.RETAIL_PRICE = retailprice;
                product.WHOLESALE_PRICE = wholesaleprice;

                db.SaveChanges();
            }
        }*/

        public POSITION TimKiemChucvu(string keyword)
        {
            return db.POSITIONs.FirstOrDefault(p => p.PS_NAME.ToLower() == keyword.ToLower());
        }

    }
}
