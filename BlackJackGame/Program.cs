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
        static bool hide = true;

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


                switch (ReadInteger("1.hit 2.stop", 1, 2))
                {
                    case 1:
                        player.addCard(myDeck.Deal());
                        PrintHand(player);
                        break;
                    case 2:
                        while (dealer.score < 17)
                            dealer.addCard(myDeck.Deal());
                        hide = false;
                        PrintHand(dealer);
                        PrintHand(player);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\n\n\n");

                // Player Hand Busted
                if (player.score > 21)
                {
                    Console.WriteLine("Player Busted");
                    break;
                }

                //Dealer Hand Busted
                if (dealer.score > 21)
                {
                   
                    Console.WriteLine("Dealer Busted");
                    break;
                }

                // final score check
                if (!hide)
                {
                    if (dealer.score > player.score)
                        Console.WriteLine("Dealer Win");
                    else if (dealer.score < player.score)
                        Console.WriteLine("Player Win");
                    else
                        Console.WriteLine("Draw");

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
                if (hide)
                {
                    Console.CursorLeft = 5;
                    Console.CursorTop = 5;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("    ");
                    Console.ResetColor();
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
