using OpenQA.Selenium;
using System;
using System.Linq;

namespace MySeleniumTests
{
    public class BingSearchResultsPage
    {
        private IWebDriver _driver;

        public BingSearchResultsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement _searchResultsSpan;
        private IWebElement SearchResultsSpan => _searchResultsSpan ?? _driver.FindElement(By.ClassName("sb_count"));

        public int GetNumberOfResults()
        {
            var digits = new string(SearchResultsSpan.Text.AsEnumerable().Where(char.IsDigit).ToArray());
            return int.Parse(digits);
        }
    }
}
