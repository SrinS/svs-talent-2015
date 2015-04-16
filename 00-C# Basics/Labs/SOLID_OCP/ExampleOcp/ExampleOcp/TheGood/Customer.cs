using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOcp.TheGood
{
    /// <summary>
    /// Customer discont
    /// </summary>
    public class Customer
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }
}
