using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class Player
    {
        public bool IsHuman { get; set; }
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int Score { get; set; }
        Random r;

        public Player(bool isHuman, int playerID)
        {
            IsHuman = isHuman;
            PlayerID = playerID;
            PlayerName = "Player " + PlayerID.ToString() + (isHuman ? "" : " (CPU)");
            Score = 0;
            r = new Random();
        }

        public int ChooseFigure()
        {
            int answer;
            if (IsHuman)
            {
                do
                {
                    Console.WriteLine(PlayerName + ": choose figure (1-rock, 2-paper, 3-scissors): ");
                    answer = Convert.ToInt32(Console.ReadLine());

                } while (answer != 1 && answer != 2 && answer != 3);
            }
            else
            {
                answer = r.Next(1, 4);
            }

            return answer;
        }

        public void AddPoint()
        {
            Score++;
        }
    }
}
