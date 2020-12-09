using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PositiveOrNegative
{
    public partial class Form1 : Form
    {
        public Random ranNum = new Random();
        public string[] positiveReward = {
        
        "You're the best!",
        "You're amazing, no one is better than you!",
        "I don't care what anyone says, you are better than your classmates",
        "Congrats on pulling an all nighter, sure your mental health is ruined but atleast you'll" +
         " get a passing grade!",
        "You actually made it this far!? Who wold have guessed?"
        };
        public string[] negativeReward = { 
        "You don't suck!",
        "Congrats I guess.",
        "meh.",
        "For once you didn't mess up. Oh wait you did.",
        "You aren't dumb?",
        "You did it! You won't be working at McDonalds now!",
        };
        //You have to insert your own filepath so it works on your computer
        public string[] positive =
        {
            @"C:\github\jag8932\PositiveOrNegative\positive\pos1.png",
             @"C:\github\jag8932\PositiveOrNegative\positive\pos2.png",
              @"C:\github\jag8932\PositiveOrNegative\positive\pos3.png",
               @"C:\github\jag8932\PositiveOrNegative\positive\pos4.png",
                @"C:\github\jag8932\PositiveOrNegative\positive\pos5.png",
        };
        public string[] negative =
        {
            @"C:\github\jag8932\PositiveOrNegative\positive\neg1.png",
             @"C:\github\jag8932\PositiveOrNegative\positive\neg2.png",
              @"C:\github\jag8932\PositiveOrNegative\positive\neg3.png",
               @"C:\github\jag8932\PositiveOrNegative\positive\neg4.png",
                @"C:\github\jag8932\PositiveOrNegative\positive\neg5.png",
        };
        public int selector;
        public string phrase;
        public int chooser;
     
        public Form1()
        {
            InitializeComponent();
            this.reinforcementTag.Text = getReinforcement();
        }

        public string getReinforcement()
        {
            chooser = ranNum.Next(1, 3);
            
            //Chooser == 1 is for negative
            if (chooser == 1)
            {
                this.pictureBox1.Image = Image.FromFile(negative[ranNum.Next(0, negative.Length)]);
                selector = ranNum.Next(1, negativeReward.Length);
                this.phrase = negativeReward[selector];
                this.reinforcementTag.ForeColor = Color.Red;
            }
            //Chooser == 1 is for positive
            else if (chooser == 2)
            {
                this.pictureBox1.Image = Image.FromFile(positive[ranNum.Next(0, positive.Length)]);
                selector = ranNum.Next(1, positiveReward.Length);
                this.phrase = positiveReward[selector];
                this.reinforcementTag.ForeColor = Color.Green;
            }
            return this.phrase;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
