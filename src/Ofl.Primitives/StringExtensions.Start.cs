using System;

namespace Ofl
{
    public static partial class StringExtensions
    {
        public static string? Start(this string? value, int count)
        {
            // Validate parameters.
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), count,
                    $"The {nameof(count)} parameter must be a non-negative number.");

            // If null, return null.
            if (value == null) return null;

            // If the length is 0 or the count is zero, return empty.
            if (value.Length == 0 || count == 0) return string.Empty;

            // If the count is greater than or equal the length of the string, return
            // the string.
            if (count >= value.Length) return value;

            // Substring.
            return value.Substring(0, count);
        }
    }
}
