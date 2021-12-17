using NPOI.SS.Formula.Functions;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroe1 = new Hero("Batman");
            var heroe2 = new Hero("Superman");

            var evil1 = new Evil("Joker");
            var evil2 = new Evil("Renzi");

            HeroList<Hero> heroList = new HeroList<Hero>();
            EvilList<Evil> evilList = new EvilList<Evil>();

            heroList.Add(heroe1);      
            heroList.Add(heroe2);

            evilList.Add(evil1);
            evilList.Add(evil2);

            //T t = new T();
            //System.Collections.Generic.

            var dictionary = new PersonalDictionary<string, Hero>();
            dictionary.Add("third hero", new Hero("Spider Pork"));

            PersonalDictionary<string, string> personalDictionary = new PersonalDictionary<string, string>();

            var example1 = new Note("interface", "where T : IComparable");
            var example2 = new Note("class", "where T : Product");
            var example3 = new Note("value", "where T : struct");
            var example4 = new Note("reference type", "where T : Class");
            var example5 = new Note("obj, default ctor", "where T : new()");

            personalDictionary.Add(example1.KeyWord, example1.Notes);
            personalDictionary.Add(example2.KeyWord, example2.Notes);
            personalDictionary.Add(example3.KeyWord, example3.Notes);
            personalDictionary.Add(example4.KeyWord, example4.Notes);
            personalDictionary.Add(example5.KeyWord, example5.Notes);

            var number = new Nullable<int>(5);
            Console.WriteLine($"Has value ? {number.HasValue}");
            Console.WriteLine($"Value: {number.GetValueOrDefault()}");

            var number2 = new Nullable<double>();
            Console.WriteLine($"Has value ? {number2.HasValue}");
            Console.WriteLine($"Value: {number2.GetValueOrDefault()}");

            //System.Nullable
        }
    }
}
