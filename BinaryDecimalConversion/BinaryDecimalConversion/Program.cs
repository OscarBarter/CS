using System;

namespace BinaryDecimalConversion
{
    class Program
    {
        static void DisplayMenu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Decimal to Binary");
            Console.WriteLine("2. Binary to Decimal");
            Console.Write("Enter option --> ");
        }
        static int Menu()
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
        static void DecimalToBinary()
        {
            Console.WriteLine("Enter the decimal integer to be converted: ");
            int Decimal = Convert.ToInt32(Console.ReadLine());
            int bit;
            string result = "";
            while (Decimal > 0)
            {
                bit = Decimal % 2;
                result = bit.ToString() + result;
                Decimal = Decimal / 2;
            }
            Console.WriteLine("The binary equivalent is " + result);
        }
        static void BinaryToDecimal()
        {
            Console.WriteLine("Enter the binary integer to be converted: ");
            string binary = (Console.ReadLine());
            int result = 0;
            int power = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    result = result + power;
                }
                power = power * 2;
            }
            Console.WriteLine("The decimal equivalent is " + result);
        }
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                int option;
                option = Menu();
                if (option == 1)
                {
                    DecimalToBinary();
                }
                else if (option == 2)
                {
                    BinaryToDecimal();
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
