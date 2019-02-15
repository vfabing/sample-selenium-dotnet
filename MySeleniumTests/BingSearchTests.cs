using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MySeleniumTests
{
    [TestClass]
    public class BingSearchTests
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void Initialize()
        {
            _driver = new ChromeDriver();
            var dirver = new ChromeDriver();
        }

        [TestMethod]
        public void BingSearch_ShouldReturnResults()
        {
            _driver.Navigate().GoToUrl("https://bing.com");

            var bingHomePage = new BingHomePage(_driver);
            bingHomePage.SearchFor("Hello World");

            var bingSearchResultsPage = new BingSearchResultsPage(_driver);
            var numberOfResults = bingSearchResultsPage.GetNumberOfResults();

            Assert.IsTrue(numberOfResults > 0);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}
