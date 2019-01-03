using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            //Default Constructor List
            List<int> myList = new List<int>();           
            for (int i = 0; i < 10; i++)                   
            {
                myList.Add(r.Next());                    
                                                         
            }

            myList.Sort();

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }



        }
    }
}
