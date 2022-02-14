using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Object : IObject
    {
        #region Static
        
        public static Object Instance { get; } = new();

        #endregion
    }
}