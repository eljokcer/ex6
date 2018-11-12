using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] MonthlyGain = new double[4] { -0.72, 1.05, 0.76, 1.49 };
            string[] Symbols = new string[4] { "MSFT", "INTC", "CSCO", "GOOG" };
            Console.WriteLine(MonthlyMax(MonthlyGain, Symbols));
        }

        static string MonthlyMax(double[] MonthlyGain, string[] Symbols)
        {
            return Symbols[MaxIndex(MonthlyGain)];
        }

        static int MaxIndex(double[] nums)
        {
            double num = nums[0];
            int index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (num < nums[i])
                {
                    num = nums[i];
                    index = i;
                }
            }
        }
    }
}
