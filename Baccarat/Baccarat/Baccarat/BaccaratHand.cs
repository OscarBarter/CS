using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace Baccarat
{
    public class BaccaratHand : ScoringHand
    {
        public override int getScore()
        {
            int result = 0;
            foreach (Card c in cards)
            {
                if (c.GetRank() < 10)
                {
                    result += c.GetRank();
                }
            }
            return result % 10;
        }
    }
}
