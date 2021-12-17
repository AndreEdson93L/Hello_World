namespace CSharpFundamentalsOOP
{
    public class SerHumano : Animal
    {
        private readonly Walkable _walkable;
        public SerHumano(Walkable walkable)
        {
            _walkable = walkable;
        }
        public void Walk()
        {
            _walkable.Walk($"{Name} is walking..");
        }
    }
}
