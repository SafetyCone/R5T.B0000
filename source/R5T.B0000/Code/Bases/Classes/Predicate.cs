using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Predicate : IPredicate
    {
        #region Static
        
        public static Predicate Instance { get; } = new();

        #endregion
    }
}