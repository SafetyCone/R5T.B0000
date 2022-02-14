using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ISelector : IISelector
    {
        #region Static
        
        public static ISelector Instance { get; } = new();

        #endregion
    }
}