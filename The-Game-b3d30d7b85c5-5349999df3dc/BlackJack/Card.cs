namespace BlackJack
{
    public class Card
    {
        private string _suit;
        private string _value;

        public static readonly string[] ValidSuits = { "♥", "♦", "♣", "♠" };
        public static readonly string[] ValidValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "Q", "K", "A" };


        public Card(string suit, string value)
        {
            ValidateSuit(suit);
            ValidateValue(value);
            _suit = suit;
            _value = value;
        }

        public string Suit
        {
            get { return _suit; }
        }

        public string Value
        {
            get { return _value; }
        }

        private void ValidateSuit(string suit)
        {
            if (Array.IndexOf(ValidSuits, suit.ToLower()) == -1)
            {
                throw new ArgumentException($"Ongeldige suit: {suit}");
            }
        }

        private void ValidateValue(string value)
        {
            if (Array.IndexOf(ValidValues, value) == -1)
            {
                throw new ArgumentException($"Ongeldige value: {value}");
            }
        }
    }
}
