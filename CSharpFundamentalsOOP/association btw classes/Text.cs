namespace CSharpFundamentalsOOP
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
        public void AddHyperLink(string url)
        {
            System.Console.WriteLine($"A link to {url} has been added");
        }
    }
}
//MAIN, INHERITANCE (Is-a)

//var text = new Text();
//text.Width = 100;
//text.Copy();