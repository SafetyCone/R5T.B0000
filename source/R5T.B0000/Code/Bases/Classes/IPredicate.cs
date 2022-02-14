using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class IPredicate : IIPredicate
    {
        #region Static
        
        public static IPredicate Instance { get; } = new();

        #endregion
    }
}