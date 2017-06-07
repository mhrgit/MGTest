using System;

namespace MGTest.Core.Entities
{
    public class Stock
    {
        private int Holdings { get; }
        private decimal MarketPrice { get; }
        public Portfolio Portfolio { get; set; }

        public decimal Weight => Portfolio != null ? decimal.Round(GetValuationOfPostition()/Portfolio.GetSumOfAllPositions(), 
            2, MidpointRounding.AwayFromZero) * 100 : 0;

        public Stock(int holdings, decimal marketPrice)
        {
            Holdings = holdings;
            MarketPrice = marketPrice;
        }

        public decimal GetValuationOfPostition()
        {
            return decimal.Round(Holdings*MarketPrice, 2, MidpointRounding.AwayFromZero);
        }
    }
}
