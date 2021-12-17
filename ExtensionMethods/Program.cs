using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is a post and it's very long but it's ok";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18};
            var max = numbers.Max();

            System.Console.WriteLine(shortenedPost);
            System.Console.WriteLine(max);
        }
    }
}
