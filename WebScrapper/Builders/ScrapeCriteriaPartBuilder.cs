using System;
using System.Text.RegularExpressions;
using WebScrapper.Data;

namespace WebScrapper.Builders
{
    public class ScrapeCriteriaPartBuilder
    {
       private string _regex;
       private RegexOptions _regexOption;

        public ScrapeCriteriaPartBuilder()
        {
            SetDefault();
        }

        private void SetDefault()
        {
            _regex = string.Empty;
            _regexOption = RegexOptions.None;
        }

        public ScrapeCriteriaPartBuilder WithRegex(string regex)
        {
            _regex = regex;
            return this;
        }
        public ScrapeCriteriaPartBuilder withRegexOption(RegexOptions regexOption)
        {
            _regexOption = regexOption;
            return this;
        }

        public ScrapeCriteriaPartBuilder Build()
        {
            ScrapeCriteriaPart scrapeCriteriaPart = new ScrapeCriteriaPart();
            scrapeCriteriaPart.Regex = _regex;
            scrapeCriteriaPart.RegexOption = _regexOption;

            return this;
        }
    }
}
