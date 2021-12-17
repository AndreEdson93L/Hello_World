namespace CSharpFundamentalsOOP
{
    public class Property
    {
        //property = class member that encapsulates getters and setters.

        //auto-implemented properties
        public int Id { get; set; }

        //property
        private string _field;
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }
    }
}
