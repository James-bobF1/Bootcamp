using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public class Cheater : Traider
    {
        static int count;
        public Cheater()
            : base()
        {
            count++;
            name = "Кидала_" + count;
        }
        protected override TraideSolution Solution
        {
            get
            {
                if (rnd.Next(100) < 5)
                {
                    return TraideSolution.Честная_сделка;
                }
                else
                {
                    return TraideSolution.Сжульничать;
                }
            }
        }
    }
}
