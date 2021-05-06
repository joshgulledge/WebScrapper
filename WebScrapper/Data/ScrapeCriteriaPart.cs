using System;
using System.Text.RegularExpressions;

namespace WebScrapper.Data
{
    public class ScrapeCriteriaPart
    {
        public string Regex { get; set; }
        public RegexOptions RegexOptions { get; set; }
    }
}
