using System;

using R5T.B0000;

using Instances = R5T.B0000.X001.Instances;


namespace System
{
    public static class IPredicateExtensions
    {
        public static Func<T, bool> False<T>(this IPredicate _)
        {
            return Instances.Predicates<T>().False;
        }

        public static Func<T, bool> True<T>(this IPredicate _)
        {
            return Instances.Predicates<T>().True;
        }
    }
}
