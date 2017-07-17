using System;
using System.Collections.Generic;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 3)]
        [InlineData(5, 3)]
        [InlineData(2, 2)]
        public void AddTwoIntegers(int a, int b)
        {
            // Given this input to the method
            int sum = _calculator.Add(a, b);

            // We are asserting that the output should be this
            Assert.Equal(sum, a+b);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 3)]
        [InlineData(5, 3)]
        [InlineData(2, 2)]
        public void MultiplyTwoIntergers(int a, int b)
        {
            int product = _calculator.Multiply(a, b);

            Assert.Equal(product, a*b);
        }
    }
}