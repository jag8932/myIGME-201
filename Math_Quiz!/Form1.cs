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
    /* 
     Name: Jacob Goodwillie
     Desc: This math quiz checks your answer to randomly generated questions.
     If your answer is correct, you get a nice picture. If your answer is incorrect
     you get a stern picture. You have five seconds to answer a question. Failure to
     answer in time will result in an incorrect question. Your score will be posted.
     */
    public partial class Form1 : Form
    {
        public string myName;
        public string[] operators = {"+", "-", "*", "/"};
        public decimal numQuestions;
        public decimal totalQuestions;
        public string answer;
        public int timeUnit;
        public int totalSec;
      //  public decimal score;
        public bool key1 = false;
        public bool key2 = false;
        public bool key3 = false;
        public bool key4 = false;
        public bool isCorrect = false;
        public decimal gotWrong = 0;
        public decimal gotRight = 0;
        Random ranNum = new Random();
        public int questionAnswer;
        // Enum for the difficulty setting. Good way to implement states in c#.
        public enum Difficulty
        {
            easy,
            medium,
            hard
        }
        public Difficulty level = Difficulty.medium;
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
                key1 = true;
            }
        }
        // These event handlers change the level based on the selected radio button.
        private void Change_Easy(object sender, EventArgs e)
        {
            level = Difficulty.easy;
            key2 = true;
        }

        private void Change_Medium(object sender, EventArgs e)
        {
            level = Difficulty.medium;
            key2 = true;
        }

        private void Change_Hard(object sender, EventArgs e)
        {
            level = Difficulty.hard;
            key2 = true;
        }
        // Finalizes the third step in starting the quiz. Turns the decimal
        // into a whole number.
        private void Set_NumQuestions(object sender, EventArgs e)
        {
            numQuestions = numericUpDown1.Value;
            numQuestions = Math.Ceiling(numQuestions);
            if (numericUpDown1.Value > 0)
            {
                key3 = true;
            } else
            {
                key3 = false;
            }
        }
        // Make sure that all objects below the quiz line are visible. Begin 
        // quiz.
        private void Generate_Problems(object sender, EventArgs e)
        {
            if (key1 && key2 &&key3 && key4)
            {
                label4.Visible = true;
                problemSet.Visible = true;
                problemSet.Enabled = true;
                problemsLeft.Visible = true;
                problemsLeft.Text = numQuestions.ToString();
                this.totalQuestions = numQuestions;
                warning.Visible = false;
                answerBox.Enabled = true;
                answerLabel.Text = answer;
                submitAnswer.Enabled = true;
                submitAnswer.Visible = true;
                feedbackMsg.Visible = true;
                this.timer1.Interval = 1;
                Update(numQuestions);
            } else
            {
                warning.Visible = true;
            }
        }
        // Generates random problems based on the selected difficulty.
        // Returns the operation if needed but can also just set
        // the problem text if called normally.
        public string Random_Problems()
        {
            int value1 = 0;
            int value2 = 0;
            int value3 = 0; 
            double operation = value1 + value2;
            if (level == Difficulty.easy) {
            value1 = ranNum.Next(1, 26);
            value2 = ranNum.Next(1, 26);
            value3 = ranNum.Next(0, 2);
            } else if (level == Difficulty.medium) {
            value1 = ranNum.Next(1, 36);
            value2 = ranNum.Next(1, 36);
            value3 = ranNum.Next(0, 4);
            } else if (level == Difficulty.hard) {
            value1 = ranNum.Next(1, 51);
            value2 = ranNum.Next(1, 51);
            value3 = ranNum.Next(0, 4);
            }
            if (operators[value3] == "+") {
                operation = value1 + value2;
                problemSet.Text = value1.ToString() + " + " + value2.ToString();
             } else if (operators[value3] == "-")
            {
                operation = value1 - value2;
                problemSet.Text = value1.ToString() + " - " + value2.ToString();
            } else if (operators[value3] == "*")
            {
                operation = value1 * value2;
                problemSet.Text = value1.ToString() + " * " + value2.ToString();
            } else if (operators[value3] == "/")
            {
                operation = value1 / value2;
                problemSet.Text = value1.ToString() + " / " + value2.ToString();
            }
            
            return operation.ToString();
        }
        // Update problems and timer.
        private void Update(decimal numQuestions)
        {
            this.timer1.Enabled = true;
            this.timer1.Start();
            Random_Problems(); //Calling this function without assigning a variable to it will print the problem set.
            answer = Random_Problems();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            this.timeUnit -= 1;
            if (this.timeUnit <= 0)
            {
                wrongAnswer("You ran out of time wow!");
                this.timeUnit = this.totalSec;
            }   
            
        }
        // Checks answer entered by user
        private void submitAnswer_Click(object sender, EventArgs e)
        {
            if (answerBox.Text == answer)
            {
               if(this.numQuestions > 0)
                {
                    rightAnswer();
                }
            } else
            {
                this.timer1.Stop();
                if (this.numQuestions > 0) {
                    wrongAnswer();
                }
                

            }
        }
        // Displays stern image and starts next generation of questions.
        private void wrongAnswer(string msg = "Incorrect. The answer is")
        {
            Image img = Image.FromFile("C:\\github\\jag8932\\Math_Quiz!\\picard-facepalm.jpg");
            pictureBox1.Image = img;
            this.timeUnit = 0;
            this.progressBar1.Value = 0;
            feedbackMsg.Text = msg;
            answerLabel.Text = answer;
            answerLabel.Visible = true;
            this.pictureBox1.Visible = true;
            gotWrong += 1;
            this.timer1.Stop();
            this.gotoNext();
        }

        //Displays good image and starts next generation of questions.
        private void rightAnswer()
        {
            this.pictureBox1.Visible = true;
            Image img = Image.FromFile("C:\\github\\jag8932\\Math_Quiz!\\good-job.jpg");
             pictureBox1.Image = img;
            feedbackMsg.Text = "Correct answer!";
            answerLabel.Text = "";
            answerLabel.Visible = false;
            gotRight += 1;
            this.progressBar1.Value = 0;
            this.timer1.Stop();
            this.timeUnit = this.totalSec;
            this.gotoNext();
        }
        // Start next generation of questions if there are still questions left.
        // Text is green if you pass the quiz and red if you don't.
        public void gotoNext()
        {
            this.timer1.Start();
            this.answerBox.Text = "";
            this.numQuestions -= 1;
            problemsLeft.Text = numQuestions.ToString();
            if (this.numQuestions > 0)
            {
                this.Update(numQuestions);
            }
            else
            {
                this.progressBar1.Visible = false;
                decimal compareRatio = (this.gotRight/this.totalQuestions);
                this.answerLabel.Visible = false;
                progressBar1.Increment(0);
                feedbackMsg.Text = "Quiz over " + this.myName + "! You scored: " + this.gotRight + "/" + this.totalQuestions;
                if(compareRatio > .6m)
                {
                    feedbackMsg.BackColor = Color.Green;
                } else if (compareRatio < .6m)
                {
                    feedbackMsg.BackColor = Color.Red;
                    answerLabel.Visible = true;           
                }
            }
        }
        // Get seconds for timer.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int seconds;
            if (int.TryParse(textBox2.Text, out seconds))
            {
                this.key4 = true;
                this.totalSec = seconds * 50;
                this.timeUnit = seconds * 50;
            }
        }
    }
}
