using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Payment
    {
        DAL_Payment pmt = new DAL_Payment();

        public List<PAYMENT> GetAll()
        {
            return pmt.GetAll();
        }
    }
}
