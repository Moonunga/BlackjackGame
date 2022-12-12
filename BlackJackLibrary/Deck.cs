using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
   
    public class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            CreateDeck();
        }

        void CreateDeck()
        {
            foreach (CardSuit cardSuit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardFace cardface in Enum.GetValues(typeof(CardFace)))
                {
                    cards.Add(new Card(cardSuit, cardface));
                }
            }

        }

    }
}
