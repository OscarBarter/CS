using System;
//using System.Collections.Generic;
//using System.Text;

namespace BaseToBase
{
    class Other
    {
        public static void DisplayMainMenu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Decimal to Base(2-10)");
            Console.WriteLine("2. Binary to Decimal");
            Console.WriteLine("3. 2s complement Binary to Decimal");
            Console.WriteLine("4. Decimal to 16-bit 2s complement Binary");
            Console.WriteLine("5. ");
            Console.Write("Enter option --> ");
        }

        public static void DisplayMenu2()
        {
            Console.WriteLine("Enter the base(1 to 9) you want to convert to");
            Console.Write("Enter option --> ");
        }
        public static int MainMenu()
        {
            int option;
            bool validUserInput;
            do
            {
                DisplayMainMenu();
                validUserInput = int.TryParse(Console.ReadLine(), out option);
            } while (!validUserInput || option < -1 || option > 5);
            /*
            if (option == 2)
            {
                option = -1;
            }
            else if (option == 0)
            {
                return 0;
            }
            if (option == 1)
            {
                do
                {
                    DisplayMenu2();
                    validUserInput = int.TryParse(Console.ReadLine(), out option);
                } while (!validUserInput || option < -1 || option > 10);

            }
            */

            return option;
        }
        /*
        public static int[] selections(int options)
        {
            int[] selections = new int[2];
            if (options == 0)
            {
                selections[0] = 0;
            }
            else if (options == -1)
            {
                selections[0] = 1;
                selections[1] = 2;
            }
            else
            {
                selections[0] = 2;
                selections[1] = options;
            }
            return selections;
        }*/

        public static int BaseSelection()
        {
            int option;
            bool validUserInput;
            do
            {
                DisplayMenu2();
                validUserInput = int.TryParse(Console.ReadLine(), out option);
            } while (!validUserInput || option < -1 || option > 10);
            return option;
        }
    }
}
