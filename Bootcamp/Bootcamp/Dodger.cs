using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public class Dodger : Traider
    {
        static int count;
        public Dodger()
            : base()
        {
            count++;
            name = "Хитрец_" + count;
        }

        protected override TraideSolution LastOpponentSolution
        {
            get
            {
                return base.LastOpponentSolution;
            }
            set
            {
                base.LastOpponentSolution = value;
            }
        }

        protected override TraideSolution Solution
        {
            get
            {
                if (rnd.Next(100) < 5)
                {
                    return (TraideSolution)(1-LastOpponentSolution);
                }
                else
                {
                    return LastOpponentSolution;
                }
            }
        }
    }
}
