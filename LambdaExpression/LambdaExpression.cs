using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class LambdaExpression
    {
        public static void VirtualMain()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            List<string> list = new List<string>();

            list.Add("An anonymous method" +
                "\n-No access modifier" +
                "\n-No name" +
                "\n-No return statement");
            list.Add("For convenience");

            dictionary.Add("What is a Lambda Expression?", list[0]);
            dictionary.Add("Whi do we we use them?", list[1]);

            foreach (var value in dictionary)
                Console.WriteLine("{0},\n{1}\n", value.Key, value.Value);

            //Lambda expression syntax

            //args => expression
            //arguments - goes to - expression
            //number => number * number (we need to assign to a delegate)
            //delegate = a pointer, a reference to a method or a group of methods
            //commo delegate in .NET Action<> (r. void), Func<> (r. a value)

            //Func<1.argument of the method, 2.return value>
            Func<int, int> square = number => number * number;

            //lambda
            Console.WriteLine(square(5));

            //classic method
            Console.WriteLine(Square(7));

            // args => expression
            //() => ... 
            //x => ...
            //(x, y, z) => ...

            const int factor = 5;

            Func<int, int> multiplar = n => n * factor;
            var result = multiplar(10);

            Console.WriteLine(result);

            var books = new BookRepository().GetBooks();

            //Predicate -> is a delegate which point to a method and gets a book (in this case) and returns a boolean value specifying if a conditon was satisfied.
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " price: " + book.Price);

            var books1 = new BookRepository().GetBooks();

            //b == book
            //=> goes to
            //b.Price < 10 
            var cheapBooks1 = books1.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooks1)
                Console.WriteLine(book.Title + " price: " + book.Price);
        }
        static int Square(int number)
        {
            return number * number;
        }

        //predicate hand-made
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
