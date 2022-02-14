using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RegularExpressionOperator : IRegularExpressionOperator
    {
        #region Static
        
        public static RegularExpressionOperator Instance { get; } = new();

        #endregion
    }
}