using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TrainsAutomation.Pages
{
    public class SearchPage
    {
        private const string BASE_URL = "https://www.nsb.no/en/search?q=";
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "dest1")]
        private IWebElement travelTo;

        [FindsBy(How = How.Id, Using = "from1")]
        private IWebElement travelFrom;

        //[FindsBy(How = How.Id, Using = "repository_description")]
        //private IWebElement inputRepositoryDescription;

        [FindsBy(How = How.XPath, Using = "//form[@id='nsb-travelplanner-simple']//button[@type='submit']")]
        private IWebElement buttonView;

        //[FindsBy(How = How.ClassName, Using = "empty-repo-setup-option")]
        //private IWebElement labelEmptyRepoRecommendations;

        //[FindsBy(How = How.XPath, Using = "//a[@data-pjax='#js-repo-pjax-container']")]
        //private IWebElement linkCurrentRepository;


        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void ViewSearch(string from, string to)
        {
            travelFrom.SendKeys(from);
            travelTo.SendKeys(to);
            buttonView.Click();
        }

        //public bool IsCurrentRepositoryEmpty()
        //{
        //    return labelEmptyRepoRecommendations.Displayed;
        //}

        //public string GetCurrentRepositoryName()
        //{
        //    return linkCurrentRepository.Text;
        //}
    }
}