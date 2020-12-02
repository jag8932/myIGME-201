using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz_
{
    public partial class Form1 : Form
    {
        public string myName;
        enum Difficulty
        {
            easy,
            medium,
            hard
        }
        Difficulty level = Difficulty.medium;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void Enter_Name(object sender, KeyEventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                label1.Text = textBox1.Text;
                myName = textBox1.Text;
            }
        }

        private void Change_Easy(object sender, EventArgs e)
        {
            level = Difficulty.easy;
        }

        private void Change_Medium(object sender, EventArgs e)
        {
            level = Difficulty.medium;
        }

        private void Change_Hard(object sender, EventArgs e)
        {
            level = Difficulty.hard;
        }
    }
}
