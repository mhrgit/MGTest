using System;

namespace MGTest.Core.Modules
{
    public class CalculationModule
    {
        public static decimal GetCashValue(decimal cash)
        {
            return decimal.Round(cash/100, 2, MidpointRounding.AwayFromZero);
        }
    }
}
