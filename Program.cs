
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            using System;
            using System.IO;
            {
            InitializeComponent();
        }

        private void Grade(object sender, EventArgs e)
        {

            string line;
            int cnt = 0;

            //List to hold question numbers of incorrect answers
            List<int> incorrect = new List<int>();

            string[] correctAnswers = { };
            string[] answers = { };

            //Read the files and store answers in arrays
            System.IO.StreamReader answerFile = new System.IO.StreamReader("C:\Users\Jacob T Gotcher\Desktop\studentdata.txt");
            System.IO.StreamReader correctFile = new System.IO.StreamReader("C:\Users\Jacob T Gotcher\Desktop\AnswerKey.txt");

            if ((line = correctFile.ReadLine()) != null)
                correctAnswers = line.Split(' ');

            if ((line = answerFile.ReadLine()) != null)
                answers = line.Split(' ');

                //Compare answers and compute the score
                for (int i = 0; i < line.length; i++)
                {
                    if (correctAnswers.Count() > i && answers.Count() > i)
                    {
                        if (String.Compare(correctAnswers[i], answers[i]) == 0)
                            cnt++;
                        else
                            incorrect.Add(i + 1);
                    }
                }

                //Print Result
                if (cnt >= 15)
                    MessageBox.Show("\n\n Result: PASS");
                else
                    MessageBox.Show("\n\n Result: FAIL");

                //Printing score
                MessageBox.Show("\n Total number of Correct Answers: " + cnt);
                MessageBox.Show("\n Total number of Incorrect Answers: " + (20 - cnt));

                MessageBox.Show("\n Question numbers of incorrect answers: ");
                //Printing incorrectly answered question numbers
                foreach (int qno in incorrect)
                    MessageBox.Show(" " + qno + " ");

                //Closing Files
                correctFile.Close();
                answerFile.Close();


            }
        }
    }
