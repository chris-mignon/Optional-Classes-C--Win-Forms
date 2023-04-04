using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random rand = new Random();
        const int SIZE = 10;
        int Score, oc,val1,val2,val3;
        static int index = 0;
        
        int[] Questions = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static string[] Operators = { "+","-","x", "÷" };
       
        /// <summary>
        /// Custom method to hide the buttons when the app starts
        /// and when a new game begins.
        /// </summary>
        void Hidebtns()
        {
            
            button3.Visible = false;
        }

        /// <summary>
        /// Custom method to show the buttons after the game is finished.
        /// </summary>
        void Showbtns()
        {
            
            button3.Visible = true;
        }
        /// <summary>
        /// Custom method to start the game.
        /// </summary>
        void Shuffle()
        {
            oc = rand.Next(0, 4);
        }
        void ShowScore()
        {
            MessageBox.Show("Your Score is: "+ Score.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hidebtns();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0 && Int32.TryParse(textBox3.Text, out int answer))
            {
                switch (oc)
                {
                    case 0: val3 = val1 + val2; break;
                    case 1: val3 = val1 - val2; break;
                    case 2: val3 = val1 * val2; break;
                    case 3: val3 = val1 / val2; break;

                }
                if (answer == val3)
                {
                    Score++;
                }

            }
            textBox3.Clear();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            BtnStart.Text = "Restart";
            BtnStart.ForeColor = Color.DarkGreen;
            LblQue.Text = "Question:" + Convert.ToString(this.Questions[0]);
            this.Score = 0;
            index = 0;
            progressBar1.Value = 0;
        }

        private void LblQue_TextChanged(object sender, EventArgs e)
        {
            val1 = rand.Next(0, 100);
            val2 = rand.Next(0, 100);

            textBox1.Text = val1.ToString();
            textBox2.Text = val2.ToString();
            Shuffle();
            LblOperator.Text = Operators[oc];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            if (index < 10)
            {
                progressBar1.Value += 10;
                
                LblQue.Text = "Question:" + Convert.ToString(this.Questions[index++]);
            }
            else
            {
                ShowScore();
                Showbtns();
                
            }
        }
    }
}
