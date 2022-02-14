using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExceptionOperator : IExceptionOperator
    {
        #region Static
        
        public static ExceptionOperator Instance { get; } = new();

        #endregion
    }
}