using System;
using Sorting_Algorithms;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            bool exit = false;
            do
            {
                int option;
                option = Other.Menu();
                if (option == 1)
                {
                    SortingAlgs.BubbleSort(numbers);
                }
                else if (option == 2)
                {
                    SortingAlgs.SelectionSort(numbers);
                }
                else
                {
                    exit = true;
                    Console.WriteLine("Bye");
                }
            } while (exit == false);

        }
    }
}