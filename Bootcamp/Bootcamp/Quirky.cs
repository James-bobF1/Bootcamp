using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public class Quirky : Traider
    {
        static int count;
        public Quirky()
            : base()
        {
            count++;
            countTrade = 0;
            isCheater = true;
            name = "Ушлый_" + count;
        }

        public override void NewYear()
        {
            base.NewYear();
            isCheater = true;
            countTrade = 0;
        }

        protected override TraideSolution LastOpponentSolution
        {
            get
            {
                return base.LastOpponentSolution;
            }
            set
            {
                if (countTrade < 4)
                {
                    if (value == TraideSolution.Сжульничать && isCheater)
                    {
                        base.LastOpponentSolution = value;
                        isCheater = false;
                    }              
                }
                else
                {
                    if (isCheater)
                    {
                        base.LastOpponentSolution = value;
                    }
                }
            }
        }

        int countTrade;
        bool isCheater;
        TraideSolution[] strategy = new TraideSolution[4] { TraideSolution.Честная_сделка, TraideSolution.Сжульничать, TraideSolution.Честная_сделка, TraideSolution.Честная_сделка };
        protected override TraideSolution Solution
        {
            get
            {
                TraideSolution solution;
                if (++countTrade > 4)
                {
                    solution = LastOpponentSolution;
                }
                else
                {
                    solution=strategy[countTrade-1];
                }
                if (rnd.Next(100) < 5)
                {
                    return (TraideSolution)(1 - solution);
                }
                else
                {
                    return solution;
                }
            }
        }
    }
}
