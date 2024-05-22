using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_QuyenofChucvu
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();

        public void Add(POSITION_AUTHORITY pa)
        {
            db.POSITION_AUTHORITY.Add(pa);
            db.SaveChanges();
        }

        public void Delete(POSITION_AUTHORITY pa)
        {
            db.POSITION_AUTHORITY.Remove(pa);
            db.SaveChanges();
        }

        public List<POSITION_AUTHORITY> GetAll()
        {
            return db.POSITION_AUTHORITY.ToList();
        }

        public POSITION_AUTHORITY GetByID(string id)
        {
            return db.POSITION_AUTHORITY.Find(id);
        }

        public void NewCV(
        string id,
        string ps_id,
        string aut_id)
        {
            var qoc = new POSITION_AUTHORITY
            {
                PS_ID = ps_id,
                ID = id,
                AUT_ID = aut_id
            };

            db.POSITION_AUTHORITY.Add(qoc);
            db.SaveChanges();

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
    }
}
