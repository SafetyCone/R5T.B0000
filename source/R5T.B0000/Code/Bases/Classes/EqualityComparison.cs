using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class EqualityComparison : IEqualityComparison
    {
        #region Static
        
        public static EqualityComparison Instance { get; } = new();

        #endregion
    }
}