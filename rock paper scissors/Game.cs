using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        int round, maxRounds;

        public Game(Player player1, Player player2, int maxRounds)
        {
            Player1 = player1;
            Player2 = player2;
            this.maxRounds = maxRounds;
        }

        public void Start()
        {
            
        }
    }
}
