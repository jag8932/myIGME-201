using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Test_3_Question3
{
    public partial class Form1 : Form
    {
        // Name: Jacob Goodwillie
        // Date: 11/18/2020
        // Description: Ugly looking form that does weird things.
        // The theme is CIA and you can either hack into an account using
        // a code or enter a code the correct way.

        private string agentName;
        private bool stage1 = false;
        public Form1()
        {
            
            InitializeComponent();
        }


        private void To_Briefing(object sender, EventArgs e)
        {
            if (stage1)
            {
                var brief = new Form2(agentName, 0, this);
                brief.Show();
            } else
            {
                var error = new Form3(this);
                error.Show();
            }
        }

        private void Log_Out(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Get_Code(object sender, EventArgs e)
        {
            if (nameBox.TextLength > 1)
            {
                this.agentName = nameBox.Text;
                Code.Text = Scramble_Code(this.agentName);
                Code.ForeColor = Color.Green;
                Code.BackColor = Color.Black;
                stage1 = true;
            } else
            {
                Code.Text = "Enter a valid name.";
                Code.ForeColor = Color.Red;
                stage1 = false;
            }
        }

        // Scrambles user name into code.
        private string Scramble_Code(string code)
        {
            char[] codets = new char[code.Length];
            string stringHold = "";
            Random r = new Random();
            
            for (int i = 0; i < code.Length; i++)
            {
                
                    int num = r.Next(0, code.Length);
                    codets[i] = code[num];
                 if (codets[i] != ' ') { 
                    stringHold += codets[i];
                }
            }
            return stringHold;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int num = r.Next(0, 400);

            groupBox1.Location = new Point(num, num);
            if (radioButton1.Checked)
            {
                groupBox1.BackColor = Color.Gold;
            } else if (radioButton2.Checked)
            {
                groupBox1.Text += "errr";
            } else if (radioButton3.Checked)
            {
                panel1.Location = new Point(panel1.Left - 1, panel1.Left + 3);
            }
            
        }
    }
}
