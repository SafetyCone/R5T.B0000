using System;

using R5T.B0000;


namespace System
{
    public static class IPredicateExtensions
    {
        public static Func<T, bool> True<T>(this IPredicate _)
        {
            return x => true;
        }
    }
}
