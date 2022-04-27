using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class EqualityComparer : IEqualityComparer
    {
        #region Static
        
        public static EqualityComparer Instance { get; } = new();

        #endregion
    }
}