using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DSSanpham
    {
        private DAL_DSSanpham dalSP = new DAL_DSSanpham();

        public bool Delete(string id)
        {
            PRODUCT product = GetbyID(id);
            if (product != null)
            {
                dalSP.Delete(product);
                return true;
            }
            return false;
        }

        public List<PRODUCT> GetAll()
        {
            return dalSP.GetAll();
        }

        public PRODUCT GetbyID(string id)
        {
            return dalSP.GetByID(id);
        }
        public string GetNewID()
        {
            var allItems = GetAll();
            int maxID = 0;

            if (allItems.Any())
            {
                maxID = allItems
                            .Select(p =>
                            {
                                int id;
                                bool success = Int32.TryParse(p.PRD_ID.Substring(3), out id);
                                return success ? id : 0; 
                            })
                            .Max();
            }

            return "PRD" + (maxID + 1);
        }
        public List<PRODUCT> SearchProduct(string keyword, string loaisp, string nhanhieu)
        {
            return GetAll().Where(x => x.PRD_NAME.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(PRODUCT Prd)
        {
            if (GetbyID(Prd.PRD_ID) != null)
            {
                dalSP.Update(Prd);
                return true;
            }
            return false;
        }

        public List<PRODUCT> TimKiemSanPham(string nhanhieu, string loaisp, string keyword)
        {
            return dalSP.TimKiemSanPham(nhanhieu, loaisp, keyword);
        }

        public string getPRD_ID(string prdName)
        {
            return dalSP.getPRD_ID(prdName);
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
            dalSP.NewProduct(image, id, name, brand_id, producttype_id, deliveryallowed, weight);
        }       
    }
}
