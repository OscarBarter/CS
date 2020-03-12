using System;
using Sorting_Algorithms;

namespace Sorting_Algorithms
{
    class SortingAlgs
    {

        public static void SelectionSort(int[] Numbers)
        {
            int smallest = 0;
            Sorting.InitialiseArray(Numbers);
            Sorting.DisplayArray(Numbers);
            for (int i = 0; i < 100; i++)
            {
                Sorting.FindSmallest(Numbers, i, ref smallest);
                Sorting.Swap(ref Numbers[smallest], ref Numbers[i]);
            }
            Sorting.DisplayArray(Numbers);
            Console.ReadLine();
        }

        public static void BubbleSort(int[] numbers)
        {
            Sorting.InitialiseArray(numbers);
            Sorting.DisplayArray(numbers);
            int current = 99;
            int i;
            bool swapped;
            do
            {
                swapped = false;
                for (i = 0; i <= current - 1; i += 1)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Sorting.Swap(ref numbers[i], ref numbers[i + 1]);
                    }
                }
                current = current - 1;
            }
            while (!(swapped == false));
            Sorting.DisplayArray(numbers);
            Console.ReadLine();
        }
    }
}


