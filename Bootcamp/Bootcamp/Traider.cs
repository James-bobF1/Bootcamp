using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public abstract class Traider
    {

        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        int money;
        public int Money
        {
            get
            {
                return money;
            }
        }
        protected Random rnd;
        public Traider()
        {
            rnd = new Random();
        }

        public virtual void NewYear()
        {
            money = 0;
        }

        abstract protected TraideSolution Solution
        { get; }

        protected TraideSolution lastOpponentSolution;
        virtual protected TraideSolution LastOpponentSolution
        {
            get
            {
                return lastOpponentSolution;
            }
             set
            {
                lastOpponentSolution = value;
            }
        }

        public static string Traide(Traider firstTraider, Traider secondTraider)
        {
            TraideSolution firstTraiderSolution = firstTraider.Solution;
            TraideSolution secondTraiderSolution = secondTraider.Solution;
            firstTraider.LastOpponentSolution = secondTraiderSolution;
            secondTraider.LastOpponentSolution = firstTraiderSolution;
            string traideResult;
            if (firstTraiderSolution == secondTraiderSolution)
            {
                if (firstTraiderSolution == TraideSolution.Честная_сделка)
                {
                    firstTraider.money += 4;
                    secondTraider.money += 4;
                    traideResult = String.Format("{0} +4 vs {1} +4", firstTraider.name, secondTraider.name);
                }
                else
                {
                    firstTraider.money += 2;
                    secondTraider.money += 2;
                    traideResult = String.Format("{0} +2 vs {1} +2", firstTraider.name, secondTraider.name);
                }
            }
            else if (firstTraiderSolution == TraideSolution.Честная_сделка)
            {
                firstTraider.money += 1;
                secondTraider.money += 5;
                traideResult = String.Format("{0} +1 vs {1} +5", firstTraider.name, secondTraider.name);
            }
            else
            {
                firstTraider.money += 5;
                secondTraider.money += 1;
                traideResult = String.Format("{0} +5 vs {1} +1", firstTraider.name, secondTraider.name);
            }
                return traideResult;
        }

        public override string ToString()
        {
            return String.Format("{0}[{1}]",name,money);
        }
    }
}
