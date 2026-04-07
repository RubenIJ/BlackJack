namespace BlackJack.Models
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();
        private bool hasPassed = false;

        public bool CanPlay { get; private set; } = true;
        public int Total { get; private set; } = 0;

        public bool Hit(Card card)
        {
            cards.Add(card);
            Total += card.Value;

            // Aas van 11 naar 1 als je over 21 gaat
            if (Total > 21)
            {
                foreach (Card c in cards)
                {
                    if (c.Value == 11)
                    {
                        Total -= 10;
                        break;
                    }
                }
            }

            if (Total > 21)
            {
                CanPlay = false;
            }

            return CanPlay;
        }

        public void Stand()
        {
            hasPassed = true;
            CanPlay = false;
        }
    }
}