using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace BlackJackConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            pack.Shuffle();
            BlackJackHand hand = new BlackJackHand();
            hand.AddCard(pack.DealCard());
            Console.WriteLine(hand.First().GetName());
            hand.AddCard(pack.DealCard());
            Console.WriteLine(hand.Last().GetName());
            Console.WriteLine();
            Console.WriteLine(hand[0].GetName());
            Console.WriteLine(hand[1].GetName());
            Console.WriteLine("The value of the hand is " + hand.getScore());
            char choice;
            do
            {
                Console.WriteLine("T(wist) or S(tick)");
                choice = Console.ReadLine().ToUpper()[0];
                if (choice.Equals('T'))   //single quotes for char literals
                {
                    hand.AddCard(pack.DealCard());
                    Console.WriteLine(hand.Last().GetName());
                    Console.WriteLine("The value of the hand is " + hand.getScore());
                }
            }
            while ((choice.Equals('T') && (hand.getScore() <= 21)));
           
            if (hand.getScore() > 21)
            {
                Console.WriteLine("Sorry, you are bust");
            }
            else
            {
                Console.WriteLine("Your score is " + hand.getScore());
            }
            Console.ReadLine();
        }
    }
}
