using System;
using System.Collections.Generic;
using System.Linq;

namespace Guessing_Game_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and Initialise Variables
            //bool QFound = false; // variable for if the number is found
            int number; //for the users number
            //int i = 0; // counter
            //int useful = 0; //used for a number that gets used a lot in the binary search
            int menu = 0; //for use in the menu system

            while (menu != 3)
            {
                //get users number
                Console.Write("Enter your number -->");
                number = int.Parse(Console.ReadLine());

                //menu
                Console.Write("1 for linear, 2 for binary, 3 for exit --> ");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    int value = LinearSearch(number);
                    Console.WriteLine(value);
                }
                else if (menu == 2)
                {
                    int value = BinSearch(number);
                    Console.WriteLine(value);
                }
            }
        }
        static int BinSearch(int number)
        {
            int useful = 0; //used for a number that gets used a lot in the binary search
            bool QFound = false; // variable for if the number is found
            int i = 0; // counter


            //binary search
            List<int> intList = new List<int>();
            intList = Enumerable.Range(0, 101).ToList();
            while (QFound == false)
            {
                useful = intList[(intList.Count) / 2];
                Console.WriteLine("value checking" + useful);
                if (useful == number)
                {
                    Console.WriteLine("is " + useful);
                    QFound = true;
                }
                else if (useful < number)
                {
                    Console.WriteLine("It is smaller than the number");
                    for (i = 0; i < (intList.Count) / 2; i++)
                    {
                        intList.RemoveAt(0);
                    }
                }
                else
                {
                    Console.WriteLine("It is larger than the number");
                    for (i = 0; i < (intList.Count) / 2; i++)
                    {
                        intList.RemoveAt((intList.Count) - 1);
                    }
                }
            }
            return useful;
        }
        static int LinearSearch(int number)
        {
            int i = 0; // counter
            bool QFound = false; // variable for if the number is found

            while (QFound == false)
            {
                if (i == number)
                {
                    Console.WriteLine("is" + i);
                    QFound = true;
                }
                else
                {
                    Console.WriteLine("not" + i);
                    i++;
                }
            }
            return i;
        }
    }
}