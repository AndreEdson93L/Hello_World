namespace CSharpFundamentalsOOP
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Eat()
        {
            System.Console.WriteLine($"The {Name} is eating something..");
        }
        public void Sleep()
        {
            System.Console.WriteLine($"The {Name} is sleeping..");
        }
    }
}
