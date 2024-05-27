using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Hoadonnhaphang
    {
        private DAL_Hoadonnhaphang dalhdnh = new DAL_Hoadonnhaphang();

        public bool Delete(string id)
        {
            IMPORTBILL hdnhap = GetbyID(id);
            if (hdnhap != null)
            {
                dalhdnh.Delete(hdnhap);
                return true;
            }
            return false;
        }

        public List<IMPORTBILL> GetAll()
        {
            return dalhdnh.GetAll();
        }

        public IMPORTBILL GetbyID(string id)
        {
            return dalhdnh.GetByID(id);
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
                                bool success = Int32.TryParse(p.IB_ID.Substring(2), out id);
                                return success ? id : 0;
                            })
                            .Max();
            }

            return "IB" + (maxID + 1);
        }
        public List<IMPORTBILL> SearchSalebill(string keyword, string idkh)
        {
            return GetAll().Where(x => x.IB_ID.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(IMPORTBILL sl)
        {
            if (GetbyID(sl.IB_ID) != null)
            {
                dalhdnh.Update(sl);
                return true;
            }
            return false;
        }

        public List<IMPORTBILL> TimKiemHoadonnhap(string ncc, string nhanvien, string id, DateTime? startDate, DateTime? endDate)
        {
            return dalhdnh.TimKiemHoadonnhap(ncc, nhanvien, id, startDate, endDate);
        }

        public void NewImportbill(
        string ibid,
        string brdid,
        string empid,
        DateTime ibdate,
        float totalmoney,
        string note)
        {
            dalhdnh.NewImportbill(ibid, brdid, empid, ibdate, totalmoney, note);

        }
    }
}
