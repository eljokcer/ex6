using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[5] { 3, 8, 11, 17, 1 };
            Console.WriteLine(Max(values));
        }
        static int Max(int[] values)
        {
            int num = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (num < values[i])
                {
                    num = values[i];
                }
            }
            return num;
        }
    }
}
