using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class StringOperator : IStringOperator
    {
        #region Static
        
        public static StringOperator Instance { get; } = new();

        #endregion
    }
}