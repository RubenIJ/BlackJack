using System;
using System.Collections.Generic;

namespace BlackJack.Models
{
    internal class Player
    {
        private List<Hand> hands;
        private int chips;

        public bool AllowedPlay { get; private set; }

        public Player(int chips)
        {
            hands = new List<Hand>();
            this.chips = chips;
        }

        public void Hit(Card card)
        {
        }

        public void Stand()
        {
        }

        public void PlaceBets(int amount)
        {
        }

        public void Reset()
        {
        }
    }
}