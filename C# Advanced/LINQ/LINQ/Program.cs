using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // ------------------------------
            // LINQ Query Operators
            // ------------------------------
            var cheaperBooks = from b 
                               in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;


            // ------------------------------
            // LINQ Extension Methods
            // ------------------------------
            Console.WriteLine("|---------------Cheap Books---------------|");
            
            var cheapBooks = books.Where(b => b.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title + " : $" + book.Price);
            }


            Console.WriteLine("|---------------Expensive Books by Title---------------|");
            var sortedExpensiveBooksByTitle = books
                                                .Where(b => b.Price >= 10)
                                                .OrderBy(b => b.Title);

            foreach (var book in sortedExpensiveBooksByTitle)
            {
                Console.WriteLine(book.Title + " : $" + book.Price);
            }

        }
    }
}
