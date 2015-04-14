
using CSharpProgrammingBasicsClasses.Common;
using CSharpProgrammingBasicsClasses.Helpers;
using CSharpProgrammingBasicsClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Accounts
{
    /// <summary>
    /// Public class "DepositAccount" 
    /// </summary>
    [AccountMetadata]
    public class DepositAccount : Account, IDepositAccount
    {
        #region Fields and Properties

        /// <summary>
        /// Private TimePeriod "period" field
        /// 
        /// </summary>
        private TimePeriod period;

        /// <summary>
        /// Public TimePeriod "Period" property for the "period" field
        /// 
        /// </summary>
        public TimePeriod Period
        {
            get { return period; }
            private set { period = value; }
        }

        /// <summary>
        /// Private InterestRate "interest" field
        /// 
        /// </summary>
        private InterestRate interest;

        /// <summary>
        /// Public InterestRate "Interest" property for the "interest" field
        /// 
        /// </summary>
        public InterestRate Interest
        {
            get { return interest; }
            private set { interest = value; }
        }

        /// <summary>
        /// Private DateTime "startDate" field
        /// 
        /// </summary>
        private DateTime startDate;

        /// <summary>
        /// Public DateTime "StartDate" property for the "startDate" field
        /// 
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            private set { startDate = value; }
        }

        /// <summary>
        /// Private DateTime "endDate" field
        /// 
        /// </summary>
        private DateTime endDate;

        /// <summary>
        /// Public DateTime "EndDate" property for the "endDate" field
        /// 
        /// </summary>
        public DateTime EndDate
        {
            get { return endDate; }
            private set { endDate = value; }
        }

        /// <summary>
        /// Private TransactionAccount "transactionAccount" field
        /// 
        /// </summary>
        private ITransactionAccount transactionAccount;

        /// <summary>
        /// 
        /// Public TransactionAccount "TransactionAccount" property for the "transactionAccount" field
        /// 
        /// </summary>
        public ITransactionAccount TransactionAccount
        {
            get { return transactionAccount; }
            private set { transactionAccount = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// "DepositAccount" constructor who takes 6 parameters
        /// 
        /// </summary>
        /// <param type="string" name="currency"></param>
        /// <param type="TimePeriod" name="depositPeriod"></param>
        /// <param type="InterestRate" name="interestRate"></param>
        /// <param type="DateTime" name="startDate"></param>
        /// <param type="DateTime" name="endDate"></param>
        /// <param type="TransactionAccount" name="transactionAccount"></param>
        public DepositAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate,
                              DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount)
            : base(currency)
        {
            this.Period = depositPeriod;
            this.Interest = interestRate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TransactionAccount = transactionAccount;
        }

        #endregion

        #region Methods

        /// <summary>
        /// GenerateAccountNumber() 
        /// 
        /// </summary>
        /// <returns>string</returns>
        protected override string GenerateAccountNumber()
        {
            string number = AccountHelper.GenerateAccountNumber<IDepositAccount>(this.Id);
            return number;
        }

        #endregion
    }
}