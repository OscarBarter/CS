using System;

namespace Sorting_Algorithms
{
    class Other
    {
        static void DisplayMenu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Selection Sort");
            Console.Write("Enter option --> ");
        }
        public static int Menu()
        {
            int option;
            bool validUserInput;
            do
            {
                DisplayMenu();
                validUserInput = int.TryParse(Console.ReadLine(), out option);
            } while (!validUserInput || option < -1 || option > 3);
            return option;
        }
    }
}
