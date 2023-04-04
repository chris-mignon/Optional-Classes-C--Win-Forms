using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        const double CLASSA = 15;
        const double CLASSB = 12;
        const double CLASSC = 9;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Custom Method to calculate the total revenue.
        /// </summary>
        public double CalIncome(double ca, double cb, double cc)
        {
            double income= ((ca*CLASSA)+ (cb* CLASSB) + (cc*CLASSC));
            return income;
        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            if ((ClassAbox.Text.Length> 0 && ClassBbox.Text.Length > 0 
                && Classcbox.Text.Length > 0)
                && ( Double.TryParse(ClassAbox.Text,out double ca) 
                && Double.TryParse(ClassBbox.Text, out double cb) 
                && Double.TryParse(Classcbox.Text, out double cc)))
            {
                 Outputbox.Text =  "Total Income--$:"+Convert.ToString(this.CalIncome(ca, cb, cc));
                
            }

        }

       
    }
}
