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
    /// 
    /// Public class "TransactionAccount" 
    /// 
    /// </summary>
    [AccountMetadata]
    public class TransactionAccount : Account, ITransactionAccount
    {
        #region Fields and Properties

        /// <summary>
        /// 
        /// Private CurrencyAmount "limit" field
        /// 
        /// </summary>
        private CurrencyAmount limit;

        /// <summary>
        /// Public CurrencyAmount "Limit" property for the "limit" field
        /// 
        /// </summary>
        public CurrencyAmount Limit
        {
            get { return limit; }
            private set { limit = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// "TransactionAccount" constructor for TransactionAccount who takes 2 parametersand
        /// 
        /// </summary>
        /// <param type="string" name="currency"></param>
        /// <param type="decimal" name="limitAmount"></param>
        public TransactionAccount(string currency, decimal limitAmount)
            : base(currency)
        {
            CurrencyAmount c = new CurrencyAmount();
            c.Amount = limitAmount;
            this.Limit = c;
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
            string number = AccountHelper.GenerateAccountNumber<ITransactionAccount>(this.Id);
            return number;
        }

        #endregion  
    }
}