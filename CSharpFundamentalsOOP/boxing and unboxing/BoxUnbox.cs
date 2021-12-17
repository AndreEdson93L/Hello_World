using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpFundamentalsOOP
{
    public class BoxUnbox
    {
        string Name;
        int Age;

        public BoxUnbox()
        {

        }
        public BoxUnbox(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetAge(int age)
        {
            Age = age;
        }
        public int GetAge()
        {
            return Age;
        }
        public static void Theory()
        {
            // Boxing
            object obj = 1;
            // Unboxing
            int i = (int)obj;

            //Object class is the base of all classes in .NET Framework
            //type unsafe, slower
            //boxing happens when we pass a value type to an ArrayList
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            foreach (var n in list)
                Console.WriteLine(n);
            Console.WriteLine("type unsafe, ArrayList");

            //type safe, faster
            var anotherList = new List<int>();
            anotherList.Add(1);
            anotherList.Add(3);
            anotherList.Add(6);

            foreach (var n in anotherList)
                Console.WriteLine(n);
            Console.WriteLine("type safe, generic list of <integer>");

            var names = new List<string>();
            names.Add("Andrea");
            names.Add("Flavio");
            names.Add("Emanuele");
            names.Add("Imane");
            names.Add("Giovanna");

            foreach (var name in names)
                Console.WriteLine(name);

            //boxing (from value type to object)
            //number will be saved as a reference type in the heap
            int number = 10;
            Object boxing = number;
            Console.WriteLine("object: " + boxing);

            //unboxing (from object to value type)
            Object unboxing = 10;
            int num = (int)unboxing;
            Console.WriteLine("integer: " + num);
        }
    }
}
