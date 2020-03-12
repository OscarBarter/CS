using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159265358;
            double diam, circ, radius; //declare radius as a int separatyely
            Console.WriteLine("Program to calculate the circumference of a circle");
            Console.Write("Enter circle Radius: ");
            radius = double.Parse(Console.ReadLine()); //change double to int for project
            diam = radius * 2;
            circ = PI * diam;
            Console.WriteLine("The circumference of the circle = " + circ.ToString());
            Console.ReadLine();
        }
    }
}
