using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumSampleIntegration.Models.Sheffield;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SeleniumSampleIntegration.SheffieldTesting
{
    public class Tests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        [Fact]
        public void RegressionTest()
        {
            _driver = new ChromeDriver();
            _wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 20));

            var url = "http://ngen-bo-dev.feelit.iasi.net";
            var loginUrl = "http://ngen-bo-dev.feelit.iasi.net/login";

            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();

            var sheffieldWebPage = new SheffieldLoginPage(_driver, _wait);

            sheffieldWebPage.Login("test.test", "Parola123+").OpenFullScreen().OpenSystemAdmin().ClickOnBackButton().OpenHR().ClickOnBackButton().OpenAccount().ClickOnBackButton().MinimizeScreen().Logout();

            Assert.True(_driver.Url == loginUrl);

            _driver.Close();

        }

        [Theory]
        [InlineData("test.test", "Parola123+", true)]
        [InlineData("test", "Parola", false)]

        public void TestLoginWithDifferentUsers(string username, string password, bool expectLogin)
        {
            _driver = new ChromeDriver();
            _wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 20));

            var url = "http://ngen-bo-dev.feelit.iasi.net";
            var newUrl = "http://ngen-bo-dev.feelit.iasi.net/home";

            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();

            var sheffieldWebPage = new SheffieldLoginPage(_driver, _wait);

            sheffieldWebPage.Login(username, password);

            if (expectLogin)
            {
                Assert.True(_driver.Url == newUrl);

            }
            else
            {
                Assert.False(_driver.Url == newUrl);
            }

            _driver.Close();

        }

    }
}
