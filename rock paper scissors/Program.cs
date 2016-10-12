using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(false, 1);
            Player p2 = new Player(true, 2);
            Game g = new Game(p1, p2, 3);
            g.Start();
            Console.ReadKey();
        }
    }
}
