using System;
using System.Windows.Forms;

namespace Kilometer_Converter
{
    public partial class mainPage : Form
    {

        public double milesVal =0;
        public double KilometerVal =0;
        public mainPage()
        {
            InitializeComponent();
        }

        private void KilometerBox_TextChanged(object sender, EventArgs e)
        {
            if (KilometerBox.Text.Length > 0 && Double.TryParse(KilometerBox.Text, out KilometerVal))
            {

                milesVal = KilometerVal * 0.6214;
                MilesBox.Text = milesVal.ToString();
            }
            else if(KilometerBox.Text.Length == 0)
            {
                MilesBox.Clear();
            }
        }
    }
}
