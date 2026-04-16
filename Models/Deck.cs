namespace BlackJack.Models
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        public int CardsLeft => cards.Count;

        public Deck()
        {
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                int i = 0;
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(suit, rank, values[i]));
                    i++;
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card temp = cards[k];
                cards[k] = cards[n];
                cards[n] = temp;
            }
        }

        public Card? Draw()
        {
            if (cards.Count == 0) return null;
            Card drawn = cards[0];
            cards.RemoveAt(0);
            return drawn;
        }
    }
}