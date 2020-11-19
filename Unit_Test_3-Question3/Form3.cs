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
    public partial class Form3 : Form
    {
        // Reference form1.
        Form1 refForm1;
        private string secretCode = "89126743";
        public Form3(Form1 original)
        {
            InitializeComponent();
            refForm1 = original;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            refForm1.BackColor = Color.Coral;
            label1.Text = "Hint: The secret code is 89126743";
        }

        private void Return_To_Form(object sender, EventArgs e)
        {
            

            if (hackBox.Enabled && hackBox.Text == secretCode && security.Checked)
            {
                refForm1.BackColor = Color.DarkGreen;
                int overrideNum = 1;
                var brief = new Form2("XXXX", overrideNum, refForm1);
                brief.Show();
            } else
            {
                refForm1.Width = 100;
                refForm1.BackColor = Color.Red;
                this.Close();
            }
            
        }

        private void Attempt_Hack(object sender, EventArgs e)
        {
            hackBox.Enabled = true;
        }
    }
}
