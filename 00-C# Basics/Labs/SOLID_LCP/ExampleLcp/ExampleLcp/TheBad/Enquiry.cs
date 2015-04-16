using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLcp.TheBad
{
    public class Enquiry
    {
        private int _CustType;
        public  double getDiscount(double TotalSales)
        {
            if (_CustType == 1)
            {
                return TotalSales - 100;
            }
            else
            {
                return TotalSales - 50;
            }
        }
        public  void Add()
        {
            throw new Exception("Not allowed");
        }
     

    }
}
