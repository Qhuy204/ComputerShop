using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HDBanhang
    {
        private DAL_HDBanhang dalhdbh = new DAL_HDBanhang();

        public bool Delete(string id)
        {
            SALEBILL hdbanhang = GetbyID(id);
            if (hdbanhang != null)
            {
                dalhdbh.Delete(hdbanhang);
                return true;
            }
            return false;
        }

        public List<SALEBILL> GetAll()
        {
            return dalhdbh.GetAll();
        }

        public SALEBILL GetbyID(string id)
        {
            return dalhdbh.GetByID(id);
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
                                bool success = Int32.TryParse(p.SL_ID.Substring(2), out id);
                                return success ? id : 0;
                            })
                            .Max();
            }

            return "SB" + (maxID + 1);
        }
        public List<SALEBILL> SearchSalebill(string keyword, string idkh)
        {
            return GetAll().Where(x => x.CUS_ID.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(SALEBILL sl)
        {
            if (GetbyID(sl.SL_ID) != null)
            {
                dalhdbh.Update(sl);
                return true;
            }
            return false;
        }

        public List<SALEBILL> TimKiemHoadonban(string khachhang, string nhanvien, string id, DateTime? startDate, DateTime? endDate)
        {
            return dalhdbh.TimKiemHoadonban(khachhang, nhanvien, id, startDate, endDate);
        }

        public void NewSalebill(
        string id,
        DateTime date,
        string cusid,
        string empid,
        string discode,
        string promotion,
        string payment,
        string note,
        string status,
        float totalmoney,
        string banggia,
        float moneyafterdiscount)
        {
            dalhdbh.NewSalebill(id, date, cusid, empid, discode, promotion, payment, note, status, totalmoney, banggia, moneyafterdiscount);
        }
    }
}
