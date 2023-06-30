using CalculationsLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorLibrary.Tests
{
    public class Calculator_Tests
    {
        [Theory]
        [InlineData(5, 4, 9)]
        [InlineData(8, 3, 11)]
        [InlineData(1.25, 3.6, 4.85)]
        public void Add_StandardTest(double x, double y, double expected)
        {
            double actual = Calculator.Add(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 6, 0.5)]
        [InlineData(6, 2, 3)]
        public void Divide_StandardTest(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_InvalidData_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => Calculator.Divide(6, 0));
        }

        [Theory]
        [InlineData(5, 4, 1, 10, 9)]
        [InlineData(8, 3, 1, 10, 11)]
        [InlineData(1.25, 3.6, 1, 10, 4.85)]
        public void LimitedAdd_StandardTest(double x, double y,
            double min, double max, double expected)
        {
            double actual = Calculator.LimitedAdd(x, y, min, max);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-2, 6, 1, 10, "x")]
        [InlineData(5, 11, 1, 10, "y")]
        public void LimitedAdd_OutOfRangeParameters_ShouldThrowException(
            double x, double y, double min, double max, string badVariable)
        {
            Assert.Throws<ArgumentOutOfRangeException>(badVariable,
                () => Calculator.LimitedAdd(x, y, min, max));
        }
    }
}
