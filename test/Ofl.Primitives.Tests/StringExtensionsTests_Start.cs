using System;
using System.Linq;
using Xunit;

namespace Ofl.Primitives.Tests
{
    public class StringExtensionsTests_Left
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(5)]
        public void Test_Start_Null_Returns_Null(int count)
        {
            // Validate the parameters.
            if (count < 0) throw new ArgumentOutOfRangeException(nameof(count), count,
                $"The {nameof(count)} parameter must be a non-negative value.");

            // Null returns null.
            Assert.Null(((string) null).Start(count));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(1, 0)]
        [InlineData(1, 1)]
        [InlineData(1, 10)]
        [InlineData(5, 0)]
        [InlineData(5, 3)]
        [InlineData(5, 5)]
        [InlineData(5, 10)]
        public void Test_Start(int stringLength, int count)
        {
            // Validate the parameters.
            if (stringLength < 0) throw new ArgumentOutOfRangeException(nameof(stringLength), stringLength,
                $"The {nameof(stringLength)} parameter must be a non-negative value.");
            if (count < 0) throw new ArgumentOutOfRangeException(nameof(count), count,
                $"The {nameof(count)} parameter must be a non-negative value.");

            // Create a string
            // 0123456789 repeating (to count)
            string value = new string(Enumerable.Range(0, stringLength).Select(i => (i % 10).ToString()[0]).ToArray());

            // The start string.
            string start = value.Start(count);

            // Compare the lengths.
            Assert.Equal(Math.Min(stringLength, count), start.Length);

            // Are the values equal?
            string expected = new string(value.Take(count).ToArray());

            // Compare.
            Assert.Equal(expected, start);
        }
    }
}
