using System.Collections.Generic;

namespace BlackJack.Models
{
    public class Table
    {
        public Shoe shoe = new Shoe(6);
        public Dealer dealer = new Dealer();
        public List<Player> players = new List<Player>();

        public Table()
        {
            players.Add(new Player()); // Speler 1
            players.Add(new Player()); // Speler 2
            players.Add(new Player()); // Speler 3
        }
    }
}