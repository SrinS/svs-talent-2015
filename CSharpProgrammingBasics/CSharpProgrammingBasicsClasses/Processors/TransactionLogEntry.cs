using CSharpProgrammingBasicsClasses.Common;
using CSharpProgrammingBasicsClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Processors
{
    public class TransactionLogEntry
    {
        #region Field and Properties

        /// <summary>
        /// Each property has a backing private field
        /// </summary>

        
        private TransactionType transactionType;
        public TransactionType TransactionType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }
        /// <summary>
        /// Amount
        /// </summary>
        private CurrencyAmount amount;
        public CurrencyAmount Amount
        {
            get { return amount; }
            set{ amount = value; }
        }
        /// <summary>
        /// Accounts
        /// </summary>
        private IAccount[] accounts;
        public IAccount[] Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        /// <summary>
        /// Status
        /// </summary>
        private TransactionStatus status;
        public TransactionStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        #endregion
    }
}
