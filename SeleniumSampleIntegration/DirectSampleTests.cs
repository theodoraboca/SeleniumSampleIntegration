using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using Xunit;
using Xunit.Sdk;

namespace SeleniumSampleIntegration
{
    
    public class DirectSampleTests : IDisposable
    {
        private IWebDriver _driver;

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Fact]
        public void TestWithChrome()
        {
            _driver = new ChromeDriver();
            var wait = new WebDriverWait(_driver, new TimeSpan(0,0,20));

            _driver.Navigate().GoToUrl("http://google.com");
            var textBox = _driver.FindElement(By.Name("q"));
            textBox.SendKeys("Feel it services iasi");

            var searchButton = _driver.FindElement(By.Name("btnK"));

           // wait.Until(Expected);
            
            searchButton.Click();
            
            
            Assert.NotNull(_driver.Title);
        }

        [Fact]
        public void TestWithFireFox()
        {
            _driver =  new FirefoxDriver();

            _driver.Navigate().GoToUrl("http://google.com");

            Assert.NotNull(_driver.Title);
        }

        [Fact (Skip = "Waiting for Edge driver update")]
        public void TestWithEdge()
        {
            _driver = new EdgeDriver();

            _driver.Navigate().GoToUrl("http://google.com");

            Assert.NotNull(_driver.Title);
        }

        [Fact]
        public void TestWithInternetExplorer()
        {
            _driver = new InternetExplorerDriver();

            _driver.Navigate().GoToUrl("http://google.com");

            Assert.NotNull(_driver.Title);
        }
    }
}
