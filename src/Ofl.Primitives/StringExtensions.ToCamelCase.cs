using System;
using System.Globalization;
using System.Text;

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

            // Create a string builder.
            var builder = new StringBuilder(value);

            // Replace.
            builder[0] = cultureInfo.TextInfo.ToLower(firstCharacter);

            // Compute.
            return builder.ToString();
        }
    }
}
