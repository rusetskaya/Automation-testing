using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TrainsAutomation.Pages
{
    public class ProfilePage
    {
        private const string BASE_URL = "https://www.nsb.no/en/my-profile/edit-profile";

        [FindsBy(How = How.Id, Using = "firstname")]
        private IWebElement firstnameElement;

        [FindsBy(How = How.Id, Using = "lastname")]
        private IWebElement lastnameElement;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailElement;

        public IWebElement Firstname => firstnameElement;
        public IWebElement Lastname => lastnameElement;
        public IWebElement Email => emailElement;
    }
}