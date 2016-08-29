using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace questionGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            List<Question> biologi = new List<Question>();
            List<Question> geografi = new List<Question>();
            List<Question> historia = new List<Question>();
            List<Question> teknik = new List<Question>();
            List<Question> tvspel = new List<Question>();
            
            biologi.Add(new Question("Vad?1","1","2","3","4"));
            biologi.Add(new Question("Vad?2", "1", "2", "3", "4"));
            biologi.Add(new Question("Vad?3", "1", "2", "3", "4"));
            biologi.Add(new Question("Vad?4", "1", "2", "3", "4"));

            
            NewQuestions(biologi,"biologi");
            biologi = ReadQuestions("biologi");
            NewQuestions(biologi, "biologi");

        }
        public static void NewQuestions(List<Question> list2Write,string category)
        {
            string path = @"C:\quiz\";            

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
            string path = @"C:\quiz\";

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
            string path = @"C:\quiz\";

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
