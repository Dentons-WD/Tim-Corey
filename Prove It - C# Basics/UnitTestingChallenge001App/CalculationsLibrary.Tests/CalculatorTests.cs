using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculationsLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_SimpleAddition()
        {
            double expected = 18;

            double actual = Calculator.Add(15,3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_SimpleDivision()
        {
            double expected = 5;

            double actual = Calculator.Divide(15,3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_FailOnDivideByZero()
        {
            Assert.Throws<ArgumentException>(() => Calculator.Divide(15,0));
        }

        [Fact]
        public void LimitedAdd_SimpleAddition()
        {
            double expected = 18;

            double actual = Calculator.LimitedAdd(15,3, 0, 100);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LimitedAdd_BelowMinimum()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.LimitedAdd(15,3, 10, 100));
        }

        [Fact]
        public void LimitedAdd_AboveMaximum()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.LimitedAdd(15,3, 1, 10));
        }
    }
}
