using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age?");
            string ageAsString = Console.ReadLine();
            int age = int.Parse(ageAsString);

            // Check for Voting
            if (age > 70)
            {
                Console.WriteLine("You are too old to vote.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are an Adult.");
            }
            else if (age < 18)
            {
                Console.WriteLine("You cannot vote, too young.");
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }
            // End Check for Voting

        }
    }
}
