﻿using System;


namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice myDie = new Dice(6); myDie.roll();
            Console.WriteLine("The die shows: " + myDie.getValue());
            Console.WriteLine("Roll the die:");
            myDie.roll();
            Console.WriteLine("The die shows: " + myDie.getValue());
            Console.WriteLine("Roll the die:");
            myDie.roll();
            Console.WriteLine("The die shows: " + myDie.getValue());


        }
    }
}
