using System;
namespace RockPaperScisssors
{
    class Program
    {
        static void Main(string[] args)
        {
            //init var
            int uGuess = 0;
            int cGuess = 0;
            string res = "";

            //cGuess
            Random random = new Random();
            cGuess = random.Next(3);
            //debugging
            //cGuess =1;
            //Console.WriteLine(cGuess);

            //uGuess
            Console.Write("Enter 0 for rock, 1 for paper, 2 for scissors >");
            uGuess = int.Parse(Console.ReadLine());

            //test cases
            if (cGuess==uGuess)
            {
                res = "draw";
            }
            else if (cGuess == 0 && uGuess == 2)
            {
                res = "lose";
            }
            else if (cGuess < uGuess && uGuess != 0)
            {
                res = "win";
            }
            else if (cGuess == 2 && uGuess == 0)
            {
                res = "win";
            }
            else
            {
                res = "lose";
            }
            //final
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}