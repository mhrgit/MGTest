namespace MGTest.Core.Modules
{
    public class CalculationModule
    {
        public static decimal GetMarketValue(int holdings, decimal marketPrice)
        {
            return holdings*marketPrice;
        }
    }
}
