using System;

using R5T.B0000;

using R5T.B0000.X001;


namespace System
{
    public static class IRegularExpressionPatternExtensions
    {
        public static string AllNonAlphanumeric(this IRegularExpressionPattern _)
        {
            return RegularExpressionPatterns.AllNonAlphanumeric;
        }
    }
}
