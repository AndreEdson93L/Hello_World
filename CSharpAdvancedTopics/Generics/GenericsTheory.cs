using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTopics.Generics
{
    public class GenericsTheory
    {
        public static void VirtualMain()
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("#1 KeyValue", new Book());

            //All yours lists
            //System.Collections.Generic.

            var number1 = new Nullable<int>(5);
            Console.WriteLine("Has Value ?" + number1.HasValue);
            Console.WriteLine("Value: " + number1.GetValueOrDefault());

            var number2 = new Nullable<int>();
            Console.WriteLine("Has Value ?" + number2.HasValue);
            Console.WriteLine("Value: " + number2.GetValueOrDefault());
        }
    }
}
