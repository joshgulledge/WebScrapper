using System;
using System.Net; // to use webClient
using System.Text.RegularExpressions;
using WebScrapper.Builders;
using WebScrapper.Data;

namespace WebScrapper
{
    class Program
    {
        private const string Method = "search";

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a City :");
            var craigListCity = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Please Enter the CraigList category :");
            var craigListCategory = Console.ReadLine() ?? string.Empty;

            using (WebClient client = new WebClient())
            {
                string content = client.DownloadString($"http://{craigListCity.Replace(" ", string.Empty)}.craigslist.org/{Method}/{craigListCity}");

                ScrapeCriteria scrapeCriteria = new ScrapeCriteriaBuilder()
                    .withData(content)
                    .withRegex(@"< a href =\""(.*?)\"" data - id =\""(.*?)\"" class=\""(.*?)\"" id=\""(.*?)\"">\""(.*?)\""</a>")
                    .withRegexOption(RegexOptions.ExplicitCapture)
                    .withParts(new ScrapeCriteriaPartBuilder()
                        .withRegex(@">(.*?)</a>")
                        .withRegexOption(RegexOptions.Singleline)
                        .Build())
                    .withPart(new ScrapeCriteriaPartBuilder()
                        .WithRegex(@"href=\""(.*?)\""")
                        .withRegexOption(RegexOptions.Singleline)
                        .Build())
                    .Build();

                ScrapeCriteria scrapeCriteria2 = new ScrapeCriteriaBuilder()
                        .withData(content)
                        // craigslist recently added an id to their group elements which I have included here as an update - 10/5/2020
                        .withRegex(@"<a href=\""(.*?)\"" data-id=\""(.*?)\"" class=\""result-title hdrlnk\"" id=\""(.*?)\"" >(.*?)</a>")
                        .withRegexOption(RegexOptions.ExplicitCapture)
                        .withParts(new ScrapeCriteriaPartBuilder()
                            .withRegex(@">(.*?)</a>")
                            .withRegexOption(RegexOptions.Singleline)
                            .Build())
                        .withParts(new ScrapeCriteriaPartBuilder()
                            .withRegex(@"href=\""(.*?)\""")
                            .withRegexOption(RegexOptions.Singleline)
                            .Build())
                        .Build();
            }

        }
    }
}
