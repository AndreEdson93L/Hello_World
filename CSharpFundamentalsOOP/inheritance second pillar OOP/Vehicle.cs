using System;
namespace CSharpFundamentalsOOP
{
    public class Vehicle
    {
        private readonly string _registragionNumber;
        /*
        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized.");
        }
        */
        public Vehicle(string registragionNumber)
        {
            _registragionNumber = registragionNumber;
            Console.WriteLine("Vehicle is being initialized. {0}", registragionNumber);
        }
    }
}
