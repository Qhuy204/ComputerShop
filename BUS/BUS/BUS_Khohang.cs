using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Khohang
    {
        private DAL_Khohang dalKhohang= new DAL_Khohang();


        public bool Delete(string wrID)
        {
            WAREHOUSE warehouse = GetByID(wrID);
            if (warehouse != null)
            {
                dalKhohang.Delete(warehouse);
                return true;
            }
            return false;
        }

        public List<WAREHOUSE> GetAll()
        {
            return dalKhohang.GetAll();
        }

        public WAREHOUSE GetByID(string id)
        {
            return dalKhohang.GetByID(id);
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

        public List<WAREHOUSE> SearchByName(string keyword)
        {
            return GetAll().Where(x => x.PRD_NAME.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(WAREHOUSE wr)
        {
            if (GetByID(wr.PRD_ID) != null)
            {
                dalKhohang.Update(wr);
                return true;
            }
            return false;
        }

        public void AddProductInformation(string id, float importprice, float retailprice, float wholesaleprice)
        {
            dalKhohang.AddProductInformation(id, importprice, retailprice, wholesaleprice);
        }
        public List<WAREHOUSE> TimKiemSanPham(string keyword)
        {
            return dalKhohang.TimKiemSanPham(keyword);
        }

        public List<WAREHOUSE> TimKiemSanPham3(string nhanhieu, string loaisp, string keyword)
        {
            return dalKhohang.TimKiemSanPham3(nhanhieu, loaisp, keyword);
        }

        public string getPRD_ID(string prdName)
        {
            return dalKhohang.getPRD_ID(prdName);
        }

        public List<WAREHOUSE> getPRD_NAME(string brd_id)
        {
            return dalKhohang.getPRD_NAME(brd_id);
        }

        public double? getPRD_IMPORT_PRICE(string id)
        {
            return dalKhohang.getPRD_IMPORT_PRICE(id);

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
            dalKhohang.NewProduct(image, id, name, brand_id, producttype_id, import, retail, whole);
        }
    }
}
