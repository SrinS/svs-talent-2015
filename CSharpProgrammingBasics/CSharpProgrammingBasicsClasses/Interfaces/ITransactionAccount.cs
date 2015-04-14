using CSharpProgrammingBasicsClasses.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Interfaces
{
    /// <summary>
    /// Implements IAccount interface
    /// 
    /// </summary>
    public interface ITransactionAccount : IAccount
    {
        #region Properties
        /// <summary>
        /// Limit
        /// </summary>
        CurrencyAmount Limit { get; }

        #endregion
    }
}
