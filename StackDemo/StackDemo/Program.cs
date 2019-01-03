using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Stack ---LIFO---

            var mystack = new Stack<int>();
            mystack.Push(134);          //Push---like Enqueue
            mystack.Push(112);

            int val = mystack.Pop();    //Pop---like Dequeue
            Console.WriteLine("val: {0}", val);

            for (int i = 0; i < 50; i++)
            {
                mystack.Push(i);
            }

            foreach (int i in mystack)
            {
                Console.WriteLine("{0}", i);
            }

            var whichValue = mystack.Pop();
            Console.WriteLine("\nPopped Value : {0}", whichValue);
            whichValue = mystack.Pop();
            Console.WriteLine("\nPopped Value : {0}", whichValue);                        
        }
    }
}
