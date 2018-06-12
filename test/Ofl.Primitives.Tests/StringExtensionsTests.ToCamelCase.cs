using Xunit;

namespace Ofl.Primitives.Tests
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("hello", "hello")]
        [InlineData("Hello", "hello")]
        [InlineData("helloThere", "helloThere")]
        [InlineData("HelloThere", "helloThere")]
        public void ToCamelCase(string test, string expected)
        {
            // Compare actual to expected.
            Assert.Equal(expected, test.ToCamelCase());
        }
    }
}
