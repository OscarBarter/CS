using System;

namespace CardGames
{
    class Program
    {
        static Card[] hand1 = new Card[52];
        static Card[] hand2 = new Card[52];

        static Deck createAndShuffle()
        {
            //create and shuffle a deck
            Deck deck = new Deck();
            deck.shuffleDeck();
            return deck;
        }

        static void Deal(Deck deck)
        {
            for (int i = 0; i <= 25; i++)
            {
                hand1[i] = deck.getCard(2 * i);
                hand2[i] = deck.getCard(2 * i + 1);
            }
        }

        static void PlayCompareScore()
        {
            int score1 = 0;
            int score2 = 0;
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine(hand1[i].getCardText() + " scores " + hand1[i].getScore());
                Console.WriteLine(hand2[i].getCardText() + " scores " + hand2[i].getScore());

                if (hand1[i].getScore() > hand2[i].getScore())
                {
                    Console.WriteLine("Player 1 wins");
                    score1++;
                }
                else
                {
                    Console.WriteLine("Player 2 wins");
                    score2++;
                }
                Console.WriteLine("Scores: P1: " + score1 + " P2: " + score2);
                Console.ReadLine();
            }
            if (score1 > score2)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if (score1 < score2)
            {
                Console.WriteLine("Player 2 wins!");
            }
            else
            {
                Console.WriteLine("It is a draw");
            }
        }

        static void Main(string[] args)
        {
            /*This is for the first game
            Deck deck = createAndShuffle();
            Deal(deck);
            PlayCompareScore();
            */


           
            
        }

        static bool testing()
        {

        }
    }
}
