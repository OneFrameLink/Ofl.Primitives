using System;
using System.Globalization;

namespace Ofl
{
    public static partial class StringExtensions
    {
        public static string ToCamelCaseInvariant(this string value) => value.ToCamelCase(CultureInfo.InvariantCulture);

        public static string ToCamelCase(this string value) => value.ToCamelCase(CultureInfo.CurrentCulture);

        public static string ToCamelCase(this string value, CultureInfo cultureInfo)
        {
            // If null, throw an exception.
            if (value == null) throw new ArgumentNullException(nameof(value));

            // If the length is 0, return.
            if (value.Length == 0) return value;

            // Get the character.
            char firstCharacter = value[0];

            // If lower case, then get out.
            if (char.IsLower(firstCharacter)) return value;

            // Create a new string.
            return string.Create(value.Length, 0, (s, _) => {
                // Replace the first character.
                s[0] = cultureInfo.TextInfo.ToLower(firstCharacter);

                // Copy the rest of the string.
                value.AsSpan().Slice(1).CopyTo(s.Slice(1));
            });
        }
    }
}
