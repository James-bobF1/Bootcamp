using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public abstract class Traider
    {

        string name;
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
        public Traider(string name)
        {
            this.name = name;
        }

        public void NewYear()
        {
            money = 0;
        }

        abstract public TraideSolution Solution
        { get; }

        public static void Traide(Traider firstTraider, Traider secondTraider)
        {
            TraideSolution firstTraiderSolution = firstTraider.Solution;
            TraideSolution secondTraiderSolution = secondTraider.Solution;
            if (firstTraiderSolution == secondTraiderSolution)
            {
                if (firstTraiderSolution == TraideSolution.Честная_сделка)
                {
                    firstTraider.money += 4;
                    secondTraider.money += 4;
                }
                else
                {
                    firstTraider.money += 2;
                    secondTraider.money += 2;
                }
            }
            else if (firstTraiderSolution == TraideSolution.Честная_сделка)
            {
                firstTraider.money += 1;
                secondTraider.money += 5;
            }
            else
            {
                firstTraider.money += 5;
                secondTraider.money += 1;
            }
        }
    }
}
