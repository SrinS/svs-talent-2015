using CSharpProgrammingBasicsClasses.Common;
using CSharpProgrammingBasicsClasses.Interfaces;
using System;
using System.Linq;

using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Extensions
{
    public static class ProcessorExtensions
    {
        /// <summary>
        /// Extension method on the Transaction Processor class
        /// </summary>
        /// <param type=ITransactionProcessor name="processor"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <param type=IEnumerable<IAccount> name="accounts"></param>
        /// <returns>TransactionStatus</returns>
        public static TransactionStatus ChargeProcessingFee(this ITransactionProcessor processor, CurrencyAmount amount, IEnumerable<IAccount> accounts) 
        {
            processor.ProcessGroupTransaction(TransactionType.Debit, amount, accounts.ToArray());
            return TransactionStatus.Completed;
        }
    }
}
