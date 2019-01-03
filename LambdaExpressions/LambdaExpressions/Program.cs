using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions //use for convinience 
{
    class Program
    {
        static void Main(string[] args)
        {
            // arfs => expression       
            // x => ...
            //(x, y, z) => ...
            //delegate Func<>
            Func<int, int> square = number => number * number;   //number => number * number---lambda expression                        
            Console.WriteLine(square(5));

            const int factor = 6;
            Func<int, int> multiplier = n => n * factor;
            var result = multiplier(10);
            Console.WriteLine(result);

            //Book Example
            var books = new BookRepository().GetBooks(); 
            //Predicate<T>delegate match means that returns a boolean
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        //static int Square(int number)
        //{
        //    return number * number;
        //}

        //static bool IsCheaperThan10Euros(Book book)
        //{
        //    return book.Price < 10;
        //}
    }
}
