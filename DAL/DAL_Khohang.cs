using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Khohang
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();


        public void Delete(WAREHOUSE wr)
        {
            db.WAREHOUSEs.Remove(wr);
            db.SaveChanges();
        }

        public List<WAREHOUSE> GetAll()
        {
            return db.WAREHOUSEs.ToList();
        }

        public WAREHOUSE GetByID(string id)
        {
            return db.WAREHOUSEs.Find(id);
        }

        public void Update(WAREHOUSE wr)
        {
            WAREHOUSE s = db.WAREHOUSEs.SingleOrDefault(x => x.PRD_ID == wr.PRD_ID);
            s.PRD_IMG = wr.PRD_IMG;
            s.PRD_ID = wr.PRD_ID;
            s.PRD_NAME= wr.PRD_NAME;
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
        }
        public List<WAREHOUSE> TimKiemSanPham(string keyword)
        {
            var query = db.WAREHOUSEs.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(p => p.PRD_NAME.ToLower().Contains(keyword));
            }

            return query.ToList();
        }

        public List<WAREHOUSE> TimKiemSanPham3(string nhanhieu, string loaisp, string keyword)
        {
            var query = db.WAREHOUSEs.AsQueryable();

            if (!string.IsNullOrEmpty(nhanhieu))
            {
                query = query.Where(p => p.BRD_ID.ToLower().Contains(nhanhieu));
            }

            if (!string.IsNullOrEmpty(loaisp))
            {
                query = query.Where(p => p.PRD_TYPE_ID.ToLower().Contains(loaisp));
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(p => p.PRD_NAME.ToLower().Contains(keyword));
            }

            return query.ToList();
        }

        public string getPRD_ID(string prdName)
        {
            var product = db.WAREHOUSEs.FirstOrDefault(p => p.PRD_NAME == prdName);
            return product != null ? product.PRD_ID : null;
        }

        public double? getPRD_IMPORT_PRICE(string id)
        {
            var product = db.WAREHOUSEs.FirstOrDefault(p => p.PRD_ID == id);
            return product?.IMPORT_PRICE;
        }


        public List<WAREHOUSE> getPRD_NAME(string BRD_ID)
        {
            var products = db.WAREHOUSEs
                             .Where(p => p.BRD_ID == BRD_ID)
                             .ToList();

            return products;
        }


        public void NewProduct(
        byte[] image,
        string id,
        string name,
        string brand_id,
        string producttype_id,
        float import,
        float retail,
        float whole)
        {
            var product = new WAREHOUSE
            {
                PRD_IMG = image,
                PRD_ID = id,
                PRD_NAME = name,
                BRD_ID = brand_id,
                PRD_TYPE_ID = producttype_id,
                RDY_FOR_SALE = 0,
                INVENTORY_QUANTITY = 0,
                CREATE_DAY = DateTime.Now,
                IMPORT_PRICE = import,
                RETAIL_PRICE = retail,
                WHOLESALE_PRICE = whole
            };

            db.WAREHOUSEs.Add(product);
            db.SaveChanges();

        }
    }
}
