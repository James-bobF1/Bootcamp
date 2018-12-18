using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public class Altruist:Traider
    {
        static int count;
        public Altruist():base()
        {
            count++;
            name = "Альтруист_" + count;
        }
        public override TraideSolution Solution
        {
            get
            {
                if (rnd.Next(100) < 5)
                {
                    return TraideSolution.Сжульничать;
                }
                else
                {
                    return TraideSolution.Честная_сделка;
                }
            }
        }
    }
}
