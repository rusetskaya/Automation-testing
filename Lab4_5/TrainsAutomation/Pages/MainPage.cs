using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TrainsAutomation.Pages
{
    public class MainPage
    {
        private const string BASE_URL = "https://www.nsb.no/en/";

        [FindsBy(How = How.ClassName, Using = "nsb-page-search-button")]
        private IWebElement buttonSearch;

        //[FindsBy(How = How.XPath, Using = "//a[contains(text(), 'New repository')]")]
        //private IWebElement linkNewRepository;

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void ClickOnCreateNewRepositoryButton()
        {
            buttonSearch.Click();
        }
    }
}