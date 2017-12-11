using NUnit.Framework;
using OpenQA.Selenium;
using TrainsAutomation.Pages;

namespace TrainsAutomation.Tests
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;
        private Steps.Steps steps = new Steps.Steps();
        private const string MAINPAGE_URL = "https://www.nsb.no/en/";
        private const string REGPAGE_URL = "https://www.nsb.no/en/registrering";
        private const string PROFILE_PAGE_URL = "https://www.nsb.no/en/my-profile/edit-profile";
        private const string FROM = "Fauske";
        private const string TO = "Asker";

        [SetUp]
        public void Init()
        {
            driver = steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void OpenMainPage()
        {
            var mainPage = new MainPage(driver);
            mainPage.OpenPage();

            Assert.AreEqual(driver.Url, MAINPAGE_URL);
        }

        [Test]
        public void OpenRegistreringPage()
        {
            var registreringPage = new RegistreringPage(driver);
            registreringPage.OpenPage();

            Assert.AreEqual(driver.Url, REGPAGE_URL);
        }

        //[Test]
        //public void OneCanSearch()
        //{
        //    steps.Search(FROM, TO);
        //    //Assert.True(steps.IsGetInfo());
        //}

        [Test]
        public void OneCanRegister()
        {
            string firstname = "ri", lastname = "ru", password = "password", email = "here_should_be_test@gmail.com", country = "Monaco", birthmonth = "January"; //used my email
            int birthdate = 23, birthyear = 2003;
            steps.Register(firstname, lastname, country, birthyear, birthdate, birthmonth, email, password);
            var profilePage = new ProfilePage();
            Assert.AreEqual(profilePage.Firstname, firstname);
        }
    }
}