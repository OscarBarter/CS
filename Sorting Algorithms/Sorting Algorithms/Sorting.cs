using System;

namespace Sorting_Algorithms
{
    class Sorting
    {
        public static void FindSmallest(int[] Nums, int i, ref int smallest)
        {
            /* find which element in the array Nums is the smallest, starting at Nums[i].
             On completion, smallest will be the index of the smallest value */

            smallest = i;
            for (int current = smallest; current < Nums.Length; current++)
            {
                if (Nums[current] < Nums[smallest])
                {
                    smallest = current;
                }
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            //swap the values of a and b
            int temp = a;
            a = b;
            b = temp;
        }

        public static void InitialiseArray(int[] numbers)
        {
            int i;
            for (i = 0; i <= 99; i++)
            {

                numbers[i] = 100 - i;
            }
        }
        public static void DisplayArray(int[] numbers)
        {
            int i;
            Console.WriteLine("Array contents are:");
            for (i = 0; i <= 99; i++)
            {
                Console.Write(Convert.ToString(numbers[i]) + " ");
            }
            Console.WriteLine();
        }
    }
}
