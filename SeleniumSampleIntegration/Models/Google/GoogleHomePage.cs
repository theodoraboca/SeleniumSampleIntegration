using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SeleniumSampleIntegration.Models.Google
{
    class GoogleHomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public GoogleHomePage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public IWebElement SearchBox => _driver.FindElement(By.Name("q"));

        public GoogleResultsPage Search(string text)
        {
            SearchBox.SendKeys(text);
            SearchBox.Submit();
            //_wait.Until(By.);
            Thread.Sleep(1000);
            return new GoogleResultsPage(_driver, _wait);
        }
    }
}
