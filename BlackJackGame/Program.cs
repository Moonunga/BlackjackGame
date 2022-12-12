using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using BlackJackLibrary;

namespace BlackJackGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
             PrintDeck();
        }

        static void PrintDeck()
        {
            int cardSize = 5;
            
            Deck myDeck = new Deck();

            int Xpoint = 0;
            int Ypoint = 0;

            
            for (int i = 0; i < myDeck.cards.Count; i++)
            {
                myDeck.cards[i].Print(Xpoint, Ypoint);
                Xpoint += cardSize;
                if (Xpoint > cardSize * 5)
                {
                    Xpoint = 0;
                    ++Ypoint;
                }
            }

        }


    }
}
