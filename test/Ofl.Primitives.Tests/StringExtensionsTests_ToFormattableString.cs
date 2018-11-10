using System;
using Xunit;

namespace Ofl.Primitives.Tests
{
    public class StringExtensionsTests_ToFormattableString
    {
        [Fact]
        public void ToFormattableString_Throws_Null()
        {
            // Expect argument null exception.
            Assert.Throws<ArgumentNullException>("s", () => {
                // Try on null.
                ((string) null).ToFormattableString();
            });
        }
    }
}
