using System;

namespace ASCII_display
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (i = 32; i < 127; i++)
            {
                Console.WriteLine(Convert.ToChar(i));

            }
        }
    }
}
