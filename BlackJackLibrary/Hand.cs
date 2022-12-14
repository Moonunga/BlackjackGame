using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    public class Hand
    {
        public List<Card> CardsInHand { get; private set; }
        public int score { get; private set; }
        private bool isDealer ;

        public Hand(bool dealer = false)
        {
            isDealer = dealer;
        }

        public void addCard(Card card)
        {
            CardsInHand.Add(card);

            if ((int)card.Face >= 0 || (int)card.Face < 10)
                score += ((int)card.Face + 1);
            else if ((int)card.Face > 10)
                score += 10;
        }

    }
}
