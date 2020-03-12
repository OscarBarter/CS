using System;
using CardGames;
using Baccarat;

namespace Baccarat
{
    class Program
    {

        static void Main(string[] args)
        {
            //create loop for game and set up the game
            bool exit = false;
            BaccaratGameDisplaying gameUI = new BaccaratGameDisplaying();
            Baccarat game = new Baccarat();

            while (exit == false)
            {
                //get the bet and start the game
                game.MakeBet();
                game.DealGame();
                gameUI.DisplayInLine(game);
                Console.ReadLine();
                //check for natural win
                if (game.NaturalWin())
                {
                    Console.WriteLine("One player has a Natural: the game is over");
                }
                else
                {
                    //if not, check and draw cards
                    game.DrawCard();
                    gameUI.DisplayDraw(game);
                    gameUI.DisplayInLine(game);
                }
                //display the result of the game
                Console.ReadLine();
                char winChar = gameUI.FinalResult(game);
                Console.ReadLine();
                //sort out the bets
                if (game.BetLocation == winChar)
                {
                    game.ResolveTurn(true);
                }
                else
                {
                    game.ResolveTurn(false);
                }
                //display the money
                Console.WriteLine("Money at the moment is {0}", game.Money);
                
                
                //logic for second + round
                Console.Write("Enter Y for another round--> ");
                string choice = Console.ReadLine();
                if (choice != "Y")
                {
                    exit = true;
                }
            }

            //end of game
            Console.WriteLine("Money at the end of the game is {0}", game.Money);

        }
    }
}




