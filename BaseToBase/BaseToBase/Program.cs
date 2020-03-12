using System;
using BaseToBase;

namespace BaseToBase {
    class Program
    {
        static void Main(string[] args)
        {
            int option = Other.MainMenu();
            //int[] selection = new int[2];
            //selection = Other.selections(option);
            if (option == 1)
            {
                //logic for base
                int Base = Other.BaseSelection();
                Console.Write("Enter the decimal to be converted -->");
                string number = Console.ReadLine();
                string output = BaseConversions.DecimalToBase(Base, number);
                Console.WriteLine("The base {1} value is {0}", output, Base);
            }

            else if (option == 2)
            {
                Console.Write("Enter the binary number -->");
                string Binary = Console.ReadLine();
                int Decimal = BaseConversions.BinaryToDecimal(Binary);
                Console.WriteLine("The decimal value is {0}", Decimal);
            }

            else if (option == 3)
            {
                Console.Write("Enter the 2s complement binary number -->");
                string TwosCompBin = Console.ReadLine();
                string Decimal = BaseConversions.TwosBinToDec(TwosCompBin);
                Console.WriteLine("The decimal value is {0}", Decimal);
            }

            else if (option == 4)
            {
                Console.Write("Enter the integer to be converted into a 16 bit 2s complement binary number --> ");
                int Decimal = Int32.Parse(Console.ReadLine());
                string Binary = BaseConversions.DecimalTo2sBin(Decimal);
                Console.WriteLine("The binary value is {0}", Binary);

            }
            else if (option == 5)
            {

            }
        }
    }
}