using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Common
{
    public class UserInterfaceException : ApplicationException
    {
        Exception Exception { set; get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        public UserInterfaceException(Exception ex)
        {
            this.Exception = ex;

        }
    }
}
