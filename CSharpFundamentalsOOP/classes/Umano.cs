using System;
namespace CSharpFundamentalsOOP
{
    public class Umano
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public Umano(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                TimeSpan timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public static void VirtualMain()
        {
            var umano = new Umano(new DateTime(1993, 4, 9));
            Console.WriteLine(umano.Age);
        }
    }
}
