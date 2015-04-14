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
    /// </summary>
    public interface IDepositAccount : IAccount
    {
        #region Properties
        /// <summary>
        /// Period
        /// </summary>
        TimePeriod Period { get; }
        /// <summary>
        /// Interest
        /// </summary>
        InterestRate Interest { get; }
        /// <summary>
        /// StartDate
        /// </summary>
        DateTime StartDate { get; }
        /// <summary>
        /// EndDate
        /// </summary>
        DateTime EndDate { get; }
        /// <summary>
        /// TransactionAccount
        /// </summary>
        ITransactionAccount TransactionAccount { get; }

        #endregion
    }
}
