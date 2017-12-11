using NUnit.Framework;

namespace TrainsAutomation.Tests
{
    [TestFixture]
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();
        private const string FROM = "Fauske";
        private const string TO = "Asker";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void OneCanSearch()
        {
            steps.Search(FROM, TO);
            Assert.True(steps.IsGetInfo());
        }
    }
}