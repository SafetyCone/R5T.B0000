using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExceptionMessage : IExceptionMessage
    {
        #region Static
        
        public static ExceptionMessage Instance { get; } = new();

        #endregion
    }
}