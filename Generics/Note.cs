namespace Generics
{
    public class Note
    {
        public string KeyWord { get; set; }
        public string Notes { get; set; }
        
        public Note(string keyWord, string notes)
        {
            KeyWord = keyWord;
            Notes = notes;
        }
    }
}
