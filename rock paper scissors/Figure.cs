using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class Figure : IComparable
    {
        public string Fig { get; set; }

        public Figure()
        {

        }

        public Figure(string figure)
        {
            Fig = figure;
        }

        public int CompareTo(object obj)
        {
            Figure fig1 = (Figure)obj;
            if (this.Fig == "rock")
            {
                //rock == rock
                if (fig1.Fig == "rock")
                {
                    return 0;
                }
                //rock < paper
                else if (fig1.Fig == "paper")
                {
                    return -1;
                }
                //rock > scissors
                else return 1;
            }
            else if (this.Fig == "paper")
            {
                if (fig1.Fig == "rock")
                {
                    return 1;
                }
                else if (fig1.Fig == "paper")
                {
                    return 0;
                }
                else return -1;
            }
            else
            {
                if (fig1.Fig == "rock")
                {
                    return -1;
                }
                else if (fig1.Fig == "paper")
                {
                    return 1;
                }
                else return 0;
            }
        }
    }
}
