using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class LimitReachedException:ApplicationException
    {
        /// <summary>
        /// 
        /// </summary>
        public int ErrorCode { set; get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="diff"></param>
        public LimitReachedException(int errorCode,string diff) : base(diff)
         {
             this.ErrorCode = errorCode;
         }
    }
}
