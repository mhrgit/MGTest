using System;

namespace MGTest.Core.Entities
{
    public class Stock
    {
        private int Holdings { get; set; }
        private decimal MarketPrice { get; set; }
        private decimal Weight { get; set; }

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
