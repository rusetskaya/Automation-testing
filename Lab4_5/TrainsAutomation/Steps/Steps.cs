using OpenQA.Selenium;

namespace TrainsAutomation.Steps
{
    public class Steps
    {
        IWebDriver driver;

        public IWebDriver InitBrowser()
        {
            return driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void Search(string from, string to)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.ClickOnSearchButton();
            Pages.SearchPage searchPage = new Pages.SearchPage(driver);
            //string expectedRepoName = createNewRepositoryPage.CreateNewRepository(repositoryName, repositoryDescription);

            //return expectedRepoName.Equals(createNewRepositoryPage.GetCurrentRepositoryName());
        }

        public void Register(string firstname,string lastname,string country,int birthyear,int birthdate,string birthmonth,string email,string password)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.ClickOnRegisterButton();
            Pages.RegistreringPage registerPage = new Pages.RegistreringPage(driver);
            registerPage.Register(firstname, lastname, country, birthyear, birthdate, birthmonth, email, password);

            //return expectedRepoName.Equals(createNewRepositoryPage.GetCurrentRepositoryName());
        }

    }
}