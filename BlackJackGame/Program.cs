using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using BlackJackLibrary;

namespace BlackJackGame
{
    internal class Program
    {
        public int[] playerPosi = { 5, 5 };
        public int[] dealerPosi = { 5, 15 };
        private int CardSize = 5;

        static void Main(string[] args)
        {
            // PrintDeck();
            Deck myDeck = new Deck();
            Hand myHand = new Hand();
            Hand dealer = new Hand(true);
            


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
