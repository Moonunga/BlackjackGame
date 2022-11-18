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

        public void Print(int x, int y)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string[] suitShape = {"♠︎", "♥", "♣", "♦" };

            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor =
                (Suit == CardSuit.Spades || Suit == CardSuit.Clubs ? ConsoleColor.Black : ConsoleColor.Red);

            if ((int)Face > 9 || (int)Face == 0)
                Console.WriteLine($"{suitShape[(int)Suit]}{Face}");
            else
                Console.WriteLine($"{suitShape[(int)Suit]}{(int)Face + 1}");

            Console.ResetColor();

        }

    }
}
