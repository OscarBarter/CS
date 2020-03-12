using System;

namespace Error_Checking
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = Menu();

            if (option == 1)
            {
                Error_Checking_functions.Check_Digit.Check_digit();
            }
            else if (option == 2)
            {
                Error_Checking_functions.parity.Parity();
            }
            else if (option == 3)
            {
                Error_Checking_functions.Majority_Voting.MajorityVoting();
            }

        }


        static int Menu()
        {
            int option;
            bool validUserInput;
            do
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Check Digit");
                Console.WriteLine("2. Parity Bit");
                Console.WriteLine("3. Majority Voting");

                validUserInput = int.TryParse(Console.ReadLine(), out option);
            } while (!validUserInput || option < -1 || option > 4);
            return option;
        }
    }
}
