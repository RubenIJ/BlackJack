namespace BlackJack.Models
{
    public class Shoe
    {
        private List<Deck> decks = new List<Deck>();

        public Shoe(int aantalDecks)
        {
            for (int i = 0; i < aantalDecks; i++)
            {
                decks.Add(new Deck());
            }
        }

        public void Shuffle()
        {
            foreach (Deck deck in decks)
            {
                deck.Shuffle();
            }
        }

        public Card? Draw()
        {
            foreach (Deck deck in decks)
            {
                Card? card = deck.Draw();
                if (card != null) return card;
            }
            return null;
        }
    }
}