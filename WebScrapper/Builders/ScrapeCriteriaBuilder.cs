using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WebScrapper.Data;

namespace WebScrapper.Builders
{
    public class ScrapeCriteriaBuilder
    {
        // local properties
        private string _data;
        private string _regex;
        private RegexOptions _regexOption;
        private List<ScrapeCriteriaPart> _parts;

        // constructor
        public ScrapeCriteriaBuilder()
        {
            SetDefaults();
        }

        // if now specific value used, calls default when intialized
        private void SetDefaults()
        {
            _data = string.Empty;
            _regex = string.Empty;
            _regexOption = RegexOptions.None;
            _parts = new List<ScrapeCriteriaPart>();
        }

        //sets specific values when initialized
        public ScrapeCriteriaBuilder withData(string data)
        {
            _data = data;
            return this;
        }
        public ScrapeCriteriaBuilder withRegex(string regex)
        {
            _regex = regex;
            return this;
        }
        public ScrapeCriteriaBuilder withRegexOption(RegexOptions regexOption)
        {
            _regexOption = regexOption;
            return this;
        }
        public ScrapeCriteriaBuilder withParts(ScrapeCriteriaPart scrapeCriteriaPart)
        {
            _parts.Add(scrapeCriteriaPart);
            return this;
        }

        public ScrapeCriteria Build()
        {
            ScrapeCriteria scrapeCriteria = new ScrapeCriteria();
            scrapeCriteria.Data = _data;
            scrapeCriteria.Regex = _regex;
            scrapeCriteria.RegexOptions = _regexOption;
            scrapeCriteria.Parts = _parts;

            return scrapeCriteria;
        }
    }
}
