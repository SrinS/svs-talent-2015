using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Common
{
    /// <summary>
    /// Custom exeption class that inherits from ApplicationExeption
    /// </summary>
    public class CurrencyMismatchException : ApplicationException
    {
        /// <summary>
        /// Constructor that calls the base class constructor
        /// 
        /// </summary>
        /// <param type=string name="message"></param>
        public CurrencyMismatchException(string message) : base(message)
        {

        }
    }
}
