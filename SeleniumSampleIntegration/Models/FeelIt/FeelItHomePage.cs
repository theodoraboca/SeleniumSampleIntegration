using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumSampleIntegration.Models.FeelIt
{
    class FeelItHomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private IWebElement _careersLink => _driver.FindElement(By.CssSelector(".menu-careers a"));
        private IWebElement _contactUsLink => _driver.FindElement(By.CssSelector(".menu-contact-us a"));


        public FeelItHomePage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public FeelItHomePage ClickTopMenuCareers()
        {
            _careersLink.Click();
            Thread.Sleep(1000);

            return this;
        }

        public FeelItHomePage ClickTopMenuContactUs()
        {
            _contactUsLink.Click();
            Thread.Sleep(1000);

            return this;
        }


    }
}
