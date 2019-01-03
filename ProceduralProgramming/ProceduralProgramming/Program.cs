using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            
            string reversedName = ReversedName(name);           //Contructor string
            Console.WriteLine(reversedName);                    

        }

        public static string ReversedName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)                 
            {
                array[name.Length - i] = name[i - 1];

                //0----3
                //1----2
                //2----1
                //3----0
            }
            return new String(array);                
        }
    }
}
