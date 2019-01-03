using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)        
            {
                Console.WriteLine("Welcome..." + i);
            }

            Console.WriteLine("End of Loop!");

            int age = 35;
            int newAge = ++age;     // prefix operator
            Console.WriteLine("age: {0}, newAge: {1}", age, newAge);

            newAge = age++;         // postfix operator
            Console.WriteLine("age: {0}, newAge: {1}", age, newAge);
            //  Console.Writeline(i);
            //  int i = 0;
            
            int j = 0;    
            for (; ; )
            {
                ++j;

                if (j == 5)
                {
                    continue;           
                }

                Console.WriteLine("Welcome....{0}", j);

                if (j >10)
                {
                    break;              //  Stop the loop.
                }

                Console.WriteLine("End of loop!!!");
            }

            for (int i = 0; i <= 2000; i++)                 
            {                                                       
                
                if (i % 100 == 0)                                    
                    
                {
                    Console.WriteLine(i);
                }

             
            }
        }   
    }
}
