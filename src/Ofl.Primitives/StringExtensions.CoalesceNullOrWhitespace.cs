using System;
using System.Collections.Generic;
using System.Linq;

namespace Ofl
{
    public static partial class StringExtensions
    {
        public static string CoalesceNullOrWhitespace(params string[] strings)
        {
            // Validate parameters.
            if (strings == null) throw new ArgumentNullException(nameof(strings));

            // Call the overload.
            return strings.CoalesceNullOrWhitespace();
        }

        public static string CoalesceNullOrWhitespace(this IEnumerable<string> strings)
        {
            // Validate parameters.
            if (strings == null) throw new ArgumentNullException(nameof(strings));

            // Return the first non null or non whitespace string.
            return strings.FirstOrDefault(s => !string.IsNullOrWhiteSpace(s));
        }
    }
}
