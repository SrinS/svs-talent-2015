using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses.Common
{
    /// <summary>
    /// Public structure "TimePeriod"
    /// </summary>
    public struct TimePeriod
    {
        #region Fields and Properties

        /// <summary>
        /// 
        /// Each property has a backing private field
        /// 
        /// </summary>
        /// 
        private int period;
        public int Period 
        {
            get { return period; }
            set { period = value; }
        }

        private UnitOfTime unit;
        /// <summary>
        /// 
        /// </summary>
        public UnitOfTime Unit 
        {
            get { return unit; }
            set { unit = value; }
        }

        #endregion
    }
}