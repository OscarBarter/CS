using System;

namespace Prime2to50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first few prime numbers are: ");
            for (int count1 = 2; count1 < 10000001; count1++)
            {
                int count2 = 2;
                string prime = "yes";
                while (count2 * count2 <= count1)
                {
                    if (count1 % count2 == 0)
                    {
                    prime = "no";
                    }
                    count2++;
                }
                if (prime == "yes")
                {
                    Console.WriteLine(count1);
                }
            }
        }
    }
}
