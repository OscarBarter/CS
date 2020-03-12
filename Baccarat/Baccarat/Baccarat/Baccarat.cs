using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace Baccarat
{
    public class Baccarat
    {
        private Pack pack;
        private BaccaratHand _PHand;
        private BaccaratHand _BHand;

        private int getPScore()
        {
            return PHand.getScore();
        }

        public int PScore
        {
            get
            {
                return getPScore();
            }
        }
        private int getBScore()
        {
            return BHand.getScore();
        }

        public int BScore
        {
            get
            {
                return getBScore();
            }
        }

        public BaccaratHand PHand
        {
            get
            { return _PHand; }
        }

        public BaccaratHand BHand
        {
            get
            { return _BHand; }
        }
        public Baccarat()
        {
            pack = new Pack();
            _PHand = new BaccaratHand();
            _BHand = new BaccaratHand();
        }

        public bool Natural()
        {
            return ((PScore >= 8) || (BScore >= 8));
        }

        public void Deal()
        {
            pack.Shuffle();
            PHand.AddCard(pack.DealCard());
            PHand.AddCard(pack.DealCard());
            BHand.AddCard(pack.DealCard());
            BHand.AddCard(pack.DealCard());
        }

        public void Draw()
        {
            if ((PScore >= 0) && (PScore <= 5))
            {
                PHand.AddCard(pack.DealCard());
                int PDraw = PHand[2].GetRank();
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
                    BHand.AddCard(pack.DealCard());
                }
            }
            else
            {
                if ((BScore >= 0) && (BScore <= 5))
                {
                    BHand.AddCard(pack.DealCard());
                }
            }
        }
        public void Play()
        {
            Deal();
            Draw();
        }
    }
}
