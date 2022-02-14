using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Guid : IGuid
    {
        #region Static
        
        public static Guid Instance { get; } = new();

        #endregion
    }
}