using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExceptionMessageOperator : IExceptionMessageOperator
    {
        #region Static
        
        public static ExceptionMessageOperator Instance { get; } = new();

        #endregion
    }
}