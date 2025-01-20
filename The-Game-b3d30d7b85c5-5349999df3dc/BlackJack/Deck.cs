using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Deck
    {
        private List<Card> _cards = new();

        public Deck()
        {
            foreach (string suit in Card.ValidSuits)
            {
                foreach (string value in Card.ValidValues)
                {
                    _cards.Add(new Card(suit, value));
                }
            }
        }

        public Card DrawCard()
        {
            if (_cards.Count == 0)
            {
                throw new InvalidOperationException("no more cards.");
            }

            Random random = new Random();
            int index = random.Next(_cards.Count);
            Card drawnCard = _cards[index];
            _cards.RemoveAt(index);
            return drawnCard;
        }
    }
}
