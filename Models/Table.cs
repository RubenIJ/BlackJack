using System;
using System.Collections.Generic;
using BlackJack.Models;

namespace BlackJack.Logic
{
    internal class Table
    {
        private Shoe shoe;
        private Dealer dealer;
        private List<Player> players;
        private GameState gameState;
        private int chips;
        private int points;
        private int activePlayerIndex;

        public Table(int shoeSize, int amountOfPlayers)
        {
        }

        public void NextMove(string input)
        {
        }
    }
}