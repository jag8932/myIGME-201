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
    public partial class Form2 : Form
    {
        public string name;
        Form1 original;
        public Form2(string name, int num, Form1 originalForm)
        {
            original = originalForm;
            this.name = name;
            InitializeComponent();
            this.agentName.Text = this.name;
            matrix.Visible = false;

            if (num == 1)
            {
                this.BackColor = Color.DarkGreen;
                matrix.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            original.ForeColor = Color.White;
            this.Close();
        }
    }
}
