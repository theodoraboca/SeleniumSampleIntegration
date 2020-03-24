using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumSampleIntegration.Models.FeelIt;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumSampleIntegration.Models.Google
{
    class GoogleResultsPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public IWebElement FirstResultLink => _driver.FindElement(By.CssSelector(".r a"));

        public GoogleResultsPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public FeelItHomePage SelectFirstResult()
        {
            FirstResultLink.Click();
            Thread.Sleep(1000);

            return new FeelItHomePage(_driver, _wait);
        }

    }
}
