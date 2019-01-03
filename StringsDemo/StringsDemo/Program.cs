using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            //----Strings are immutable----//


            var fullName = "Peri Aidinopoulos "; 
            Console.WriteLine("Trim '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper '{0}'", fullName.Trim(), fullName.ToUpper());


            var index = fullName.IndexOf(" ");
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);
            Console.WriteLine(fullName);      


            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Peri", "Periklis"));


            if (String.IsNullOrEmpty(null))     
            {                                   //("")----empty//
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }    
            else
            {
                Console.WriteLine("Valid");
            }
        }
    }
}
