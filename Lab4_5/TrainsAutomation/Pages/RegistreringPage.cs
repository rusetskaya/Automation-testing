using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TrainsAutomation.Pages
{
    public class RegistreringPage
    {
        private const string BASE_URL = "https://www.nsb.no/en/registrering";

        [FindsBy(How = How.Id, Using = "firstname")]
        private IWebElement firstnameElement;

        [FindsBy(How = How.Id, Using = "lastname")]
        private IWebElement lastnameElement;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailElement;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordElement;

        [FindsBy(How = How.Id, Using = "country")]
        private IWebElement countryElement;

        [FindsBy(How = How.Id, Using = "date-of-birth-date")]
        private IWebElement birthdateElement;

        [FindsBy(How = How.Id, Using = "date-of-birth-month")]
        private IWebElement birthmonthElement;

        [FindsBy(How = How.Id, Using = "date-of-birth-year")]
        private IWebElement birthyearElement;

        [FindsBy(How = How.Id, Using = "zipcode")]
        private IWebElement zipcodeElement;

        [FindsBy(How = How.Id, Using = "zipcode")]
        private IWebElement codeElement;

        [FindsBy(How = How.Id, Using = "phonenumber")]
        private IWebElement phonenumberElement;

        [FindsBy(How = How.Name, Using = "mypage_edituser-submit_form")]
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
            firstnameElement.SendKeys(firstName);
            lastnameElement.SendKeys(lastName);
            countryElement.SendKeys(country);
            emailElement.SendKeys(email);
            register.Click();
        }

        
    }
}