using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Ofl
{
    //////////////////////////////////////////////////
    ///
    /// <author>Nicholas Paldino</author>
    /// <created>2012-12-01</created>
    /// <summary>Extensions for the <see cref="String"/>
    /// class in .NET.</summary>
    ///
    //////////////////////////////////////////////////
    public static partial class StringExtensions
    {
        public static IEnumerable<string> EnumerateLines(this string value)
        {
            // Validate parameters.
            if (value == null) throw new ArgumentNullException(nameof(value));

            // Pass the implementation.
            return value.EnumerateLinesImplementation();
        }

        private static IEnumerable<string> EnumerateLinesImplementation(this string value)
        {
            // Validate parameters.
            Debug.Assert(value != null);

            // The line.
            string line;

            // Create a string reader.
            using (var reader = new StringReader(value))
            // While there is a line.
            while ((line = reader.ReadLine()) != null)
            {
                // Yield the line.
                yield return line;
            }
        }
    }
}
