using System;
using System.Collections.Generic;
using System.Text;

namespace CardGames
{
    class Card
    {
        private int rank;
        private int suit;

        public Card(int r, int s)
        {
            rank = r;
            suit = s;
        }

        public int getRank()
        {
            return rank;
        }

        public int getSuit()
        {
            return suit;
        }

        public int getScore()
        {
            return (rank * 4) + suit;
        }

        private string getRankText()
        {
            string rankText = "";

            switch (rank)
            {
                case 0:
                    rankText = "Ace";
                    break;
                case 1:
                    rankText = "Two";
                    break;
                case 2:
                    rankText = "Three";
                    break;
                case 3:
                    rankText = "Four";
                    break;
                case 4:
                    rankText = "Five";
                    break;
                case 5:
                    rankText = "Six";
                    break;
                case 6:
                    rankText = "Seven";
                    break;
                case 7:
                    rankText = "Eight";
                    break;
                case 8:
                    rankText = "Nine";
                    break;
                case 9:
                    rankText = "Ten";
                    break;
                case 10:
                    rankText = "Jack";
                    break;
                case 11:
                    rankText = "Queen";
                    break;
                case 12:
                    rankText = "King";
                    break;
            }
            return rankText;
        }

        private string getSuitText()
        {
            string suitText = "";

            switch (suit)
            {
                case 0:
                    suitText = "Clubs";
                    break;
                case 1:
                    suitText = "Diamonds";
                    break;
                case 2:
                    suitText = "Hearts";
                    break;
                case 3:
                    suitText = "Spades";
                    break;

            }
            return suitText;

        }

        public string getCardText()
        {
            return getRankText() + " of " + getSuitText();
        }

        
    }


    class Deck
    {
        public Card[] deckOfCards = new Card[52];

        private int front;
        public int Top //property to provide read-only access to front pointer
        {
            get
            {
                return front;
            }
            set
            {
                front = value;
            }
        }

        private int rear;
        public int Bottom //property to provide read-only access to rear pointer
        {
            get
            {
                return rear;
            }
            set
            {
                rear = value;
            }
        }

        private int size;
        // size is number of cards currently in pack
        public int Size //property to provide read-only access to size field
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }


        public Deck()
        {
            int sN; //the suit number for pack of card generation
            int rN; //the rank number for pakc of card generation


            for (rN = 0; rN < 13; rN++)
            {
                for (sN = 0; sN < 4; sN++)
                {
                    //Card cardTemp = new Card(rN, sN);
                    //deckOfCards[cardTemp.getScore()] = cardTemp;

                    deckOfCards[rN * 4 + sN] = new Card(rN, sN);
                }
            }

            front = 0;
            rear = 51;
            size = 52;
        }

        public Deck(int i)
        {

        }//thi is a constructor for an empty deck

        public Card getCard(int n)
        {
            return deckOfCards[n];//returns the card at that index
        }

        private void changeCard(int n, Card card)
        {
            deckOfCards[n] = card;
        }

        public void shuffleDeck()
        {
            Random r = new Random();//create new random


            for (int n = deckOfCards.Length - 1; n > 0; --n)//loop through each card once
            {
                int k = r.Next(n + 1);
                Card temp = deckOfCards[n];     //generate number and swap the current card with the card at that position.
                deckOfCards[n] = deckOfCards[k];
                deckOfCards[k] = temp;
            }
        }

        public void displayDeck()
        {
            for (int i = 0; i < 52; i++)//itterate through every card
            {
                Console.WriteLine(deckOfCards[i].getCardText());//display
            }
        }

        public void fillDeck()
        {
            int sN; //the suit number for pack of card generation
            int rN; //the rank number for pakc of card generation


            for (rN = 0; rN < 13; rN++)
            {
                for (sN = 0; sN < 4; sN++)
                {
                    //Card cardTemp = new Card(rN, sN);
                    //deckOfCards[cardTemp.getScore()] = cardTemp;

                    deckOfCards[rN * 4 + sN] = new Card(rN, sN);
                }
            }
        }//own thing

        public void dealDeck2Players( Deck hand1, Deck hand2)
        {
            for (int i = 0; i <= 25; i++)
            {
                hand1.changeCard(i, deckOfCards[2 * i]);
                hand2.changeCard(i, deckOfCards[2 * i + 1]);
            }
        }//own thing

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
        {
            return size == 52;
        }

        public Card DealCard()
        {
            if (!IsEmpty())
            {
                Card ACard = deckOfCards[Top];
                if (Top == 51)
                    Top = 0;
                else
                    Top++;
                Size--;
                return ACard;
            }
            else
                return null;
        }

        public void AddCard(Card ACard)
        {
            if (Bottom == 51)
                Bottom = 0;
            else
                Bottom++;
            Size++;

            deckOfCards[Bottom] = ACard;
        }
    }
}
