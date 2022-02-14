using System;
using System.Text.RegularExpressions;

using R5T.B0000;


namespace System
{
    public static class IRegularExpressionOperatorExtensions
    {
        public static bool IsMatch(this IRegularExpressionOperator _,
            string input,
            string regularExpressionPattern)
        {
            var output = Regex.IsMatch(input, regularExpressionPattern);
            return output;
        }
    }
}
