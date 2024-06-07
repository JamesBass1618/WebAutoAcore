using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace WebAutoAcore
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TearDown] // Tag
        public void TearDown() { driver.Quit(); }
    }
}