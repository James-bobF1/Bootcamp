using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void bcalculateBestTraider_Click(object sender, EventArgs e)
        {
            guild = new Traider[(int)nTraiders.Value];
            int pointer = 0;
            for (decimal i = 0; i < naltruist.Value; i++)
            {
                guild[pointer] = new Altruist();
            }
        }

        decimal TraidersNewValue
        {
            get
            {
                return naltruist.Value + ncheater.Value + ndodger.Value + nmyOwn.Value + nquirky.Value + nrandomTraider.Value + nvindictive.Value;
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
                        || decreateNumeric(nquirky) || decreateNumeric(nmyOwn)))
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
                        if (numeric.Name != nTraiders.Name)
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
                    case 6:
                        {
                            nmyOwn.Value++;
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
