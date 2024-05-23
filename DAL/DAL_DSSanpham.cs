using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DSSanpham
    {
        private CuaHangMayTinhEntities1 db = new CuaHangMayTinhEntities1();
        private DataTable dt = new DataTable();

        public void Delete(PRODUCT prd)
        {
            db.PRODUCTs.Remove(prd);
            db.SaveChanges();
        }

        public List<PRODUCT> GetAll()
        {
            return db.PRODUCTs.ToList();
        }

        public PRODUCT GetByID(string id)
        {
            return db.PRODUCTs.Find(id);
        }

        public bool Update(PRODUCT prd)
        {
            PRODUCT s = db.PRODUCTs.SingleOrDefault(x => x.PRD_ID == prd.PRD_ID);

            if (s != null)
            {
                s.PRD_ID = prd.PRD_ID;
                s.PRD_IMG = prd.PRD_IMG;
                s.PRD_NAME = prd.PRD_NAME;
                s.PRD_TYPE_ID = prd.PRD_TYPE_ID;
                s.BRD_ID = prd.BRD_ID;
                s.DELIVERY_ALLOWED = prd.DELIVERY_ALLOWED;
                s.PRD_WEIGHT = prd.PRD_WEIGHT;

                db.SaveChanges();
                return true;
            }
            else
            {
                // Log or handle the case when the product is not found
                return false;
            }
        }


        public List<PRODUCT> TimKiemSanPham(string nhanhieu, string loaisp, string keyword)
        {
            var query = db.PRODUCTs.AsQueryable();

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
            var product = db.PRODUCTs.FirstOrDefault(p => p.PRD_NAME == prdName);
            return product != null ? product.PRD_ID : null;
        }

        public void NewProduct(
        byte[] image,
        string id,
        string name,
        string brand_id,
        string producttype_id,
        bool deliveryallowed,
        float weight)
        {
            var product = new PRODUCT
            {
                PRD_IMG = image,
                PRD_ID = id,
                PRD_NAME = name,
                BRD_ID = brand_id,
                PRD_TYPE_ID = producttype_id,
                RDY_FOR_SALE = 0,
                QUANTITY = 0,
                CREATE_DAY = DateTime.Now,
                DELIVERY_ALLOWED = deliveryallowed,
                PRD_WEIGHT = weight
            };

            db.PRODUCTs.Add(product);
            db.SaveChanges();

        }
    }
}
