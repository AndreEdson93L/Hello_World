using System;
using System.Collections.Generic;

namespace CSharpFundamentalsOOP
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expire { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>(); 
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        public static void VirtualMain()
        {
            var cookie = new HttpCookie();
            cookie["nome"] = "Andrea Edson";
            Console.WriteLine(cookie["name"]);
        }
    }
}
