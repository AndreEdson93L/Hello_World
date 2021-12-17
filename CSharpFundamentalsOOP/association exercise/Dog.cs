namespace CSharpFundamentalsOOP
{
    public class Dog : Animal
    {
        private readonly Walkable _walkable;

        public Dog(Walkable walkable)
        {
            _walkable = walkable;
        }
        public void Walk()
        {
            _walkable.Walk($"{Name} is walking..");
        }
    }
}

//MAIN, COMPOSITION

//var dog = new Dog(new Walkable());
//dog.Name = "Rex";
//dog.Walk();

//var fish = new Goldfish(new Swimmable());
//fish.Name = "Dory";
//fish.Swim();
