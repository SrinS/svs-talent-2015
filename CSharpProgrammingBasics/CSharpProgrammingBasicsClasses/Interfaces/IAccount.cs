using CSharpProgrammingBasicsClasses.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Interfaces
{
    public interface IAccount
    {
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        long Id { get; }
        string Number { get; }
        string Currency { get; }
        CurrencyAmount Balance { get; }

        #endregion

        #region Events
        /// <summary>
        /// 
        /// </summary>
        event BalanceChanged OnBalanceChanged;

        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        TransactionStatus DebitAmount(CurrencyAmount amount);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        TransactionStatus CreditAmount(CurrencyAmount amount);

        #endregion
    }
}
