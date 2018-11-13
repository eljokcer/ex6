using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 9, 5, 1, 4, 7, 3, 8 };
            PrintArr(nums);
            BubbleSort(nums);
            PrintArr(nums);
        }


        static void BubbleSort(int[] nums)
        {

            int temp;
            for (int i = 0; i <= nums.Length; i++)
            {
                for (int j = 0; j <= nums.Length - i; j++)
                {
                    if (nums[j + 1] < nums[j])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
        static void PrintArr(int[] arr)
        {
            Console.Write("\nArray Values:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + ", ");
            }
            Console.WriteLine("\b\b");
        }
    }
}


