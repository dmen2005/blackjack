using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Player
    {
        public string Name { get; init; }
        public List<Card> Hand { get; init; } = new();

        public Player(string name)
        {
            Name = name;
        }

        public void AddCard(Card card)
        {
            Hand.Add(card);
        }

        public string ShowHand()
        {
            StringBuilder handDescription = new StringBuilder();
            handDescription.Append($"{Name} heeft:\n");

            foreach (Card card in Hand)
            {
                string cardTopBottom = "+---------+";
                string cardEmptyRow = "|         |";
                string cardValueTop = $"| {card.Value,-2}      |";
                string cardValueBottom = $"|      {card.Value,2} |";
                string cardSuit = $"|    {card.Suit[0]}    |";

                handDescription.AppendLine(cardTopBottom);
                handDescription.AppendLine(cardValueTop);
                handDescription.AppendLine(cardEmptyRow);
                handDescription.AppendLine(cardSuit);
                handDescription.AppendLine(cardEmptyRow);
                handDescription.AppendLine(cardValueBottom);
                handDescription.AppendLine(cardTopBottom);
            }

            return handDescription.ToString().Trim();
        }
    }
}
