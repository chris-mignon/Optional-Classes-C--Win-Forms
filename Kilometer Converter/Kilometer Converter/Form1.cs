using System;
using System.Windows.Forms;

namespace Kilometer_Converter
{
    public partial class mainPage : Form
    {

        public double milesVal =0;  // global variables
        public double KilometerVal =0;
        public mainPage(){
            InitializeComponent();
        }

        private void KilometerBox_TextChanged(object sender, EventArgs e)
        {

            // if statement only allowing processing to take place when the conditionsare true
            if (KilometerBox.Text.Length > 0
                && Double.TryParse(KilometerBox.Text, out KilometerVal))
            {

                milesVal = KilometerVal * 0.6214;
                MilesBox.Text = milesVal.ToString();
            }
            else if(KilometerBox.Text.Length == 0)
            {
                // else if clause to clear output box when the kilometer box is empty
                MilesBox.Clear();
            }
        }
    }
}
