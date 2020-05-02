using System;
using System.IO;
using System.Collections.Generic;

namespace PayPay
{
    public static class CashRegister
    {
        static void Main(string[] args)
        {
            var result = GetChange("15.94;16.00");
        }

        private static string GetChange(string input)
        {
            var DicCurrency = new Dictionary<double, string>(){
                {0.01,"PENNY"},

            };
            DicCurrency.Add(0.01, "PENNY");
            DicCurrency.Add(0.05, "NICKEL");
            DicCurrency.Add(0.10, "DIME");
            DicCurrency.Add(0.25, "QUARTER");
            DicCurrency.Add(0.50, "HALF DOLLAR");
            DicCurrency.Add(1.00, "ONE");
            DicCurrency.Add(2.00, "TWO");
            DicCurrency.Add(5.00, "FIVE");
            DicCurrency.Add(10.00, "TEN");
            DicCurrency.Add(20.00, "TWENTY");
            DicCurrency.Add(50.00, "FIFTY");
            DicCurrency.Add(100, "ONE HUNDRED");
            double[] coins = { 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };

            var deal = input.Split(";");
            var PP = Convert.ToDecimal(deal[0]);
            var CH = Convert.ToDecimal(deal[1]);

            if (PP > CH)
            {
                return "ERROR";
            }
            else if (PP == CH)
            {
                return "ZERO";
            }
            else
            {
                var strChange = string.Empty;
                var change = Convert.ToDouble(CH - PP);
                var count = 0.0;
                for (int i = 0; i < coins.Length; i++)
                {
                    if (coins[i] <= change)
                    {
                        count = change / coins[i];
                        if (count != 0)
                        {
                            strChange += "," + DicCurrency[coins[i]];
                        }
                        change = Convert.ToDouble(Convert.ToDecimal(change % coins[i]));
                    }

                }
                return strChange.Substring(1);
            }
        }

    }
}
