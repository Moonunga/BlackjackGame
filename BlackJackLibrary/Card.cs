using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    public enum CardSuit
    { Spades, Hearts, Clubs, Diamonds }
    public enum CardFace
    { A, two, three, four, five, six, seven, eight, nine, ten, J, Q, K }

    internal class Card
    {
        public CardSuit Suit { get; private set; }
        public CardFace Face { get; private set; }


        public Card(CardSuit suit,CardFace face)
        {
            Suit = suit;
            Face = face;
        }


    }
}
