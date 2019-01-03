using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageAsString = Console.ReadLine();                 
            int age = int.Parse(ageAsString);

            //conditional.
            //Check for Voting.
            if (age > 70)
            {
                Console.WriteLine("You are too old to vote.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are an Adult.");             
            }
            else if (age < 18 )
            {
                Console.WriteLine("You cannot vote, too young.");
            
            }

            else
            {
                Console.WriteLine("Something getting wrong");
            }
            // End Check for Voting.
        }
    }
}
