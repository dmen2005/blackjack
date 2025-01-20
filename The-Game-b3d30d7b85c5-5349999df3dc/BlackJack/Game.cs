using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Blackjack
    {
        private Player _player;

        public Blackjack(Player player)
        {
            _player = player;
        }

        public string ScoreHand(List<Card> hand)
        {
            int score = 0;
            int cardCount = hand.Count;

            foreach (Card card in hand)
            {
                score += Score(card);
            }

            if (score > 21)
            {
                return "Busted";
            }
            else if (score == 21 && cardCount == 2)
            {
                return "Blackjack";
            }
            else if (score == 21)
            {
                return "Twenty-One";
            }
            else if (cardCount == 5 && score < 21)
            {
                return "Five Card Charlie";
            }

            return score.ToString();
        }

        public int Score(Card card)
        {
            if (int.TryParse(card.Value, out int value))
            {
                return value;

            }
            if (card.Value == "A")
            {
                return 11;
            }
            return 10;
        }
    }
}
