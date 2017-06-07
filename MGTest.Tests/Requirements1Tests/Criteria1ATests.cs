using MGTest.Core.Modules;
using MGTest.Core.Entities;
using NUnit.Framework;

namespace MGTest.Tests.Requirements1Tests
{
    [TestFixture]
    public class Criteria1ATests
    {
        [Test]
        public void Should_Return_Correct_Valuation_Of_The_Position_When_Holding_And_Market_Price_Provided()
        {
            var holdings = 200;
            var marketPrice = 1.2m;
            var stock = new Stock(holdings, marketPrice);
            var expectedResult = 240m;
            decimal result =stock.GetValuationOfPostition();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_Return_Correct_Valuation_Of_The_Position_When_Holding_Is_Zero()
        {
            var holdings = 200;
            var marketPrice = 0m;
            var stock = new Stock(holdings, marketPrice);
            var expectedResult = 0m;
            decimal result = stock.GetValuationOfPostition();

            Assert.AreEqual(expectedResult, result);
        }
    }
}
