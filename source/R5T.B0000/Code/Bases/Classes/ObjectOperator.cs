using System;


namespace R5T.B0000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ObjectOperator : IObjectOperator
    {
        #region Static
        
        public static ObjectOperator Instance { get; } = new();

        #endregion
    }
}