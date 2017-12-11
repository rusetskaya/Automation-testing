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

        //[Test]
        //public void OneCanSearch()
        //{
        //    steps.Search(FROM, TO);
        //    //Assert.True(steps.IsGetInfo());
        //}
    }
}