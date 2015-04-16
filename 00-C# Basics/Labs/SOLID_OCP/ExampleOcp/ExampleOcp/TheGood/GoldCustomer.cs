using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOcp.TheGood
{

    /// <summary>
    /// Gold discount, inheret discount from Silver
    /// </summary>
    public class GoldCustomer : SilverCustomer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }
}
