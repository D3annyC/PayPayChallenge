using System;
using System.IO;

namespace PayPay
{
    public static class BinarySummary
    {
        // static void Main(string[] args)
        // {
        //     var result = GetBinarySummary("11010,00101001");
        //     result = (result.Substring(0, 1) == "0") ? result.Substring(1) : result;

        // }

        private static string GetBinarySummary(string input)
        {
            var arBinary = input.Split(",");
            var a = arBinary[0];
            var b = arBinary[1];

            if (a.Length < b.Length)
            {
                var c = a;
                a = b;
                b = c;
            }

            var sum = new char[a.Length + 1];
            var carry = false;

            for (int i = a.Length - 1, j = b.Length - 1, k = sum.Length - 1; i >= 0; i--, j--, k--)
            {
                var x = a[i];
                var y = (j >= 0) ? b[j] : '0';

                if (carry)
                {
                    sum[k] = (x == y) ? '1' : '0';
                    carry = (x == '1' || y == '1');
                }
                else
                {
                    sum[k] = (x == y) ? '0' : '1';
                    carry = (x == '1' && y == '1');
                }
            }

            if (carry)
            {
                sum[0] = '1';
                return new string(sum);
            }

            return new string(sum, 1, sum.Length - 1);
        }
    }
}
