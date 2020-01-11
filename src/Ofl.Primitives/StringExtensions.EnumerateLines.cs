using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Ofl
{
    public static partial class StringExtensions
    {
        public static IEnumerable<string> EnumerateLines(this string value)
        {
            // Validate parameters.
            if (value == null) throw new ArgumentNullException(nameof(value));

            // The implementation
            IEnumerable<string> Implementation() { 
                // The line.
                string line;

                // Create a string reader.
                using (var reader = new StringReader(value))
                // While there is a line.
                while ((line = reader.ReadLine()) != null)
                    // Yield the line.
                    yield return line;
            }

            // Return the implementation.
            return Implementation();
        }
    }
}
