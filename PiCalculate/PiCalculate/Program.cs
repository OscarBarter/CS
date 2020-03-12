using System;

namespace PiCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 3;
            int counter = 2;
            double temp;
            double part = 0.00;
            int itterate;

            Console.Write("Enter itteration number --> ");
            itterate = int.Parse(Console.ReadLine());

            for (int i = 1; i < itterate; i++)
            {
                if (i%2 == 1)
                {
                    temp = counter * (counter + 1) * (counter + 2);
                    counter += 2;
                    part = 4/temp;
                    total += part;
                }
                else if (i%2 == 0)
                {
                    temp = counter * (counter + 1) * (counter + 2);
                    counter += 2;
                    part = 4 / temp;
                    total -= part;
                }
                else
                {
                    Console.WriteLine("Err");
                }
            }
            Console.WriteLine(total);
        }
    }
}
