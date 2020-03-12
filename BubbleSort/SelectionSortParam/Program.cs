using System;
namespace SelectionSort
{
    class SelectionSort
    {
        public static int[] Numbers = new int[100];   //declare array as a global variable

        static void Main(string[] args)
        {
            int smallest = 0;
            InitialiseArray();
            Console.WriteLine("Initial array contents are:");
            DisplayArray();
            //doing selection sort ion main program
            //work through the array, finding the smallest and doing the swaps
            for (int i = 0; i < 100; i++)
            {
                FindSmallest(Numbers, i, ref smallest);
                Swap(ref Numbers[smallest], ref Numbers[i]);
            }
            Console.WriteLine("\n\nArray sorted in ascending order is:");// \n means new line
            DisplayArray();
            Console.ReadLine();
        }
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

        public static void InitialiseArray()
        {
            /// initialise the array in reverse order:99 to 0
            for (int n = 0; n <= 99; n++)
            {
                Numbers[n] = 99 - n;
            }
        }

        public static void DisplayArray()
        {
            /// display the array on the screen
            for (int n = 0; n <= 99; n++)
            {
                Console.Write(Convert.ToString(Numbers[n]) + " ");
            }
        }



    }
}


