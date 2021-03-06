﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bootcamp
{
    public partial class Form1 : Form
    {
        Traider[] guild;
        public Form1()
        {
            InitializeComponent();
            traidersOldValue = nTraiders.Value;
        }

        private int InitialGuild()
        {
            guild = new Traider[(int)nTraiders.Value];
            int pointer = 0;// можно написать и использовать фабрику, но т.к. стратегий конечное число и они не формируются динамически не стал
            for (decimal i = 0; i < naltruist.Value; i++)
            {
                guild[pointer++] = new Altruist();
            }
            for (decimal i = 0; i < ncheater.Value; i++)
            {
                guild[pointer++] = new Cheater();
            }
            for (decimal i = 0; i < ndodger.Value; i++)
            {
                guild[pointer++] = new Dodger();
            }
            for (decimal i = 0; i < nrandomTraider.Value; i++)
            {
                guild[pointer++] = new RandomTrainer();
            }
            for (decimal i = 0; i < nvindictive.Value; i++)
            {
                guild[pointer++] = new Vindictive();
            }
            for (decimal i = 0; i < nquirky.Value; i++)
            {
                guild[pointer++] = new Quirky();
            }
            //оптимальная стратегия всегда жульничать. т.к. 1+4<2+5
            return pointer;
        }

        private void bcalculateBestTraider_Click(object sender, EventArgs e)
        {
            int pointer = InitialGuild();
            Random rnd=new Random();
            Graphics formGraphic = this.CreateGraphics();
            Font aFont = new Font("Tahoma", 12, FontStyle.Regular);
            Random rndColor = new Random();
            decimal years = nYears.Value;
            while (years >0)
            {
                //formGraphic.Clear(Form1.DefaultBackColor);
                for (int i = 0; i < (10 - 5) / 2 * (pointer-1); i++)
                {
                    if (i % 20 == 0)
                    {
                        formGraphic.Clear(Form1.DefaultBackColor);
                    }
                    string log = Traider.Traide(guild[rnd.Next(pointer)], guild[rnd.Next(pointer)]);
                    //Thread.Sleep(700);                    
                }
                //Thread.Sleep(1000);
                formGraphic.Clear(Form1.DefaultBackColor);
                Array.Sort(guild, delegate(Traider first, Traider second)
                { return -first.Money + second.Money; }
                );
                formGraphic.DrawString("Top 20 Traiders year " + (nYears.Value-years+1), aFont, Brushes.Red, 280, 40);
                for (int i = 0; i < pointer/3; i++)
                {
                    formGraphic.DrawString(guild[i].ToString(), aFont, Brushes.Green, 240, 60+20*i);
                }
                for (int i = 0; i < pointer / 3; i++)
                {
                    guild[pointer - pointer / 3 + i] = (Traider)(guild[i].GetType().GetConstructor(new Type[]{}).Invoke(new object[]{}));
                }
                for (int i = 0; i < pointer; i++)
                {
                    guild[i].NewYear();
                }
                years--;
                Thread.Sleep(2000);                
            }
        }


        decimal TraidersNewValue
        {
            get
            {
                return naltruist.Value + ncheater.Value + ndodger.Value  + nquirky.Value + nrandomTraider.Value + nvindictive.Value;
            }
        }

        decimal traidersOldValue;
        private void nTraiders_ValueChanged(object sender, EventArgs e)
        {
            if (nTraiders.Value > traidersOldValue)
            {
                naltruist.Value += nTraiders.Value - traidersOldValue;
            }
            else
            {
                while (traidersOldValue-nTraiders.Value > 0)
                {
                    if (!(decreateNumeric(naltruist) || decreateNumeric(ncheater) || decreateNumeric(ndodger)
                        || decreateNumeric(nrandomTraider) || decreateNumeric(nvindictive)
                        || decreateNumeric(nquirky)))
                    {
                        throw new ArgumentOutOfRangeException("Can't decreate any Traiders Types");
                    }
                }                
            }
            traidersOldValue = nTraiders.Value;
        }

        private bool decreateNumeric(NumericUpDown numeric)
        {
            if (numeric.Value > numeric.Minimum)
            {
                if (numeric.Value - numeric.Minimum > nTraiders.Value - traidersOldValue)
                {
                    numeric.Value = numeric.Value - numeric.Minimum - traidersOldValue + nTraiders.Value;
                    traidersOldValue = nTraiders.Value;
                }
                else
                {
                    traidersOldValue = traidersOldValue - numeric.Value + numeric.Minimum;
                }
                return true;
            }
            return false;
        }
       
        private void anyTraiders_ValueChanged(object sender, EventArgs e)
        {
            nTraiders.ValueChanged -= nTraiders_ValueChanged;
            nTraiders.Value+= TraidersNewValue - nTraiders.Value;
            nTraiders.ValueChanged += nTraiders_ValueChanged;
        }

        private void cbtraiderEquials_CheckedChanged(object sender, EventArgs e)
        {
            decimal size = nTraiders.Value;
            if (cbtraiderEquials.Checked)
            {
                foreach(Control numeric in this.Controls)
                {
                    if (numeric.GetType() == typeof(NumericUpDown))
                    {
                        if (numeric.Name != nTraiders.Name&&numeric.Name!=nYears.Name)
                        {
                            ((NumericUpDown)numeric).Value = ((NumericUpDown)numeric).Minimum;
                            numeric.Enabled = false;
                        }
                    }                    
                }
            }
            else
            {
                foreach (Control numeric in this.Controls)
                {
                    if (numeric.GetType() == typeof(NumericUpDown))
                    {
                        numeric.Enabled = true;
                    }
                }
                return;
            }
            int countOfTypes = 6;
            Random rnd = new Random();
            for (decimal i = 0; i < size; i++)
            {
                switch (rnd.Next(countOfTypes))
                {
                    case 0:
                        {
                            naltruist.Value++;
                            break;
                        }
                    case 1:
                        {
                            ncheater.Value++;
                            break;
                        }
                    case 2:
                        {
                            ndodger.Value++;
                            break;
                        }
                    case 3:
                        {
                            nrandomTraider.Value++;
                            break;
                        }
                    case 4:
                        {
                            nvindictive.Value++;
                            break;
                        }
                    case 5:
                        {
                            nquirky.Value++;
                            break;
                        }
                    default:
                        {
                            throw new NotSupportedException("Something wrong");//add new case if you need
                        }
                }
            }
        }
    }
}
