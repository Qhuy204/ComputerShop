﻿using System;
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

        public void Add(PRODUCT prd)
        {
            db.PRODUCTs.Add(prd);
            db.SaveChanges();
        }

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

        public void Update(PRODUCT prd)
        {
            PRODUCT s = db.PRODUCTs.SingleOrDefault(x => x.PRD_ID == prd.BRD_ID);
            s.PRD_IMG = prd.PRD_IMG;
            s.PRD_NAME = prd.PRD_NAME;
            s.PRD_TYPE_ID = prd.PRD_TYPE_ID;
            s.BRD_ID = prd.BRD_ID;
            s.RDY_FOR_SALE = prd.RDY_FOR_SALE;
            s.QUANTITY = prd.QUANTITY;
            s.DELIVERY_ALLOWED = prd.DELIVERY_ALLOWED;
            s.PRD_WEIGHT = prd.PRD_WEIGHT;
            //s.CREA
            db.SaveChanges();
        }

        public List<PRODUCT> TimKiemSanPham(string nhanhieu, string loaisp, string keyword)
        {
            var query = db.PRODUCTs.AsQueryable();

            if (!string.IsNullOrEmpty(nhanhieu))
            {
                query = query.Where(p => p.BRD_ID.Contains(nhanhieu));
            }

            if (!string.IsNullOrEmpty(loaisp))
            {
                query = query.Where(p => p.PRD_TYPE_ID.Contains(loaisp));
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(p => p.PRD_NAME.Contains(keyword));
            }

            return query.ToList();
        }

        public string getPRD_ID(string prdName)
        {
            var product = db.PRODUCTs.FirstOrDefault(p => p.PRD_NAME == prdName);
            return product != null ? product.PRD_ID : null;
        }

        public void NewProduct(
        //string image,
        string id,
        string name,
        string brand_id,
        string producttype_id,
        bool deliveryallowed,
        float weight)
        {
            var product = new PRODUCT
            {
                //PRD_IMG = image,
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
