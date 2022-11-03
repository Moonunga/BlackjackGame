using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
   
    internal class Deck
    {
        protected List<Card> cards = new List<Card>();

        public Deck()
        {
            CreateDeck();
        }

        public void CreateDeck()
        {
            foreach (CardSuit cardSuit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardFace cardface in Enum.GetValues(typeof(CardFace)))
                {
                    
                }
            }

        }


    }
}
