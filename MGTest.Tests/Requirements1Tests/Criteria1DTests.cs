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
    public class Criteria1DTests
    {
        [Test]
        public void Should_Return_Correct_Weight_When_Portfolio_And_Stock_Provided()
        {
            var stock1 = new Stock(100, 5);
            var stock2 = new Stock(50, 2);
            var stock3 = new Stock(20, 10);

            var stocks = new List<Stock> {stock1, stock2, stock3};
            var cash = 12000;

            var portfolio = new Portfolio(stocks, cash);
            stock1.Portfolio = portfolio;
            stock2.Portfolio = portfolio;
            stock3.Portfolio = portfolio;

            var expectedStock1Weight = 63;
            var result = stock1.Weight;

            Assert.AreEqual(expectedStock1Weight, result);
        }

        [Test]
        public void Should_Return_Zero_Weight_When_Portfolio_Is_Not_Provided()
        {
            var stock = new Stock(100, 5);

            var expectedStock1Weight = 0;
            var result = stock.Weight;

            Assert.AreEqual(expectedStock1Weight, result);
        }

        [Test]
        public void Should_Return_Correct_Weight_When_Stock_Provided_with_Decimal_Points()
        {
            var stock1 = new Stock(100, 5.5m);
            var stock2 = new Stock(55, 2.435m);
            var stock3 = new Stock(20, 10.9898m);

            var stocks = new List<Stock> { stock1, stock2, stock3 };
            var cash = 12000;

            var portfolio = new Portfolio(stocks, cash);
            stock1.Portfolio = portfolio;
            stock2.Portfolio = portfolio;
            stock3.Portfolio = portfolio;

            var expectedStock1Weight = 61;
            var result = stock1.Weight;

            Assert.AreEqual(expectedStock1Weight, result);
        }
    }
}
