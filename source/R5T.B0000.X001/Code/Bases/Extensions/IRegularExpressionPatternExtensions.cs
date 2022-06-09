using System;

using R5T.B0000;

using Instances = R5T.B0000.X001.Instances;


namespace System
{
    public static class IRegularExpressionPatternExtensions
    {
        public static string AllNonAlphanumeric(this IRegularExpressionPattern _)
        {
            return Instances.RegularExpressionPatterns.AllNonAlphanumeric;
        }
    }
}
