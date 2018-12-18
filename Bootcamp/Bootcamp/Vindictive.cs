using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public class Vindictive : Traider
    {
        static int count;
        public Vindictive()
            : base()
        {
            count++;
            name = "Злопамятный_" + count;
        }

        protected override TraideSolution LastOpponentSolution
        {
            get
            {
                return base.LastOpponentSolution;
            }
            set
            {
                if (value == TraideSolution.Сжульничать)
                {
                    base.LastOpponentSolution = value;
                }
            }
        }

        protected override TraideSolution Solution
        {
            get
            {
                if (rnd.Next(100) < 5)
                {
                    return (TraideSolution)(1 - LastOpponentSolution);
                }
                else
                {
                    return LastOpponentSolution;
                }
            }
        }
    }
}
