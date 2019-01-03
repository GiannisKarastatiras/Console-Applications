using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample1
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() { Title = "Book ASP.NET C#", Price = 5},
                new Book() { Title = "Book ASP.NET WEB", Price = 9.99f},
                new Book() { Title = "Book ASP.NET MVC", Price = 19},
                new Book() { Title = "Book ASP.NET MVC 2", Price = 24}
            };
        }
    }
}
