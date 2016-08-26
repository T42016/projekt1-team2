using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Question fråga = new Question("Hej?", "Hej!", "nej1", "nej2", "nej3");
            while (true)
            {
               
           
                Console.WriteLine(fråga.answers[0]);
                Console.WriteLine(fråga.answers[1]);
                Console.WriteLine(fråga.answers[2]);
                Console.WriteLine(fråga.answers[3]);
                Console.ReadLine();
               
            }
            List<Question> biologi = new List<Question>();
            List<Question> geografi = new List<Question>();
            List<Question> historia = new List<Question>();
            List<Question> teknik = new List<Question>();
            List<Question> tvspel = new List<Question>();
            
            
            
        }
    }
}
