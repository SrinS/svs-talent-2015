using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Common.Interfaces;

namespace TestProject.Common
{
    public static class Logging
    {
        private static ILogger theLogger;

        public static void LogError(string message, Exception e = null, params object[] formatParams)
        {
            string tmp = string.Format(message, formatParams);
            //
            theLogger.LogError(tmp,e);
        }

        public static void LogWarn(string mesage)
        {
            

        }
    }
}
