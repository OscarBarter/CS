using System;

namespace Compound_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of years -->");
            int years = int.Parse(Console.ReadLine());

            Console.Write("Enter percentage -->");
            double perc = double.Parse(Console.ReadLine());

            Console.Write("Enter amount invested -->");
            double money = double.Parse(Console.ReadLine());

            for (years = years + 1 - 1; years > 0; years--)
            {
                money = money * (1 + (perc / 100));
                Console.WriteLine(years);
            }
            Console.WriteLine(money);
        }
    }
}
