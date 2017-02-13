using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------
            // EXAMPLE 1
            // ----------------------------

            Console.WriteLine(Square(5));

            // lambda expression syntax:
            // args => expression
            // no args: () => ...
            // 1 arg: x => ...
            // (x, y, z) => ...
            // use as a delegate
            Func<int, int> lambdaSquare = x => x * x; //pass in arg type and return value type
            Console.WriteLine(lambdaSquare(5));

            // scope is contained
            const int factor = 5;
            Func<int, int> multiplyByFactor = n => n * factor;
            Console.WriteLine(multiplyByFactor(10));


            // ----------------------------
            // EXAMPLE 2
            // ----------------------------
            var books = new BookRepository().GetBooks();
            var cheapbooks = books.FindAll(b => b.Price < 10); //pass lambda expression as a predicate method (a bool method to filter results by)
            foreach (var book in cheapbooks)
            {
                Console.WriteLine(book.Title + " : $" + book.Price);
            }
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}
