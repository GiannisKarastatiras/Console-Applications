using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            var primes = new List<int> { 1, 2, 3, 5, 7, 9, 11, 13, 17, 19, 23 };

            // query syntax
            var query =
                from val in primes      
                where val < 13
                select val;
            foreach (var val in query)
            {
                Console.WriteLine(val);
            }

            // method syntax
            var methodQuery = primes.Where(x => x < 13);
            foreach (var val in methodQuery)
            {
                Console.WriteLine(val);
            }

            // order by and grouping
            
            var differentQuery =    // differentQuery list
                from method in typeof(double).GetMethods() 
                orderby method.Name
                group method by method.Name into groups
                select new { MethodName = groups.Key/*key is the name*/, NumberOfOverloads = groups.Count() };

            // new {} Anonymous Type(new Class--object on the flight)
            foreach (var item in differentQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
