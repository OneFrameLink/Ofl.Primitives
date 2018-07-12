using System;
using System.Runtime.CompilerServices;

namespace Ofl
{
    public static partial class StringExtensions
    {
        public static FormattableString ToFormattableString(this string s)
        {
            // Validate parameters.
            if (s == null) throw new ArgumentNullException(nameof(s));

            // Call the factory and return.
            return FormattableStringFactory.Create(s);
        }
    }
}
