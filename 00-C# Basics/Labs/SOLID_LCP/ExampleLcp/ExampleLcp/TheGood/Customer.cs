using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLcp.TheGood
{
    /// <summary>
    /// Customer definition discount
    /// </summary>
    public abstract class Customer
    {
        private int _custType;
        public int CustomType
        {
            get { return _custType; }
            set { _custType = value; }
        }
        public abstract double getDiscount(double TotalSales);

        public abstract void Add();
    }
}
