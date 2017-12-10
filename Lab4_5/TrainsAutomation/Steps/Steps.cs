using OpenQA.Selenium;

namespace TrainsAutomation.Steps
{
    public class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void Search(string repositoryName, string repositoryDescription)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.ClickOnCreateNewRepositoryButton();
            Pages.SearchPage searchPage = new Pages.SearchPage(driver);
            //string expectedRepoName = createNewRepositoryPage.CreateNewRepository(repositoryName, repositoryDescription);

            //return expectedRepoName.Equals(createNewRepositoryPage.GetCurrentRepositoryName());
        }

    }
}