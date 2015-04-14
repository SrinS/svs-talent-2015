

namespace CSharpProgrammingBasicsClasses.Common
{
    /// <summary>
    /// 
    /// Public structure "InerestRate"
    /// 
    /// </summary>
    public struct InterestRate
    {
        #region Fields and Properties

        /// <summary>
        /// 
        /// Each property has
        /// 
        /// </summary>
        
        private decimal percent;
        public decimal Percent 
        {
            get { return percent; }
            set { percent = value; }
        }

        private UnitOfTime unit;
        public UnitOfTime Unit 
        {
            get { return unit; }
            set { unit = value; }
        }

        #endregion
    }
}