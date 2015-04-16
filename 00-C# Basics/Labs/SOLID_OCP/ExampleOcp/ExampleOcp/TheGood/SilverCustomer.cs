using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOcp.TheGood
{
    /// <summary>
    /// Silver discount, inheret discount from Customer
    /// </summary>
    public class SilverCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }
    }
}
