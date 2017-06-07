using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MGTest.Core.Entities
{
    public class Portfolio
    {
        private IEnumerable<Stock> Stocks { get; set; }
        private decimal Cash { get; set; }

        public Portfolio(IEnumerable<Stock> stocks, decimal cash)
        {
            Stocks = stocks;
            Cash = cash;
        }

        public decimal GetSumOfAllPositions()
        {
            return Stocks.Sum(stock => stock.GetValuationOfPostition());
        }

        public decimal GetCashValue()
        {
            return decimal.Round(Cash / 100, 2, MidpointRounding.AwayFromZero);
        }
    }

}
