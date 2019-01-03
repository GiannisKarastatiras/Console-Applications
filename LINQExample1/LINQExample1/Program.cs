using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQExample1 
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();    //chain

            // LINQ Query Operators
            //SQL : SELECT * FROM Books Where Price < 5 ORDERBY Title
            var cheaperBooks =
                from b in books
                where b.Price < 5
                orderby b.Title
                select b;

            //LINQ Extensions Methods
            var cheapBooks = books  /*new List<Book>();*/
                            .Where(b => b.Price < 10)
                            .OrderBy(b => b.Price);
                          /*.Select(b => b.Title);*/

            var bookASPNET = books.Single(b => b.Title == "Book ASP.NET WEB");//SELECT TOP 1 sql
            Console.WriteLine(bookASPNET.Title);

            var bookMVC = books.First(b => b.Title == "Book ASP.NET MVC");
            Console.WriteLine("MVC book is " + bookMVC.Title + " " + bookMVC.Price);

            var notFirstBooks = books.Skip(1).Take(3);  
            foreach (var notFirstBook in notFirstBooks)
            {
                Console.WriteLine("Not First " + notFirstBook.Title);
            }

            var countBooks = books.Count();
            Console.WriteLine("Total Books " + countBooks);

            var maxPriceBook = books.Max(b => b.Price);    
            var totalCostBooks = books.Sum(b => b.Price);

            //cheapBooks.OrderBy(b => b.Price);
            


            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //    {
            //        cheapBooks.Add(book);
            //    }
            //}

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
                /*Console.WriteLine(book);*/
            }
        }
    }
}
