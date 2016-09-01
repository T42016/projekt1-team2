using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Försätts : Form
    {
        private Quiz quiz;
        public static string path = (Environment.CurrentDirectory + @"\..\..\..\quizzes\");
        public Försätts()
        {
            
            InitializeComponent();
        }

        private void BiologiLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            List<Question> Biologi = ReadQuestions("Biologi");

            quiz = new Quiz(Biologi);
            quiz.Closed += Q_Closed;
            quiz.Show();
            this.Hide();
        }


        

        private void GeografiLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Question> Geografi = ReadQuestions("Geografi");

            quiz = new Quiz(Geografi);
            quiz.Closed += Q_Closed;
            quiz.Show();
            this.Hide();
        }

        private void HistoriaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Question> Historia = ReadQuestions("Historia");

            quiz = new Quiz(Historia);
            quiz.Closed += Q_Closed;
            quiz.Show();
            this.Hide();
        }

        private void DataLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Question> Tvspel = ReadQuestions("Tvspel");

            quiz = new Quiz(Tvspel);
            quiz.Closed += Q_Closed;
            quiz.Show();
            this.Hide();
        }

        private void TeknikLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Question> Teknik = ReadQuestions("Teknik");

            quiz = new Quiz(Teknik);
            quiz.Closed += Q_Closed;
            quiz.Show();
            this.Hide();
        }
        private void Q_Closed(object sender, EventArgs e)
        {
            if (quiz.DialogResult == DialogResult.Abort)
                Close();
            else if (quiz.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        public static List<Question> ReadQuestions(string category)
        {
            List<Question> questions = new List<Question>();

            if (File.Exists(path + category + ".txt"))
            {
                TextReader tr = new StreamReader(path + category + ".txt");
                int i = 0;
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    questions.Add(new Question(line, tr.ReadLine(), tr.ReadLine(), tr.ReadLine(), tr.ReadLine()));
                    i++;
                }

                tr.Close();
            }

            return (questions);
        }
        private void Försätts_Load(object sender, EventArgs e)
        {

        }
    }
}
