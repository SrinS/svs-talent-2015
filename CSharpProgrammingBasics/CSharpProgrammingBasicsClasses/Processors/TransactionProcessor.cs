using CSharpProgrammingBasicsClasses.Common;
using CSharpProgrammingBasicsClasses.Helpers;
using CSharpProgrammingBasicsClasses.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Processors
{
    /// <summary>
    ///  ITransactionProcessor interface
    ///  
    /// </summary>
    public class TransactionProcessor : ITransactionProcessor
    {
        #region Field and Properties

        private IList<TransactionLogEntry> transactionLog;

        private TransactionLogEntry lastTransaction;

        /// <summary>
        /// Returns the last transaction in the transactionLog list
        /// 
        /// </summary>
        public TransactionLogEntry LastTransaction
        {
            get
            {
                if(transactionLog != null)
                {
                    lastTransaction = transactionLog[transactionLog.Count - 1];
                    return lastTransaction;
                }
                return null;
            }
        }

        /// <summary>
        /// Returns the number of transactions
        /// 
        /// </summary>
        public int TransactionCount
        {
            get
            {
                return transactionLog.Count;
            }
        }

        /// <summary>
        /// TransactionLogger delegate type
        /// </summary>
        public TransactionLogger ExternalLogger { get; set; }

        /// <summary>
        /// This indexer is used for getting the last transaction
        /// </summary>
        /// <param type=int name="i"></param>
        /// <returns>TransactionLogEntry</returns>
        public TransactionLogEntry this[int i]
        {
            get
            {
                if(i >= 0 && i < transactionLog.Count)
                {
                    return transactionLog[i];
                }
                return null;
            }
        }

        #endregion

        #region Singleton pattern

        /// <summary>
        /// Instance of TransactionProcessor
        /// </summary>
        private static readonly TransactionProcessor instance;

        /// <summary>
        /// The default constructor needs to be private
        /// 
        /// </summary>
        private TransactionProcessor()
        {
            transactionLog = new List<TransactionLogEntry>();
            ExternalLogger += AccountHelper.LogTransaction;
            ExternalLogger += AccountHelper.NotifyNationalBank;
        }

        /// <summary>
        /// The default static constructor initializes the TransactionProcessor instance 
        /// </summary>
        static TransactionProcessor()
        {
            instance = new TransactionProcessor();
        }

        /// <summary>
        /// Instance of TransactionProcessor
        /// </summary>
        /// <returns>TransactionProcessor</returns>
        public static TransactionProcessor GetTransactionProcessor()
        {
            return instance;
        }

        #endregion

        #region Methods

        /// <summary>
        /// ExternalLogger delegate property
        /// </summary>
        /// <param type=IAccount name="account"></param>
        /// <param type=TransactionType name="transactionType"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        private void CallExternalLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            ExternalLogger(account, transactionType, amount);
        }

        /// <summary>
        /// Extension method and throws NotImplementedExeption
        /// </summary>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <param type=IEnumerable<IAccount> name="accounts"></param>
        /// <returns></returns>
        public TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts)
        {
            IAccount[] arrayAccount = accounts.ToArray();
            return ProcessGroupTransaction(TransactionType.Debit, amount, arrayAccount);
        }

        /// <summary>
        /// TransactionLogEntry and puts it in the transactionLog list
        /// </summary>
        /// <param type=TransactionType name="transactionType"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <param type=IAccount[] name="accounts"></param>
        /// <param type=TransactionStatus name="transactionStatus"></param>
        private void LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts, TransactionStatus transactionStatus)
        {
            TransactionLogEntry log = new TransactionLogEntry();
            log.TransactionType = transactionType;
            log.Amount = amount;
            log.Accounts = accounts;
            log.Status = transactionStatus;

            transactionLog.Add(log);
        }

        /// <summary>
        /// Executes the appropriate action depending on the transaction type
        /// </summary>
        /// <param type=TransactionType name="transactionType"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <param type=IAccount[] name="accounts"></param>
        /// <returns>TransactionStatus</returns>
        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            TransactionStatus status = new TransactionStatus();
            if (transactionType == TransactionType.Credit)
            {
                foreach (IAccount account in accounts)
                {
                    account.CreditAmount(amount);
                    //Calls the delegate foreach action
                    CallExternalLogger(account, transactionType, amount);
                }
                status = TransactionStatus.Completed;
            }
            else if (transactionType == TransactionType.Debit)
            {
                foreach (IAccount account in accounts)
                {
                    account.DebitAmount(amount);
                    CallExternalLogger(account, transactionType, amount);
                }
                status = TransactionStatus.Completed;
            }
            else
            {
                status = TransactionStatus.Failed;
            }
            //Logs the transaction
            LogTransaction(transactionType, amount, accounts, status);
            return status;
        }

        /// <summary>
        /// According to the type of transaction executes the appropriate operation
        /// </summary>
        /// <param type=TransactionType name="transactionType"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <param type=IAccount name="accountFrom"></param>
        /// <param type=IAccount name="accountTo"></param>
        /// <returns>TransactionStatus</returns>
        public TransactionStatus ProcessTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount accountFrom, IAccount accountTo)
        {
            TransactionStatus status = new TransactionStatus();
            IAccount[] accounts = new IAccount[2];
            accounts[0] = accountFrom;
            accounts[1] = accountTo;

            switch (transactionType)
            {
                case TransactionType.Transfer:
                    accountFrom.DebitAmount(amount);
                    CallExternalLogger(accountFrom, transactionType, amount);
                    accountTo.CreditAmount(amount);
                    CallExternalLogger(accountTo, transactionType, amount);
                    status = TransactionStatus.Completed;
                    LogTransaction(transactionType, amount, accounts, status);
                    return status;

                case TransactionType.Debit:
                    accountFrom.DebitAmount(amount);
                    CallExternalLogger(accountFrom, transactionType, amount);
                    status = TransactionStatus.Completed;
                    LogTransaction(transactionType, amount, accounts, status);
                    return status;

                case TransactionType.Credit:
                    accountFrom.CreditAmount(amount);
                    CallExternalLogger(accountFrom, transactionType, amount);
                    status = TransactionStatus.Completed;
                    LogTransaction(transactionType, amount, accounts, status);
                    return status;

                default:
                    status = TransactionStatus.NothingSelected;
                    LogTransaction(transactionType, amount, null, status);
                    return status;
            }
        }

        #endregion
    }
}
