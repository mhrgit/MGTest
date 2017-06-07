using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGTest.Core.Entities;
using NUnit.Framework;

namespace MGTest.Tests.Requirements1Tests
{
    [TestFixture]
    public class Criteria1CTests
    {
        [Test]
        public void Should_Return_Correct_Sum_Of_Portfolio_Valuation()
        {
            var stocks = new List<Stock>()
            {
                new Stock(100, 5),
                new Stock(50, 2),
                new Stock(20, 10)
            };

            var cash = 12000;

            var portfolio = new Portfolio(stocks, cash);
            var expectedResult = 800;
            var result = portfolio.GetSumOfAllPositions();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_Return_Correct_Sum_Of_Portfolio_Valuation_When_Stock_Values_Have_Decimal_Points()
        {
            var stocks = new List<Stock>()
            {
                new Stock(100, 5.5m),
                new Stock(55, 2.435m),
                new Stock(20, 10.9898m)
            };

            var cash = 12000;

            var portfolio = new Portfolio(stocks, cash);
            var expectedResult = 903.73;
            var result = portfolio.GetSumOfAllPositions();

            Assert.AreEqual(expectedResult, result);
        }
    }
}
