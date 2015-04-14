using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Common
{
    /// <summary>
    /// 
    /// Public structure 
    /// 
    /// </summary>
    public struct CurrencyAmount
    {
        #region Fields and Properties
        
        /// <summary>
        /// Each property has a backing private field
        /// </summary>

        private decimal amount;
        public decimal Amount 
        {
            get { return amount; }
            set { amount = value; }
        }

        private string currency;
        public string Currency 
        {
            get { return currency; }
            set { currency = value; }
        }

        #endregion
    }
}
