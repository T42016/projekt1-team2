using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] category = new string[5];
            category[0] = "biologi";
            category[1] = "geografi";
            category[2] = "historia";
            category[3] = "tvspel";
            category[4] = "teknik";

            string[] frågor = new string[15];
            frågor[0] = "1. Vad är medellivslängden på en blåval?";
            frågor[1] = "2. Vad är de tre centrala greppen inom biologi?";
            frågor[2] = "3. Hur många ben har en människa?";
            frågor[3] = "1. Vad är världens minsta land?";
            frågor[4] = "2. Katmandu är huvudstaden för:?";
            frågor[5] = "3. Hur många invånare har Sverige under 2016?";
            frågor[6] = "1. När skedde tjernobyl-olyckan?";
            frågor[7] = "2. Hur länge varade det amerikanska innbördeskriget?";
            frågor[8] = "3. Vem blev ledare av Frankrike efter franska revolutionen?";
            frågor[9] = "1. Vad hette det första dataspelet?";
            frågor[10] = "2. Den mest sålda konsolen är playstation 2. Hur många exemplar sålde den?";
            frågor[11] = "3. När skedde spelkraschen?";
            frågor[12] = "1. Den teknik som användes för att landa första gången på månen är i förhållande till?";
            frågor[13] = "2. Vilka av dessa uppfinningar var inte uppfunna under 1900-talet?";
            frågor[14] = "3. Vad var den första datorn gjord på elektronik?";

            List<Question> answers = new List<Question>();
            answers.Add(new Question(frågor[0], "80-90", "70-80", "140-150", "30-40"));
            answers.Add(new Question(frågor[1], "Cellen, Evolutionen och Genetiken", "Botanik, Fenologi och zoologi", "Biomedicin, Systembiologi och Anatomi", "Histologi, Fysiologi och Etologi"));
            answers.Add(new Question(frågor[2], "220", "250", "150", "300"));
            answers.Add(new Question(frågor[3], "Vatikanstaten", "Monaco", "Marshallöarna", "Nauru"));
            answers.Add(new Question(frågor[4], "Nepal", "Mongoliet", "Laos", "Thailand"));
            answers.Add(new Question(frågor[5], "9,9 miljoner", "9,8 miljoner", "10,1 miljoner", "9,5 miljoner"));
            answers.Add(new Question(frågor[6], "26 april 1986", "27 oktober 1986", "21 maj 1986", "15 september 1985"));
            answers.Add(new Question(frågor[7], "4 år", "6 år", "10 år", "3 år"));
            answers.Add(new Question(frågor[8], "Napoleon Bonaparte", "Ludvig XVIII", "Maximilien de Robespierre", "Paul Barras"));
            answers.Add(new Question(frågor[9], "Space wars", "Tennis for two", "Pong", "OXO"));
            answers.Add(new Question(frågor[10], "155 miljoner", "200 miljoner", "90 miljoner", "35 miljoner"));
            answers.Add(new Question(frågor[11], "1983", "1985", "1979", "1981"));
            answers.Add(new Question(frågor[12], "Den första iphonen", "Den första datorn", "Den första mobiltelefonen", "Den första Ipoden"));
            answers.Add(new Question(frågor[13], "Bilar", "Datorer", "internet", "mikroskop"));
            answers.Add(new Question(frågor[14], "ENIAC", "ABC", "EDSAC", "Z1"));
            answers[0].ShuffleAnswers();
            answers[1].ShuffleAnswers();
            answers[2].ShuffleAnswers();
            answers[3].ShuffleAnswers();
            answers[4].ShuffleAnswers();
            answers[5].ShuffleAnswers();
            answers[6].ShuffleAnswers();
            answers[7].ShuffleAnswers();
            answers[8].ShuffleAnswers();
            answers[9].ShuffleAnswers();
            answers[10].ShuffleAnswers();
            answers[11].ShuffleAnswers();
            answers[12].ShuffleAnswers();
            answers[13].ShuffleAnswers();
            answers[14].ShuffleAnswers();
            
            btnSvar.Text = answers[0].answers[0];
            btnSvar2.Text = answers[0].answers[1];
            btnSvar3.Text = answers[0].answers[2];
            btnSvar4.Text = answers[0].answers[3];
        }
    }
}
    class Question
    {
        private Random r = new Random();
        public string query;
        public string rightAnswer { get; private set; }
        private string wrongAnswer1;
        private string wrongAnswer2;
        private string wrongAnswer3;
        public List<string> answers;
        public Question(string query, string rightAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        {
            this.query = query;
            this.rightAnswer = rightAnswer;
            this.wrongAnswer1 = wrongAnswer1;
            this.wrongAnswer2 = wrongAnswer2;
            this.wrongAnswer3 = wrongAnswer3;
            answers = new List<string>();
            answers.Add(rightAnswer);
            answers.Add(wrongAnswer1);
            answers.Add(wrongAnswer2);
            answers.Add(wrongAnswer3);

            // answers = Scramble(answers);
        }

        private List<string> Scramble(List<string> list)
        {
            List<string> l = new List<string>();
            l.Add(list[0]);
            l.Add(list[1]);
            l.Add(list[2]);
            l.Add(list[3]);

            for (int i = 0; i < list.Count; i++)
            {

                int temp2 = r.Next(0, l.Count);

                list[l.Count - 1] = l[temp2];

                l.RemoveAt(temp2);


            }

            return (list);
        }
        public void ShuffleAnswers()
        {
            answers = Scramble(answers);
        }

    }
