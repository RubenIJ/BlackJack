namespace BlackJack.Models
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }
        public int Value { get; set; }

        public string ImageName
        {
            get
            {
                string rank = Rank switch
                {
                    Rank.Two => "2",
                    Rank.Three => "3",
                    Rank.Four => "4",
                    Rank.Five => "5",
                    Rank.Six => "6",
                    Rank.Seven => "7",
                    Rank.Eight => "8",
                    Rank.Nine => "9",
                    Rank.Ten => "10",
                    Rank.Jack => "jack",
                    Rank.Queen => "queen",
                    Rank.King => "king",
                    Rank.Ace => "ace"
                };

                string suit = Suit.ToString().ToLower();
                return $"{rank}_of_{suit}.png";
            }
        }

        public Card(Suit suit, Rank rank, int value)
        {
            Suit = suit;
            Rank = rank;
            Value = value;
        }
    }
}