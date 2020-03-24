using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSampleIntegration.Models.Sheffield
{
    public class PageBase
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public PageBase(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public IWebElement BackButton => _driver.FindElement(By.ClassName("back-arrow"));

        public SheffieldHomePage ClickOnBackButton()
        {
            BackButton.Click();
            return new SheffieldHomePage(_driver, _wait);
        }


        public IWebElement FullScreen => _driver.FindElements(By.ClassName("options-icon"))[2];
        public IWebElement Minimize => _driver.FindElement(By.ClassName("minimize-button-login"));

        public SheffieldHomePage OpenFullScreen()
        {
            FullScreen.Click();
            return new SheffieldHomePage(_driver, _wait);
        }

        public SheffieldHomePage MinimizeScreen()
        {
            Minimize.Click();
            return new SheffieldHomePage(_driver, _wait);
        }


        public IWebElement LogoutButton => _driver.FindElements(By.ClassName("options-icon"))[3];

        public void Logout()
        {
            LogoutButton.Click();

        }
    }


}
