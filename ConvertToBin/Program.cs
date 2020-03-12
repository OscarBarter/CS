using System;

namespace ConvertToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary;
            int dec;
            int remainder;

            binary = "";
            Console.WriteLine("Enter a number: ");
            dec = int.Parse(Console.ReadLine());

            while (dec>0)
            {
                remainder = dec % 2;
                binary = remainder.ToString() + binary;
                dec /= 2;
            }
            Console.WriteLine(binary);
        }
    }
}
