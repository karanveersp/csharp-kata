using System;
using Xunit;
using Xunit.Abstractions;

namespace Kata.Test
{
    public class KataTest
    {
        private readonly ITestOutputHelper output;

        public KataTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void moveZeroes1()
        {
            var input = new int[] {1, 2, 0, 3, 0, 4};
            var expected = new int[] {1, 2, 3, 4, 0, 0};
            var actual = Kata.MoveZeroes(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void moveZeroes2()
        {
            Assert.Equal(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}, Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
        }
    }
}