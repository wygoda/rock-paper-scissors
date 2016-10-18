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
        uint round, maxRounds;

        public Game(Player player1, Player player2, uint maxRounds)
        {
            Player1 = player1;
            Player2 = player2;
            this.maxRounds = maxRounds;;
        }

        public void Start()
        {
            int result;
            for (round = 1; round <= maxRounds; round++)
            {
                Player1.ChooseFigure();
                Player2.ChooseFigure();

                result = Player1.Fig.CompareTo(Player2.Fig);

                switch (result)
                {
                    case 1:
                        Console.WriteLine("P1 WON!");
                        Player1.AddPoint();
                        break;

                    case 0:
                        Console.WriteLine("IT'S A DRAW!");
                        break;

                    case -1:
                        Console.WriteLine("P2 WON!");
                        Player2.AddPoint();
                        break;

                    default:
                        Console.WriteLine("Oops? (failed on comparing figures)");
                        break;
                }

                if (Player1.Score > maxRounds/2 || Player2.Score > maxRounds / 2)
                {
                    break;
                }
            }

            Console.WriteLine("The game is finished! Final score: P1 {0} - {1} P2\nWell done, {2}!", Player1.Score, Player2.Score, Player1.Score > Player2.Score ? Player1.PlayerName : Player2.PlayerName);
        }
    }
}
