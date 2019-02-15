using OpenQA.Selenium;

namespace MySeleniumTests
{
    public class BingHomePage
    {
        private IWebDriver _driver;

        public BingHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement _searchTextBox;
        private IWebElement SearchTextBox => _searchTextBox ?? _driver.FindElement(By.Id("sb_form_q"));

        private IWebElement _searchButton;
        private IWebElement SearchButton => _searchButton ?? _driver.FindElement(By.Id("sb_form_go"));

        public void SearchFor(string text)
        {
            SearchTextBox.SendKeys(text);
            SearchButton.Click();
        }
    }
}
