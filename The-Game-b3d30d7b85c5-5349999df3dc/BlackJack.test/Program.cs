using System;
using BlackJack;

class Program
{
    static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine("name:");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName);

            Blackjack game = new Blackjack(player);

                for (int i = 0; i < 2; i++)
            {
                player.AddCard(deck.DrawCard());
            }

                Console.WriteLine(player.ShowHand());

   while (true)
            {
                Console.WriteLine("do u want a new card? (y/n)");
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    player.AddCard(deck.DrawCard());
                    Console.WriteLine(player.ShowHand());
                    string result = game.ScoreHand(player.Hand);
                    Console.WriteLine(result);

                    if (result == "Busted" || result == "Blackjack" || result == "Twenty-One" || result == "Five Card Charlie")
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("thank u for playing");
        }
    
}
