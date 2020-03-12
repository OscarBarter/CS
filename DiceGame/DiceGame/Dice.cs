using System;

namespace DiceGame
{
    class Dice
    {
        private int value;//use public if reckless
        private int sides;
        Random rnd = new Random();

        public Dice(int numSides)
        {
            sides = numSides;
        }
        public int getValue()
        {
            return value;
        }

        public void roll()
        {
            value = rnd.Next(sides) + 1;
        }
    }
}
