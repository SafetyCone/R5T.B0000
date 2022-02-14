using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Exception : IException
    {
        #region Static
        
        public static Exception Instance { get; } = new();

        #endregion
    }
}