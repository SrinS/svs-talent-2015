using CSharpProgrammingBasicsClasses.Common;
using CSharpProgrammingBasicsClasses.Helpers;
using CSharpProgrammingBasicsClasses.Interfaces;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Accounts
{
    /// <summary>
    /// 
    /// Public sealed class LoanAccount that inherits DepositAccount
    /// 
    /// </summary>
    [AccountMetadata]
    public sealed class LoanAccount : DepositAccount, ILoanAccount
    {
        #region Constructors

        /// <summary>
        /// 
        /// Constructor with 6 parameters 
        /// 
        /// </summary>
        /// <param type=string name="currency"></param>
        /// <param type=TimePeriod name="depositPeriod"></param>
        /// <param type=InterestRate name="interestRate"></param>
        /// <param type=DateTime name="startDate"></param>
        /// <param type=DateTime name="endDate"></param>
        /// <param type=ITransactionAccount name="transactionAccount"></param>
        public LoanAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate,
                            DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount)
            : base(currency, depositPeriod, interestRate, startDate, endDate, transactionAccount)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// DebitAmount()
        /// 
        /// </summary>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <returns>TransactionStatus</returns>
        public override TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            base.CreditAmount(amount);
            return TransactionStatus.Completed;
        }

        /// <summary>
        /// 
        /// CreditAmount()
        /// 
        /// </summary>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <returns>TransactionStatus</returns>
        public override TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            base.DebitAmount(amount);
            return TransactionStatus.Completed;
        }

        /// <summary>
        /// 
        /// GenerateAccountNumber() 
        /// 
        /// </summary>
        /// <returns>string</returns>
        protected override string GenerateAccountNumber()
        {
            string number = AccountHelper.GenerateAccountNumber<ILoanAccount>(this.Id);
            return number;
        }

        #endregion
    }
}
