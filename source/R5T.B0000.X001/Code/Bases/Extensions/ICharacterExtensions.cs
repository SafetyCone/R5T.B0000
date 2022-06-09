using System;

using R5T.B0000;

using Instances = R5T.B0000.X001.Instances;


namespace System
{
    public static partial class ICharacterExtensions
    {
        public static char Ampersand(this ICharacter _)
        {
            return Instances.Characters.Ampersand;
        }

        public static char Asterix(this ICharacter _)
        {
            return Instances.Characters.Asterix;
        }

        public static char Period(this ICharacter _)
        {
            return Instances.Characters.Period;
        }

        public static char LessThan(this ICharacter _)
        {
            return Instances.Characters.LessThan;
        }

        public static char OpenBrace(this ICharacter _)
        {
            return Instances.Characters.OpenBrace;
        }

        public static char Tick(this ICharacter _)
        {
            return Instances.Characters.Tick;
        }

        public static char I_UpperCase(this ICharacter _)
        {
            return Instances.Characters.I_Uppercase;
        }

#pragma warning disable IDE1006 // Naming Styles

        public static char s_LowerCase(this ICharacter _)
        {
            return Instances.Characters.s_Lowercase;
        }

#pragma warning restore IDE1006 // Naming Styles
    }
}