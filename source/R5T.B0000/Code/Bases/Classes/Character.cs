using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Character : ICharacter
    {
        #region Static
        
        public static Character Instance { get; } = new();

        #endregion
    }
}