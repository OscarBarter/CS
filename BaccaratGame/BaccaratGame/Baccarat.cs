using System;
using CardGames;

namespace Baccarat
{
    public class Baccarat
    {
        private Deck deck;
        private BaccaratHand _PHand;
        private BaccaratHand _BHand;

        private int getPHandScore()//get the score of the players hand
        {
            return _PHand.getScore();
        }

        public int PScore
        {
            get { return getPHandScore(); }
        }

        private int getBHandScore()//get the score of the bankers hand
        {
            return _BHand.getScore();
        }

        public int BScore
        {
            get { return getBHandScore(); }
        }

        //get the players and bankers hand
        public BaccaratHand PHand
        {
            get { return _PHand; }
        }

        public BaccaratHand BHand
        {
            get { return _BHand; }
        }
        //constructor for the class, which sets up the hands from the deck
        public Baccarat()
        {
            deck = new Deck();
            _PHand = new BaccaratHand();
            _BHand = new BaccaratHand();
        }

        //check for a natural win
        public bool NaturalWin()
        {
            return ((PScore >= 8) || (BScore >= 8));
        }

        //deal cards to the players
        public void DealGame()
        {
            deck.shuffleDeck();
            PHand.AddCard(deck.DealCard());
            PHand.AddCard(deck.DealCard());
            BHand.AddCard(deck.DealCard());
            BHand.AddCard(deck.DealCard());
        }
        //gets both players to draw cards if no player has a natural and within the rules
        public void DrawCard()
        {
            if ((PScore >= 0) && (PScore <= 5))
            {
                PHand.AddCard(deck.DealCard());
                int PDraw = PHand[2].getRank();
                if (PDraw == 8)
                {
                    PDraw = -2;
                }
                if (PDraw == 9)
                {
                    PDraw = -1;
                }
                if ((PDraw >= 10) && (PDraw <= 13))
                {
                    PDraw = 0;
                }
                if (BScore <= (PDraw / 2) + 3)
                {
                    BHand.AddCard(deck.DealCard());
                }
            }
            else
            {
                if ((BScore >= 0) && (BScore <= 5))
                {
                    BHand.AddCard(deck.DealCard());
                }
            }
        }

        //deals and draws cards
        public void Play()
        {
            DealGame();
            DrawCard();
        }


        //set up the betting function including channging money, bets and who you are betting on
        private int money = 100;//amount of money

        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        private int bet = 0;//the bet amount

        public int Bet
        {
            get { return bet; }
            set { bet = value; }
        }
        private char betLocation = ' ';//where you are placing your bet

        public char BetLocation
        {
            get { return betLocation; }
            set { betLocation = value; }
        }
        //function for a legal bet changing the necesarry parameters to reflect this
        public void MakeBet()
        {
            bool sucessful;
            do
            {
                Console.Write("Current money is {0} \n" +
                "Enter the bet amount --> ", Money);
                int tempBet = int.Parse(Console.ReadLine());
                Console.Write("Current bet is {0} \n" +
                    "Enter the bet position (B, P, T)--> ", Bet);
                char tempPos = char.Parse(Console.ReadLine());
                sucessful = (Bet < Money);
                if (sucessful)
                {
                    Bet = tempBet;
                    Money -= tempBet;
                    BetLocation = tempPos;
                }
                else
                {
                    Console.WriteLine("You don't have enough money, please enter a lower amount");
                }
            } while (!sucessful || !(BetLocation == 'B' || BetLocation == 'P' || BetLocation == 'T'));
            
        }
        //distributes the money from winning the bet
        public void ResolveTurn(bool win)
        {
            double winnings = 0;
            if (win)
            {
                if (BetLocation == 'B')
                {
                    winnings = 0.95 * Bet;
                }
                else if(BetLocation == 'P')
                {
                    winnings = 1.5 * Bet;
                }
                else if(BetLocation == 'T')
                {
                    winnings = 8 * Bet;
                }
                Money += (int)Math.Floor(winnings);
                Bet = 0;
            }
        }
    }

    public class BaccaratGameDisplaying
    {
        //class for the UI of the game

        

        public void DisplayInLine(Baccarat game)
        {
            //displays players and bankers hand
            Console.WriteLine("Player's cards are: ");
            if (game.PHand.Size == 2)
            {
                game.PHand.display2CardASCII(game.PHand);
            }
            else
            {
                game.PHand.display3CardASCII(game.PHand);
            }
            Console.WriteLine("Banker's cards: ");
            if (game.BHand.Size == 2)
            {
                game.BHand.display2CardASCII(game.PHand);
            }
            else
            {
                game.BHand.display3CardASCII(game.BHand);
            }
            Console.WriteLine("Player's score: " + game.PScore);
            Console.WriteLine("Banker's score: " + game.BScore + "\n");
        }

        public void DisplayDraw(Baccarat game)
        // displays outcome of draw phase of game
        {
            if (game.PHand.Size == 2)
            {
                Console.WriteLine("The player has stood");
                Console.ReadLine();
            }
            if (game.PHand.Size == 3)
            {
                Console.WriteLine("The player has drawn the " + game.PHand[2].getCardText());
                Console.ReadLine();
            }
            if (game.BHand.Size == 2)
            {
                Console.WriteLine("The banker has stood");
                Console.ReadLine();
            }
            if (game.BHand.Size == 3)
            {
                Console.WriteLine("The banker has drawn the " + game.BHand[2].getCardText());
                Console.ReadLine();
            }
            Console.WriteLine();
        }

        public char FinalResult(Baccarat game)
        // displays outcome of game
        {
            char winChar = ' ';
            if (game.PScore > game.BScore)
            {
                Console.WriteLine("The Player has won");
                winChar = 'P';
            }
            if (game.BScore > game.PScore)
            {
                Console.WriteLine("The Banker has won");
                winChar = 'B';
            }
            if (game.PScore == game.BScore)
            {
                Console.WriteLine("It's a tie");
                winChar = 'T';
            }
            return winChar;
        }
    }
    }



