using System;
namespace CSharpFundamentalsOOP
{
    public class ClientExample
    {
        //Public interface: Id,Name,Promote()
        public int Id { get; set; }
        public int Name { get; set; }
        public void Promote()
        {
            //Encapsulation (The hidden logic part)
            var rating = CalculateRating();
            if(rating == 0)
                Console.WriteLine("Promoted to Level 1");
            else
                Console.WriteLine("Promoted to Level 2");
        }
        private int CalculateRating()
        {
            return 0;
        }
    }
}
