using System;
using System.Globalization;

namespace Ofl
{
    public static partial class CharacterSpanExtensions
    {
        public static Span<char> ToCamelCaseInvariant(this Span<char> value) => value.ToCamelCase(CultureInfo.InvariantCulture);

        public static Span<char> ToCamelCase(this Span<char> value) => value.ToCamelCase(CultureInfo.CurrentCulture);

        public static Span<char> ToCamelCase(this Span<char> value, CultureInfo cultureInfo)
        {
            // If the length is 0, return.
            if (value.Length == 0) return value;

            // Get the character.
            char firstCharacter = value[0];

            // If lower case already, then get out.
            if (char.IsLower(firstCharacter)) return value;

            // Update.
            value[0] = cultureInfo.TextInfo.ToLower(firstCharacter);

            // Return the span.
            return value;
        }
    }
}
