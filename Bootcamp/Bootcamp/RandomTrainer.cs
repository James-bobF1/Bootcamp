using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public class RandomTrainer : Traider
    {
        static int count;
        public RandomTrainer()
            : base()
        {
            count++;
            name = "Непредсказуемый_" + count;
        }

        protected override TraideSolution Solution
        {
            get
            {
                TraideSolution solution = (TraideSolution)rnd.Next(2);
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
