using System;

using R5T.Z0000;
using R5T.Z0001;


namespace R5T.B0000.X001
{
    public static class Instances
    {
        public static ICharacters Characters { get; } = Z0000.Characters.Instance;
        public static IPredicates<T> Predicates<T>() => Z0001.Predicates<T>.Instance;
        public static IRegularExpressionPatterns RegularExpressionPatterns { get; } = Z0001.RegularExpressionPatterns.Instance;
        public static IStrings Strings { get; } = Z0000.Strings.Instance;
    }
}
