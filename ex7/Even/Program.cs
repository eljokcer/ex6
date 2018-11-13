using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(FilterEvens(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
        }

        static void PrintArray(int[] nums)
        {
            Console.WriteLine("\nArray:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i] + ", ");
            }
            Console.WriteLine();
        }

        static int[] FilterEvens(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] evenNums = new int[count];


            for (int i = 0, j = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNums[j++] = numbers[i];
                }
            }
            return evenNums;
        }
    }
}
