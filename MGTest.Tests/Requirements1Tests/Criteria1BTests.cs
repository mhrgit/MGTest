using MGTest.Core.Entities;
using NUnit.Framework;

namespace MGTest.Tests.Requirements1Tests
{
    [TestFixture]
    public class Criteria1BTests
    {
        [Test]
        public void Should_Return_Correct_Cash_Value_When_Cash_Is_Provided_In_Pennis()
        {
            var cash = 12300;
            var portfolio = new Portfolio(null, cash);
            var expectedResult = 123m;
            decimal result = portfolio.GetCashValue();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_Return_Correct_Cash_Value_When_Cash_Is_Provided_In_Pennis_And_Has_Decimal_Points()
        {
            var cash = 123.12m;
            var portfolio = new Portfolio(null, cash);
            var expectedResult = 1.23m;
            decimal result = portfolio.GetCashValue();

            Assert.AreEqual(expectedResult, result);
        }
    }
}
