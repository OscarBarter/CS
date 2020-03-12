using System;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            float length, height, width, volume;

            Console.WriteLine("Enter length: ");
            length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            width = float.Parse(Console.ReadLine());
            volume = height * width * length;
            Console.WriteLine("The volume of the box is " + Math.Round(volume, 2));
            Console.ReadLine();
        }
    }
}
