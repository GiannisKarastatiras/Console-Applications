using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine("Welcome... " + i);
            }

            Console.WriteLine("End of Loop!");

            int age = 35;
            int newAge = ++age; // prefix operator
            Console.WriteLine("age: {0}, newAge: {1}", age, newAge);

            newAge = age++;  // postfix operator
            Console.WriteLine("age: {0}, newAge: {1}", age, newAge);
            //Console.WriteLine(i);
            //int i = 0;
            int j = 0;
            for (; ; )
            {
                ++j;

                if (j == 5)
                {
                    continue;
                }

                Console.WriteLine("Welcome... {0}", j);

                if (j > 10)
                {
                    break;
                }

                Console.WriteLine("End of Loop!!!");
            }

            for (int i = 0; i < 2000; i++)
            {
                Console.WriteLine(i);
                if (i % 100 == 0)
                {
                    Console.WriteLine("Happy Birthday! {0}", i);
                }
            }
            //j = 876;
        }
    }
}
