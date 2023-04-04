using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roman_Numerals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 
            && Int32.TryParse(textBox1.Text, out int dec))
            {
                label3.Visible = false;
                if ( dec >= 0 && dec<11 )
                {
                    switch (dec)
                    {
                        case 0:
                            textBox2.Text = "0";
                            break;

                        case 1:
                            textBox2.Text = "I";
                            break;

                        case 2:
                            textBox2.Text = "II";
                            break;

                        case 3:
                            textBox2.Text = "III";
                            break;

                        case 4:
                            textBox2.Text = "IV";
                            break;
                        case 5:
                            textBox2.Text = "V";
                            break;

                        case 6:
                            textBox2.Text = "VI";
                            break;

                        case 7:
                            textBox2.Text = "VII";
                            break;

                        case 8:
                            textBox2.Text = "VIII";
                            break;
                        case 9:
                            textBox2.Text = "IX";
                            break;
                        case 10:
                            textBox2.Text = "X";
                            break;
                    }
                }
                else if( dec > 10 )
                {
                    textBox2.Text = "Error ";
                    label3.Text = "Enter a Number in the range 1-10";
                    label3.Visible = true;
                }

              
            }
            else if (textBox1.Text.Length > 0 
            && !Int32.TryParse(textBox1.Text, out dec))
            {
                textBox2.Text = "Error ";
                label3.Text = "Enter a Number in the range 1-10";
                label3.Visible = true;
                
            }
            else if (textBox1.Text.Length == 0)
            {
                label3.Text = "Enter a Number";
                textBox2.Text = "";
                label3.Visible = true;

            }
            else
            {
                label3.Visible = false;
            }
        }
    }
}
