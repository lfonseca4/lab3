using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab3
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent(); Random rand = new Random();
            int V1 = rand.Next(10);
            int V2 = rand.Next(10); 
            int product = V1 * V2;
        }
        

     
        private int score = 0;
        private int product = 0;
        private int answer = 0;
        private int count;
        Timer timer1 = new Timer();
      




        private void SubmitButton_Click(object sender, EventArgs e)
        {
      
            try
            {
                
               answer = int.Parse(AnswerTextBox.Text);
               Random rand = new Random();
               int V1 = rand.Next(10);
               int V2 = rand.Next(10);
               int product = V1*V2;
                
                if (answer==product)
                {
                

                    MessageBox.Show("Correct!");
                   // count += 20;

                    //ScoreLabel.Text = "Score" + count.ToString();

                }
                else
                {
                    MessageBox.Show("Sorry, your answer is incorrect!");
                }

            }
            catch
            {
                MessageBox.Show("There was an error processing your answer!");
            }

        }



        private void NewButton_Click(object sender, EventArgs e)
        {

            {
            Random rand = new Random();
            int var1 = rand.Next(10);
            int var2 = rand.Next(10);
            int product = var1 * var2;
            string str = "What is:";
            PromptLabel.Text = str + "  " + var1 + " x " + var2; }

           
            //for (int count =10; count <= 10; count--) ;
            {
                MessageBox.Show("You have" + " " + count  + " " + "secs left!");
            }



        }




        private void Lab3_Load(object sender, EventArgs e)
        {

        }

        private void PromptLabel_Click(object sender, EventArgs e)
        {
          /*  Random rand = new Random();
            int var1 = rand.Next(10);
            int var2 = rand.Next(10);
            PromptLabel.Text = var1.ToString();
            PromptLabel.Text = var2.ToString();
            */
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {
            
            TimeLabel.Text = "Time:" + count.ToString();
          
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

            ScoreLabel.Text = "Score" + count.ToString();
        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
