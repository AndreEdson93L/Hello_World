using System;
namespace CSharpFundamentalsOOP
{
    public class Car : Vehicle
    {
        public Car(string registragionNumber)
            : base(registragionNumber)
        {
            Console.WriteLine("Car is being initialized. R.number: {0}", registragionNumber);
        }
    }
}
//MAIN, Ereditarietà e precedenze nella chiamata dei costruttori
//var car = new Car("VE234TO");