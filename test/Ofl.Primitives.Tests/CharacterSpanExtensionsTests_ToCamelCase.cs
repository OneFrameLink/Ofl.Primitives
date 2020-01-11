using System;
using Xunit;

namespace Ofl.Primitives.Tests
{
    public class CharacterSpanExtensionsTests_ToCamelCase
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("hello", "hello")]
        [InlineData("Hello", "hello")]
        [InlineData("helloThere", "helloThere")]
        [InlineData("HelloThere", "helloThere")]
        public void ToCamelCase(string test, string expected)
        {
            // Create a span.
            ReadOnlySpan<char> original = test;

            // Allocate a new span.
            Span<char> actual = stackalloc char[original.Length];

            // Copy to.
            original.CopyTo(actual);

            // Update.
            actual = actual.ToCamelCase();

            // Compare actual to expected.
            Assert.True(actual.SequenceEqual(expected));
        }
    }
}
