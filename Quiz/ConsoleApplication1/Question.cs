using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Question
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
}
