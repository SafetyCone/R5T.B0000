using System;

using R5T.B0000;


namespace System
{
    public static partial class ICharacterOperatorExtensions
    {
        public static bool IsUppercase(this ICharacterOperator _,
            char character)
        {
            var output = Char.IsUpper(character);
            return output;
        }
    }
}
