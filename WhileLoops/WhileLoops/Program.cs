using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many times tou want to print?");
            int timesToPrint = int.Parse(Console.ReadLine());

            //while (timesToPrint > 0)                              
            //{ 
            //    Console.WriteLine("Printing Document....");
            //    timesToPrint = timesToPrint - 1;
            //}



            
            do
            {
                Console.WriteLine("Printing Document....");
                timesToPrint--; // timesToPrint = timesToPrint - 1;
            } while (timesToPrint > 0);

            Console.WriteLine("End Printing.");
        }   
    }
}
