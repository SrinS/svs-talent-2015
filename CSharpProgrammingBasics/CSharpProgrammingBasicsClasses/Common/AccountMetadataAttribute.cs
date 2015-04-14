using System;

namespace CSharpProgrammingBasicsClasses.Common
{
    /// <summary>
    /// Custom attribute used only on classes
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class AccountMetadataAttribute : Attribute
    {
        public string AccountDescription { get; set; }
        public string AccountLimitations { get; set; }
    }

    /// <summary>
    /// 
    /// Custom attribute used only on properties and fields
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class FormatRestrictionAttribute : Attribute
    {
        public string FormatString { get; set; }
        public int MaxLength { get; set; }
    }
}