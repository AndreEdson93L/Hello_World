using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class InterfacesNotes
    {
        public void PrintNotes()
        {
            Dictionary<string, string> dizionario = new Dictionary<string, string>();

            dizionario.Add("What?", "A languange construct that is similar to a class (in terms of syntax) but is fundamentally different");
            dizionario.Add("Syntax", "public interface ITaxCalculator\n{\n\tint Calculate();\n}");
            dizionario.Add("Whi?", "To build loosely-coupled applications.");
            dizionario.Add("How?", "OrderProcessor ----->  <<interface>> ITaxCalculator.");

            foreach (var item in dizionario)
                Console.WriteLine("Key: {0}\n{1}\n", item.Key, item.Value);
        }
    }
}
    
