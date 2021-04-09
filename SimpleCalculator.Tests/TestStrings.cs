using SimpleCalculator.Controllers;
using System;
using Xunit;

namespace SimpleCalculator.Tests
{
    public class TestStrings
    {
        [Fact]
        public void FirstCalculationShouldBeAddedToArray()
        {
            var validationAttribute = new SaveLastFiveCalculations();

            string[] addOperationString = validationAttribute.SaveCalculations(new string[5], "2", "3", "Add", "5");

            Assert.NotNull(addOperationString[0]);

        }

        [Theory]
        [InlineData(new string[] { "1 + 1 = 2", "2 + 1 = 3", "3 + 1 = 4", "7 + 1 = 8", null },"1","5","Add","6", new string[] {"1 + 1 = 2", "2 + 1 = 3", "3 + 1 = 4", "7 + 1 = 8" ,"1 + 5 = 6"})]
        [InlineData(new string[] { "1 * 1 = 1", "2 * 1 = 2", "3 * 1 = 3", "7 * 1 = 7" , null},"4","5","Multiplication","20",new string[] { "1 * 1 = 1", "2 * 1 = 2", "3 * 1 = 3", "7 * 1 = 7", "4 * 5 = 20"})]
        [InlineData(new string[] { "1 + 1 = 2", "2 / 1 = 2", "3 - 1 = 2", "7 * 1 = 7", null },"10","2", "Division", "5", new string[] { "1 + 1 = 2", "2 / 1 = 2", "3 - 1 = 2", "7 * 1 = 7", "10 / 2 = 5" })]
        [InlineData(new string[] { "1 + 1 = 2", "2 / 1 = 2", "3 - 1 = 2", null, null },"1","7","Substract","-6",new string[] { "1 + 1 = 2", "2 / 1 = 2", "3 - 1 = 2", "1 - 7 = -6", null })]
        public void FiveCalculationsShouldBeAddedToArray(string[] fiveCalcs, string firstNum, string secondNum, string operation, string result, string[] expected)
        {
            var validationAttibute = new SaveLastFiveCalculations();

            string[] FiveCalculations = validationAttibute.SaveCalculations(fiveCalcs, firstNum,secondNum,operation,result);

            Assert.Equal(expected, FiveCalculations);
        }

        
    }
}
