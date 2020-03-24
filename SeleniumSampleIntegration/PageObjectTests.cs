using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumSampleIntegration.Models.Google;
using Xunit;

namespace SeleniumSampleIntegration
{
    public class PageObjectTests:IDisposable
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        [Fact]
        public void SearchWebsite()
        {
            _driver = new ChromeDriver();
            _wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 20));

            _driver.Navigate().GoToUrl("http://www.google.com/");

            var googleSeachPage = new GoogleHomePage(_driver,_wait);

            googleSeachPage.Search("feel it services iasi").SelectFirstResult().ClickTopMenuCareers().ClickTopMenuContactUs();

            Assert.NotNull(_driver.Title);
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
