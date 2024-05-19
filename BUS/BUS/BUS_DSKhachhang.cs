﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DSKhachhang
    {
        private DAL_DSKhachhang dalKH = new DAL_DSKhachhang();

        public void Add(CUSTOMER ct)
        {
            ct.CUS_ID= GetNewID();
            dalKH.Add(ct);
        }

        public bool Delete(string ctmID)
        {
            CUSTOMER cus = GetByID(ctmID);
            if (cus != null)
            {
                dalKH.Delete(cus);
                return true;
            }
            return false;
        }

        public List<CUSTOMER> GetAll()
        {
            return dalKH.GetAll();
        }

        public CUSTOMER GetByID(string id)
        {
            return dalKH.GetByID(id);
        }

        public CUSTOMER GetByName(string name)
        {
            return dalKH.GetByName(name);
        }


        public string GetNewID()
        {
            int id = GetAll().Count() == 0 ? 1 : Int32.Parse(GetAll().Last().CUS_ID.Substring(2)) + 1;
            return "KH" + id;
        }

        public List<CUSTOMER> SearchKhachhangByName(string keyword)
        {
            return GetAll().Where(x => x.CUS_NAME.ToLower().Contains(keyword)).ToList();
        }

        public bool Update(CUSTOMER brd)
        {
            if (GetByID(brd.CUS_ID) != null)
            {
                dalKH.Update(brd);
                return true;
            }
            return false;
        }
    }
}
