namespace CSharpFundamentalsOOP
{
    public class Goldfish : Animal
    {
        private readonly Swimmable _swimmable;
        public Goldfish(Swimmable swimmable)
        {
            _swimmable = swimmable;
        }
        public void Swim()
        {
            _swimmable.Swim($"{Name} is swimming..");
        }
    }
}
