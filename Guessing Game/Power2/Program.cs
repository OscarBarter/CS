using System;

namespace Power2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number --> ");
            int number = int.Parse(Console.ReadLine());

            int mult = 1;
            double temp_total = 0;

            do
            {
                temp_total = Math.Pow(2.0, mult);
                mult++;
            } while (temp_total < number);
            Console.WriteLine(temp_total);
        }
    }
}
