using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RegularExpressionPattern : IRegularExpressionPattern
    {
        #region Static
        
        public static RegularExpressionPattern Instance { get; } = new();

        #endregion
    }
}