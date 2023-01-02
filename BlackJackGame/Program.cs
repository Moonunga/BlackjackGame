using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using BlackJackLibrary;

namespace BlackJackGame
{
    internal class Program
    {
        static int CardSize = 5;

        static void Main(string[] args)
        {
            //PrintDeck(myDeck);
            GameLoad();

            Deck myDeck = new Deck();
            myDeck.Shuffle();

            Hand player = new Hand();
            Hand dealer = new Hand(true);

            player.addCard(myDeck.Deal());
            player.addCard(myDeck.Deal());

            dealer.addCard(myDeck.Deal());
            dealer.addCard(myDeck.Deal());

            bool _continue = true;
           
            while (_continue)
            {
                Console.Clear();
                PrintHand(dealer);
                PrintHand(player);
                Console.WriteLine("\n\n");
                if (player.score > 21)
                    break;
                switch (ReadInteger("1.hit 2.stop", 1, 2))
                {
                    case 1:
                        player.addCard(myDeck.Deal());
                        PrintHand(player);
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }

            }
        }

        static void GameLoad()
        {
            Console.CursorTop = 10;
            Console.CursorLeft = 20;
            Console.WriteLine("Press anything to start");
            Console.ReadKey();
            Console.Clear();
        }

        static void PrintHand(Hand hand)
        {
            int playerX = 5;
            int playerY = 15;
            int dealerX = 5;
            int dealerY = 5;

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


        static void PrintDeck(Deck _myDeck)
        {
            int cardSize = 5;

            int Xpoint = 0;
            int Ypoint = 0;

            for (int i = 0; i < _myDeck.cards.Count; i++)
            {
                _myDeck.cards[i].Print(Xpoint, Ypoint);
                Xpoint += cardSize;
                if (Xpoint > cardSize * 5)
                {
                    Xpoint = 0;
                    ++Ypoint;
                }
            }

        }


        public static int ReadInteger(string prompt, int min, int max)
        {
            int UserInt;

            while (true)
            {
                Console.Write(prompt + " ");
                while (!int.TryParse(Console.ReadLine(), out UserInt))
                {
                    Console.WriteLine("error");
                    Console.Write(prompt + " ");
                }
                if (UserInt < min || UserInt > max)
                    Console.WriteLine("error");
                else
                    break;
            }
            return UserInt;
        }

    }
}
