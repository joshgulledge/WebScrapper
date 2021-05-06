using System;
using System.Net; // to use webClient
using System.Text.RegularExpressions;

namespace WebScrapper
{
    class Program
    {
        static void Main(string[] args)
        {

            string rando = "Here we have some text, and This is my bat, he like fruit";

            MatchCollection matches = Regex.Matches(rando, "This is my [a-z]at");

            foreach(var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
