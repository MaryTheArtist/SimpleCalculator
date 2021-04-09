using SimpleCalculator.Controllers;
using System;
using Xunit;

namespace SimpleCalculator.Tests
{
    public class TestCalculations
    {
        [Theory]
        [InlineData(2, 5, "Add", 7)]
        [InlineData(-2, 5, "Add", 3)]
        [InlineData(2, -5, "Add", -3)]
        [InlineData(-2, -5, "Add", -7)]
        [InlineData(2.5, 5.3, "Add", 7.8)]
        [InlineData(-2.5, 5.3, "Add", 2.8)]
        [InlineData(2.5, -5.3, "Add", -2.8)]
        [InlineData(-2.5, -5.3, "Add", -7.8)]
        public void AdditionCalculations(double firstNum, double secondNum, string operationType, double expectedResult)
        {
            var validationAttribute = new Calculations();

            double result = validationAttribute.Calculate(firstNum, secondNum, operationType);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(6, 3, "Substract", 3)]
        [InlineData(-6, 3, "Substract", -9)]
        [InlineData(6, -3, "Substract", 9)]
        [InlineData(-6, -3, "Substract", -3)]
        [InlineData(6.5, 3.2, "Substract", 3.3)]
        [InlineData(-6.5, 3.2, "Substract", -9.7)]
        [InlineData(6.5, -3.2, "Substract", 9.7)]
        [InlineData(-6.5, -3.2, "Substract", -3.3)]
        public void SubstractCalculations(double firstNum, double secondNum, string operationType, double expectedResult)
        {
            var validationAttribute = new Calculations();

            double result = validationAttribute.Calculate(firstNum, secondNum, operationType);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(4, 8, "Multiplication", 32)]
        [InlineData(-4, 8, "Multiplication", -32)]
        [InlineData(4, -8, "Multiplication", -32)]
        [InlineData(-4, -8, "Multiplication", 32)]
        [InlineData(4.3, 8.8, "Multiplication", 37.84)]
        [InlineData(-4.3, 8.8, "Multiplication", -37.84)]
        [InlineData(4.3, -8.8, "Multiplication", -37.84)]
        [InlineData(-4.3, -8.8, "Multiplication", 37.84)]
        public void MultiplicationCalculations(double firstNum, double secondNum, string operationType, double expectedResult)
        {
            var validationAttribute = new Calculations();

            double result = validationAttribute.Calculate(firstNum, secondNum, operationType);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(9, 7, "Division", 1.2857142857142858)]
        [InlineData(-9, 7, "Division", -1.2857142857142858)]
        [InlineData(9, -7, "Division", -1.2857142857142858)]
        [InlineData(-9, -7, "Division", 1.2857142857142858)]
        [InlineData(9.4, 7.2, "Division", 1.3055555555555556)]
        [InlineData(-9.4, 7.2, "Division", -1.3055555555555556)]
        [InlineData(9.4, -7.2, "Division", -1.3055555555555556)]
        [InlineData(-9.4, -7.2, "Division", 1.3055555555555556)]
        public void DivisionCalculations(double firstNum, double secondNum, string operationType, double expectedResult)
        {
            var validationAttribute = new Calculations();

            double result = validationAttribute.Calculate(firstNum, secondNum, operationType);

            Assert.Equal(expectedResult, result);
        }
    }
}
