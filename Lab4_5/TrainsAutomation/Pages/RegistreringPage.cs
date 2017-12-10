using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TrainsAutomation.Pages
{
    public class RegistreringPage
    {
        private const string BASE_URL = "https://www.nsb.no/en/registrering";

        [FindsBy(How = How.Id, Using = "firstname")]
        private IWebElement firstname;

        [FindsBy(How = How.Id, Using = "lastname")]
        private IWebElement lastname;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailElement;

        [FindsBy(How = How.Id, Using = "country")]
        private IWebElement countryElement;

        [FindsBy(How = How.XPath, Using = "register")]
        private IWebElement register;

        private IWebDriver driver;

        public RegistreringPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Console.WriteLine("Login Page opened");
        }

        public void Register(string firstName, string lastName, string email, string country)
        {
            firstname.SendKeys(firstName);
            lastname.SendKeys(lastName);
            countryElement.SendKeys(country);
            emailElement.SendKeys(email);
            register.Click();
        }

        
    }
}