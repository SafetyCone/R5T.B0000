using System;
using System.Collections.Generic;
using System.Linq;

using R5T.Magyar;

using R5T.B0000;


namespace System
{
    public static partial class IStringOperatorExtensions
    {
        public static string Append(this IStringOperator _,
            string @string,
            string appendix)
        {
            var output = @string + appendix;
            return output;
        }

        public static string Append(this IStringOperator _,
            string @string,
            char appendix)
        {
            var output = $"{@string}{appendix}";
            return output;
        }

        public static string AppendWithSeparator(this IStringOperator _,
            string @string,
            char separator,
            string appendix)
        {
            var output = $"{@string}{separator}{appendix}";
            return output;
        }

        public static string BeginningUpToButNotIncluding(this IStringOperator _,
            int index,
            string @string)
        {
            var output = @string.Substring(0, index);
            return output;
        }

        public static bool EndsWith(this IStringOperator _,
            string @string,
            string suffix)
        {
            var output = @string.EndsWith(suffix);
            return output;
        }

        /// <summary>
        /// Returns the string, without the ending.
        /// </summary>
        public static string ExceptEnding(this IStringOperator _,
            string @string,
            string ending)
        {
            var endsWithEnding = _.EndsWith(
                @string,
                ending);
            
            if(!endsWithEnding)
            {
                throw new ArgumentException($"String '{@string}' did not end with ending '{endsWithEnding}'.", nameof(@string));
            }

            var output = @string.Substring(0, @string.Length - ending.Length);
            return output;
        }

        public static bool FirstCharacterIs(this IStringOperator _,
            char character,
            string @string)
        {
            _.VerifyIsNonNullAndNonEmpty(@string);

            var output = @string.First() == character;
            return output;
        }

        /// <summary>
        /// Returns the index of the first occurence of one of the separators, or the index of the last character in the string.
        /// This is useful for specifying the index for a search area.
        /// </summary>
        public static int FirstIndexOfAnyOrLastIndex(this IStringOperator _,
            char[] separators,
            string @string)
        {
            var indexOfAny = @string.IndexOfAny(separators);

            var output = IndexHelper.IsFound(indexOfAny)
                ? indexOfAny
                : @string.LastIndex()
                ;

            return output;
        }

        public static WasFound<int> HasLastIndexOf(this IStringOperator _,
            char character,
            string @string)
        {
            var indexOfLast = @string.LastIndexOf(character);

            var exists = IndexHelper.IsFound(indexOfLast);

            var output = WasFound.From(exists, indexOfLast);
            return output;
        }

        /// <summary>
        /// Tests whether the <paramref name="testString"/> is at least the same length as the <paramref name="referenceString"/>.
        /// </summary>
        public static bool IsAtLeastTheSameLength(this IStringOperator _,
            string testString,
            string referenceString)
        {
            var output = testString.Length >= referenceString.Length;
            return output;
        }

        public static bool IsLengthAtLeast(this IStringOperator _,
            int length,
            string @string)
        {
            var output = @string.Length >= length;
            return output;
        }
                
        public static bool IsNonNullAndNonEmpty(this IStringOperator _,
            string @string)
        {
            var output = !String.IsNullOrEmpty(@string);
            return output;
        }

        public static string Join(this IStringOperator _,
            char separator,
            IEnumerable<string> strings)
        {
            var output = String.Join(
                separator,
                strings);

            return output;
        }

        public static string Join(this IStringOperator _,
            char separator,
            params string[] strings)
        {
            var output = _.Join(
                separator,
                strings.AsEnumerable());

            return output;
        }

        public static string Prefix(this IStringOperator _,
            char prefix,
            string @string)
        {
            var output = _.Prepend(
                prefix,
                @string);

            return output;
        }

        public static string Prefix(this IStringOperator _,
            string prefix,
            string @string)
        {
            var output = _.Prepend(
                prefix,
                @string);

            return output;
        }

        public static string Prepend(this IStringOperator _,
            string prependix,
            string @string)
        {
            var output = prependix + @string;
            return output;
        }

        public static string Prepend(this IStringOperator _,
            char prependix,
            string @string)
        {
            var output = $"{prependix}{@string}";
            return output;
        }

        public static string[] Split(this IStringOperator _,
            string @string,
            char separator)
        {
            var output = @string.Split(separator);
            return output;
        }

        public static bool StartsWith(this IStringOperator _,
            string @string,
            string beginning)
        {
            var output = @string.StartsWith(beginning);
            return output;
        }

        public static string Suffix(this IStringOperator _,
           string @string,
           char suffix)
        {
            var output = _.Append(
                @string,
                suffix);

            return output;
        }

        public static string Suffix(this IStringOperator _,
            string @string,
            string suffix)
        {
            var output = _.Append(
                @string,
                suffix);

            return output;
        }

        public static void VerifyIsNonNullAndNonEmpty(this IStringOperator _,
            string @string)
        {
            var isNonNullAndNonEmpty = _.IsNonNullAndNonEmpty(@string);
            if(!isNonNullAndNonEmpty)
            {
                throw new ArgumentException($"String was null or empty.");
            }
        }
    }
}
