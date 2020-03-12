using System;
namespace Guessing_Game{class Program{static void Main(string[] args){
            int guess = 0;
            Random random = new Random(); int num = random.Next(100);
            Console.WriteLine("Enter guess"); guess = int.Parse(Console.ReadLine());
            while (guess != num){
                if (num > guess){
                    Console.WriteLine("guess too low");
                }else{
                    Console.WriteLine("guess too high");
                }Console.WriteLine("Enter guess");
                guess = int.Parse(Console.ReadLine());
            } Console.WriteLine("You win!");
 }}}