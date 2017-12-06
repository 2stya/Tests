using System;
using System.Linq;
using System.Net;
using Unit;
using Xunit;

namespace Unit.Tests
{
    public class UnitTest1
    {
        private static FizzBuzz fizzBuzz;
        public UnitTest1()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Fact]
        public void ReturnBuzzFizzIfInputDividesBy3And5()
        {
            string expected = "FizzBuzz";
            string output = fizzBuzz.GetOutput(15);

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ReturnBuzzFizzIfInputNotDividesBy3Nor5()
        {
            string expected = "2";
            string output = fizzBuzz.GetOutput(2);

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ReturnBuzzFizzIfInputDividesBy3ButNot5()
        {
            string expected = "Fizz";
            string output = fizzBuzz.GetOutput(9);

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ReturnBuzzFizzIfInputDividesBy5ButNot3()
        {
            string expected = "Buzz";
            string output = fizzBuzz.GetOutput(10);

            Assert.Equal(expected, output);
        }

    }
}
