using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLcp.TheGood
{
    /// <summary>
    /// Discount for Gold
    /// </summary>
    public class Gold : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            if (CustomType == 1)
            {
                return TotalSales - 100;
            }
            else
            {
                return TotalSales - 50;
            }
        }

        public override void Add()
        {
            throw new Exception("Not allowed");
        }
    }
}
