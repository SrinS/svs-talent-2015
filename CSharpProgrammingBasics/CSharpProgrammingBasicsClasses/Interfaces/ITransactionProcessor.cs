using CSharpProgrammingBasicsClasses.Common;
using CSharpProgrammingBasicsClasses.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Interfaces
{
    public interface ITransactionProcessor
    {
        #region Fields and Properties

        /// <summary>
        /// ExternalLogger
        /// </summary>
        TransactionLogger ExternalLogger { get; set; }

        /// <summary>
        /// LastTransaction
        /// </summary>
        TransactionLogEntry LastTransaction { get; }

        /// <summary>
        /// TransactionCount
        /// </summary>
        int TransactionCount { get; }

        /// <summary>
        /// TransactionLogEntry
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        TransactionLogEntry this[int i] { get; }

        #endregion

        #region Methods
        /// <summary>
        /// ProcessTransaction
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="accountFrom"></param>
        /// <param name="accountTo"></param>
        /// <returns></returns>
        TransactionStatus ProcessTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount accountFrom, IAccount accountTo);
        /// <summary>
        /// ProcessGroupTransaction
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="accounts"></param>
        /// <returns></returns>
        TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts);
        /// <summary>
        /// ChargeProcessingFee
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="accounts"></param>
        /// <returns></returns>
        TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts);

        #endregion
    }
}
