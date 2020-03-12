using System;

namespace Cream
{
    class Program
    {
        static void Main(string[] args)
        {
            double left = 100;
            double miss_per_mult = 0.98;
            int secs = 0;

            while (left > 50)
            {
                left *= miss_per_mult;
                secs++;
            }
            Console.WriteLine(secs);
    }
}
