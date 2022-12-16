using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using BlackJackLibrary;

namespace BlackJackGame
{
    internal class Program
    {
        static int playerX = 5;
        static int playerY = 5;

        static int dealerX = 5;
        static int dealerY = 15;

        static int CardSize = 5;

        static void Main(string[] args)
        {
            //PrintDeck(myDeck);


            Deck myDeck = new Deck();
            myDeck.Shuffle();

            Hand player = new Hand();
            Hand dealer = new Hand(true);

            player.addCard(myDeck.Deal());
            player.addCard(myDeck.Deal());

            dealer.addCard(myDeck.Deal());
            dealer.addCard(myDeck.Deal());

            PrintHand(player);
            PrintHand(dealer);
        }

        static void PrintHand(Hand hand)
        {
            if (hand.isDealer)
            {
                for (int i = 0; i < hand.CardsInHand.Count; i++)
                {
                    hand.CardsInHand[i].Print(dealerX, dealerY);
                    dealerX += CardSize;
                }
            }
            else 
            {
                for (int i = 0; i < hand.CardsInHand.Count; i++)
                {
                    hand.CardsInHand[i].Print(playerX, playerY);
                    playerX += CardSize;
                }
            }
        }

       
        static void PrintDeck(Deck myDeck)
        {
            int cardSize = 5;
            
           

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
