using System;

namespace tempertature_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Is your temperature F or C?");
            string choice;
            double far = 0, cel = 0;
            choice = Console.ReadLine();
            if (choice == "F")
            {
                Console.Write("Enter fahrenheit: ");
                far = double.Parse(Console.ReadLine());
                cel = (far - 32) * 5 / 9;
                Console.WriteLine(far + " fahrenheit is " + cel + " in celcius");
            }
            else
            {
                Console.Write("Enter celcius: ");
                cel = double.Parse(Console.ReadLine());
                far = (cel * 9 / 5) + 32;
                Console.WriteLine(cel + " celcius is " + far + " in fahrenheit");
            }
        }

    }
}
