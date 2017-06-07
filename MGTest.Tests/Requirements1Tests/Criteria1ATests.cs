using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGTest.Core.Modules;
using NUnit.Framework;

namespace MGTest.Tests.Requirements1Tests
{
    [TestFixture]
    public class Criteria1Tests
    {
        [Test]
        public void Should_Return_Correct_Valuation_Of_The_Position_When_Holding_And_Market_Price_Provided()
        {
            var holdings = 200;
            var marketPrice = 1.2m;

            var expectedResult = 240m;
            decimal result = CalculationModule.GetMarketValue(holdings, marketPrice);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_Return_Correct_Valuation_Of_The_Position_When_Holding_Is_Zero()
        {
            var holdings = 200;
            var marketPrice = 0m;

            var expectedResult = 0m;
            decimal result = CalculationModule.GetMarketValue(holdings, marketPrice);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
