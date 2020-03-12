using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
