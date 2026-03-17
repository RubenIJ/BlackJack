using System;
using System.Collections.Generic;

namespace BlackJack.Models
{
    internal class Hand
    {
        private List<Card> cards;
        private bool hasPassed;

        public bool CanPlay { get; private set; }
        public int Total { get; private set; }

        public Hand()
        {
            cards = new List<Card>();
        }

        public bool Hit(Card card)
        {
            return true;
        }

        public void Stand()
        {
        }
    }
}