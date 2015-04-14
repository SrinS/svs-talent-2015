using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Common
{
    /// <summary>
    /// Public enumerator "TransactionStatus" with 5 members
    /// 
    /// </summary>
    public enum TransactionStatus
    {
        NothingSelected,
        InProcess,
        Completed,
        CompletedWithWarning,
        Failed
    }
}