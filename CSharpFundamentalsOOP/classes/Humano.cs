using System;

namespace CSharpFundamentalsOOP
{
    public class Humano
    {
        private DateTime _birthdate;
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
        public static void VirtualMain()
        {
            var humano = new Humano();
            humano.SetBirthdate(new DateTime(1993, 4, 9));
            Console.WriteLine(humano.GetBirthdate());
        }
    }
}
