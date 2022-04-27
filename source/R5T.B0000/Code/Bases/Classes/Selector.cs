using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Selector : ISelector
    {
        #region Static
        
        public static Selector Instance { get; } = new();

        #endregion
    }
}