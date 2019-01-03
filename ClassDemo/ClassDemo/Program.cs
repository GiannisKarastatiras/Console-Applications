using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{  
    class Program
    {
        static void Main(string[] args)
        {
            Employee Peri = new Employee();         //Objects or Instances
            Peri.Age = 21;                                 
            Console.WriteLine("Peri's age is {0}", Peri.Age);
        }
    }
}
