﻿using OpenQA.Selenium;

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

    }
}