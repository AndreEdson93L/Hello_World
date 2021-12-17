using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Extension Methods
            var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(book == null);
            Console.WriteLine(book.Title + "\n");

            book = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book.Title + " " + book.Price + "\n");

            book = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book.Title + " " + book.Price + "\n");

            var pagedBooks = books.Skip(2).Take(3);
            foreach (var pagedBook in pagedBooks)
                Console.WriteLine(pagedBook.Title);

            var count = books.Count();
            Console.WriteLine("\n" + count);

            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine("\n" + maxPrice);

            var minPrice = books.Min(b => b.Price);
            Console.WriteLine("\n" + minPrice);

            var totalPrices = books.Sum(b => b.Price);
            Console.WriteLine("\n" + totalPrices);

            //Recap
            books.Where(b => b.Price < 8);
            books.Single();
            books.SingleOrDefault();

            books.First();
            books.FirstOrDefault();

            books.Last();
            books.LastOrDefault();

            books.Min();
            books.Max();
            books.Count();
            books.Sum(b => b.Price);
            books.Average(b => b.Price);

            books.Skip(5).Take(3); 
        }
    }
}
