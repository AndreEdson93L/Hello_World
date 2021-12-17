using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class TheoryLINQ
    {
        //What is LINQ?

        /*
         * Stands for: Language Integrated Query
         * Gives you the capability to query objects
         */

        //You can query
        /*
         * Objects in memory, eg collections (LINQ to Objects)
         * Databases (LINQ to Entities)
         * XML (LINQ to XML)
         * ADO.NET Data Sets (LINQ to Data Sets)
         */
        public static void VirtualMain()
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b;

            // LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10) // Anonymous method (b [argument] => b.Price < 10 [boolean expression])
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            /*
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
                    cheapBooks.Add(book);
            }
            */

            foreach (var book in cheapBooks)
                Console.WriteLine(book);
            //Console.WriteLine(book.Title + " " + book.Price);
        }
    }
}
