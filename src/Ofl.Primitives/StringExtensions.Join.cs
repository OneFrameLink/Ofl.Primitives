using System;
using System.Collections.Generic;

namespace Ofl
{
    public static partial class StringExtensions
    {
        public static string Join(this IEnumerable<string> values, string? separator)
        {
            // Validate parameters.
            if (values == null) throw new ArgumentNullException(nameof(values));

            // NOTE: Don't check separator, as Join has specific rules around that.

            // Join.
            return string.Join(separator, values);
        }
    }
}
