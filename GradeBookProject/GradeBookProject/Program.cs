using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);                          //----style debugg---run to cursor ctrl+F10---//
            book.AddGrade(89.5f);
            book.AddGrade(75);

                                                           
            /* GradeBook book2 = new GradeBook(); */        
                                                            

            //GradeBook book2 = book;   
            //book2.AddGreat(75);
            GradeBookStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Forza Ferrari");
        }                                   
    }
}
