using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class GuidOperator : IGuidOperator
    {
        #region Static
        
        public static GuidOperator Instance { get; } = new();

        #endregion
    }
}