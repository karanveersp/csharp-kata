using System;
using Xunit;

namespace Kata.Test
{
    public class AppTest
    {
        [Fact]
        public void ReturnsGreetingWithName()
        {
            string expected = "Hello, Scott!";
            string actual = App.GetGreeting("Scott");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EmptyStringReturnsBub()
        {
            string expected = "Hello, bub";
            string actual = App.GetGreeting("");
            Assert.Equal(expected, actual);
        }

    }
}
