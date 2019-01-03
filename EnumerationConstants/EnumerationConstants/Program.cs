using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationConstants
{
    class Program
    {
        enum Color
        {
            Red,            
            Green,
            Yellow,
            Orange
        }

        enum Ages
        {
            kinderGarden = 5,
            highSchool = 12,
            university = 18
        }

        static void Main(string[] args)
        {
            Color favourite = Color.Yellow;

            switch (favourite)
            {
                case Color.Red:
                    Console.WriteLine("You chose Red!");
                    break;
                case Color.Green:
                    Console.WriteLine("You chose Green!");
                    break;
                case Color.Orange:
                    Console.WriteLine("You chose Orange!");
                    break;
                case Color.Yellow:
                    Console.WriteLine("You chose Yellow!");
                    break;
                default:
                    Console.WriteLine("Something went wrong...");
                    break;
            }

            const int age = 15;          
            
            if (age < (int)Ages.kinderGarden)            //(int)----Casting
            {
                Console.WriteLine("You ara very very young!");  
            }
            else if (age < (int)Ages.highSchool)
            {
                Console.WriteLine("You are going to primary school!");
            }            
            else if (age < (int)Ages.university)
            {
                Console.WriteLine("You are going to High School!");
            }
            else
            {
                Console.WriteLine("You are going to University!");
            }

            DateTime now = DateTime.Now;
            //string greeting = "Good ";

            

            //if (eveningTime)
            //{                
            //    greeting += "evening";
            //}
            //else
            //{
            //    greeting += "morning";
            //}
            //Console.WriteLine(greeting);

            bool eveningTime = now.Hour > 12;
            string finalGreeting = "Good" + (eveningTime ? "evening" : "morning");      
            Console.WriteLine(finalGreeting);                                   
        }
    }
}
