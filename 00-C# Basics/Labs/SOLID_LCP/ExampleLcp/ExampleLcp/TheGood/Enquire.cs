using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLcp.TheGood
{
    /// <summary>
    /// Discount for Enquire
    /// </summary>
    public class Enquire : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            if (CustomType == 1)
            {
                return TotalSales - 400;
            }
            else
            {
                return TotalSales - 120;
            }
        }

        public override void Add()
        {
            throw new Exception("Not allowed");
        }
    }
}
