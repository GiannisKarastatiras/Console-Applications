using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() { Title = "Book One", Price = 5},
                new Book() { Title = "Book Two", Price = 12},
                new Book() { Title = "Book Three", Price = 19}
            };
        }
    }
}
