using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic name = "Andrea Edson";
            Console.WriteLine(name);

            name = 10;
            Console.WriteLine(name);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b; //becuase a and b are dynamic c will end up to be dynamic
            Console.WriteLine(c);

            //ConversionOrCast
            int i = 5;
            dynamic d = i;
            Console.WriteLine(d.GetType());

            long l = d; // l == 5 and it's long type
        }
    }
}
