using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue<int>();             //Queue---FIFO
            myQueue.Enqueue(100);
            myQueue.Enqueue(112);                       

            int val = myQueue.Dequeue();
            //Console.WriteLine($"this {val}");   


            for (int i = 0; i < 50; i++)
            {
                myQueue.Enqueue(i);
            }

            foreach (int i in myQueue)
            {
                Console.WriteLine(i);
            }

            var whichValue = myQueue.Dequeue();
            Console.WriteLine("WhichValue = {0}", whichValue);
            whichValue = myQueue.Dequeue();
            Console.WriteLine("Which = {0} 2nd time", whichValue);
        }
    }
}
