﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLcp.TheGood
{
    /// <summary>
    /// Discount for Silver
    /// </summary>
    public class Silver : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            if (CustomType == 1)
            {
                return TotalSales - 200;
            }
            else
            {
                return TotalSales - 100;
            }
        }

        public override void Add()
        {
            throw new Exception("Not allowed");
        }
    }
}