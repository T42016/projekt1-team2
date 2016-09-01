using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz

{
   public class questionGenerator
    {
        public static string path = (Environment.CurrentDirectory + @"\..\..\quizzes\");
        static void Generator(string[] args)
        {
            List<Question> questionsBio = new List<Question>();
            questionsBio.Add(new Question("Vad är medellivslängden på en val?", "80-90", "70-80", "140-150", "30-40"));
            questionsBio.Add(new Question("Vad är de tre centrala begreppen inom biologi?", "Cellen, Evolutionen och Genetiken", "Botanik, Fenologi och zoologi", "Biomedicin, Systembiologi och Anatomi", "Histologi, Fysiologi och Etologi"));
            questionsBio.Add(new Question("Hur många ben har en människa?", "220", "250", "150", "300"));
            List<Question> questionsGeo = new List<Question>();
            questionsGeo.Add(new Question("Vad är världens minsta land?", "Vatikanstaten", "Monaco", "Marshallöarna", "Nauru"));
            questionsGeo.Add(new Question("Katmandu är huvudstaden för?", "Nepal", "Mongoliet", "Laos", "Thailand"));
            questionsGeo.Add(new Question("Hur många invånare har Sverige under 2016?", "9,9 miljoner", "9,8 miljoner", "10,1 miljoner", "9,5 miljoner"));
            List<Question> questionsHis = new List<Question>();
            questionsHis.Add(new Question("När skedde Tjernobyl-olykan?", "26 april 1986", "27 oktober 1986", "21 maj 1986", "15 september 1985"));
            questionsHis.Add(new Question("Hur länge varade det amerikanska inbördeskriget?", "4 år", "6 år", "10 år", "3 år"));
            questionsHis.Add(new Question("Vem blev ledare över Frankrike efter franska revolutioen?", "Napoleon Bonaparte", "Ludvig XVIII", "Maximilien de Robespierre", "Paul Barras"));
            List<Question> questionsTv = new List<Question>();
            questionsTv.Add(new Question("Vad hette det första dataspelet?", "Space wars", "Tennis for two", "Pong", "OXO"));
            questionsTv.Add(new Question("Den mest sålda konsolen är playstation 2. Hur många exemplar sålde den?", "155 miljoner", "200 miljoner", "90 miljoner", "35 miljoner"));
            questionsTv.Add(new Question("När skedde spelkraschen?", "1983", "1985", "1979", "1981"));
            List<Question> questionsTek = new List<Question>();
            questionsTek.Add(new Question("Den teknik som användes för att landa första gången på månen är i förhållande till?", "Den första iphonen", "Den första datorn", "Den första mobiltelefonen", "Den första Ipoden"));
            questionsTek.Add(new Question("Vilka av dessa uppfinningar var inte uppfunna under 1900-talet?", "Bilar", "Datorer", "internet", "mikroskop"));
            questionsTek.Add(new Question("Vad var den första datorn gjord på elektronik?", "ENIAC", "ABC", "EDSAC", "Z1"));



            NewQuestions(questionsBio, "Biologi");
            NewQuestions(questionsGeo, "Geografi");
            NewQuestions(questionsHis, "Historia");
            NewQuestions(questionsTv, "Tvspel");
            NewQuestions(questionsTek, "Teknik");
            List<Question> nylista = ReadQuestions("Biologi");

        }
        public static void NewQuestions(List<Question> list2Write,string category)
        {
           
            if (!File.Exists(path + category + ".txt"))
            {
                TextWriter tw = new StreamWriter(path + category + ".txt");
                for (int i = 0; i < list2Write.Count; i++)
                {

                    tw.WriteLine(list2Write[i].query);
                    tw.WriteLine(list2Write[i].answers[0]);
                    tw.WriteLine(list2Write[i].answers[1]);
                    tw.WriteLine(list2Write[i].answers[2]);
                    tw.WriteLine(list2Write[i].answers[3]);
                   
                }
                tw.Close();
            }
            else
            {
                TextWriter tw = new StreamWriter(path + category + ".txt");

                for (int i = 0; i < list2Write.Count; i++)
                {
                    tw.WriteLine(list2Write[i].query);
                    tw.WriteLine(list2Write[i].answers[0]);
                    tw.WriteLine(list2Write[i].answers[1]);
                    tw.WriteLine(list2Write[i].answers[2]);
                    tw.WriteLine(list2Write[i].answers[3]);
                    
                }
                tw.Close();
            }

        }
        public static void AddQuestions(List<Question> list2Write, string category)
        {

            if (!File.Exists(path + category + ".txt"))
            {
                TextWriter tw = new StreamWriter(path + category + ".txt");
                for (int i = 0; i < list2Write.Count; i++)
                {
                    tw.WriteLine(list2Write[i].query);
                    tw.WriteLine(list2Write[i].answers[0]);
                    tw.WriteLine(list2Write[i].answers[1]);
                    tw.WriteLine(list2Write[i].answers[2]);
                    tw.WriteLine(list2Write[i].answers[3]);

                }
                tw.Close();
            }
            else
            {
                TextWriter tw = new StreamWriter(path + category + ".txt", true);

                for (int i = 0; i < list2Write.Count; i++)
                {
                    tw.WriteLine(list2Write[i].query);
                    tw.WriteLine(list2Write[i].answers[0]);
                    tw.WriteLine(list2Write[i].answers[1]);
                    tw.WriteLine(list2Write[i].answers[2]);
                    tw.WriteLine(list2Write[i].answers[3]);

                }
                tw.Close();
            }

        }
        public static List<Question>  ReadQuestions(string category)
        {
            List<Question> questions = new List<Question>() ;

            if (File.Exists(path + category + ".txt"))
            {
                TextReader tr = new StreamReader(path + category + ".txt");
                int i = 0;
                string line;
                while ((line=tr.ReadLine())!=null)
                {
                    
                    questions.Add(new Question(line, tr.ReadLine(), tr.ReadLine(), tr.ReadLine(), tr.ReadLine()));


                    i++;
                }
                
                tr.Close();
            }

            return(questions);
        }
    }
}
