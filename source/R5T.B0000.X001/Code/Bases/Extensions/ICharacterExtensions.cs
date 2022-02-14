using System;

using R5T.B0000;
using R5T.B0000.X001;


namespace System
{
    public static partial class ICharacterExtensions
    {
        public static char Ampersand(this ICharacter _)
        {
            return Characters.Ampersand;
        }

        public static char Asterix(this ICharacter _)
        {
            return Characters.Asterix;
        }

        public static char Period(this ICharacter _)
        {
            return Characters.Period;
        }

        public static char LessThan(this ICharacter _)
        {
            return Characters.LessThan;
        }

        public static char OpenBrace(this ICharacter _)
        {
            return Characters.OpenBrace;
        }

        public static char Tick(this ICharacter _)
        {
            return Characters.Tick;
        }

        public static char I_UpperCase(this ICharacter _)
        {
            return Characters.I_UpperCase;
        }

#pragma warning disable IDE1006 // Naming Styles

        public static char s_LowerCase(this ICharacter _)
        {
            return Characters.I_UpperCase;
        }

#pragma warning restore IDE1006 // Naming Styles
    }
}