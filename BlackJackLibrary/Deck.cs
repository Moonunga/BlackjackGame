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

        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int ranNum = new Random().Next(0, cards.Count);
                Card cardSpace = cards[i];
                cards[i] = cards[ranNum];
                cards[ranNum] = cardSpace;
            }
           
        }

        public Card Deal()
        {
            Card card = cards[0];
            cards.RemoveAt(0);

            return card;
        }

    }
}
