using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Giannis"; 
            Console.WriteLine(message);

            int myFirstValue = 43;
            double mySecondValue = 22.54;

            var sum = myFirstValue + mySecondValue;
            Console.WriteLine(sum);

            var sumStringNumber = message + myFirstValue + mySecondValue;
            Console.WriteLine(sumStringNumber);

            bool myFirstBoolean = 3 + 2 == 5;
            Console.WriteLine(myFirstBoolean);

            bool mySecondBoolean = 3 + 7 > 10;
            Console.WriteLine(mySecondBoolean);

            bool bothAreTrue = myFirstBoolean && mySecondBoolean;
            Console.WriteLine("bothAreTrue" + bothAreTrue);

            bool oneIsTrue = myFirstBoolean | mySecondBoolean;       
            Console.WriteLine("oneIsTrue evaluates" + oneIsTrue);

            bool reverseMyFirstBoolean = !myFirstBoolean;
            Console.WriteLine("myFirstBoolean is {0} but reverseMyFirstBoolean is {1}", myFirstBoolean, reverseMyFirstBoolean);         

            int myAge = 30;
            double myHourlySalary = 167.00;
            var myName = "John";
            // Print My Data
            Console.WriteLine($"myAge: {myAge}, myHourlySalary: {myHourlySalary}, myName: {myName}");   
            // Change Values
            myAge = myAge + 1;
            myHourlySalary = myHourlySalary + 43;
            Console.WriteLine($"myAge: {myAge}, myHourlySalary: {myHourlySalary}, myName: {myName}");
        }
    }
}
