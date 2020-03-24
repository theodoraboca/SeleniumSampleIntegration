using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumSampleIntegration.Models.Sheffield
{
    class SheffieldLoginPage : PageBase 
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public SheffieldLoginPage(IWebDriver driver, WebDriverWait wait)
                  :base(driver, wait)
        { 
            _driver = driver;
            _wait = wait;

        }
        
        public IWebElement Username => _driver.FindElement(By.CssSelector(".login-form .form-group div .form-control"));
        public IWebElement Password => _driver.FindElement(By.Id("inputPassword"));


        public SheffieldHomePage Login(string username, string password)
        {
            
            var clickButton = _driver.FindElement(By.ClassName("login-button"));
            Username.SendKeys(username);
            Password.SendKeys(password);
            clickButton.Click();
            Thread.Sleep(5000);
            return new SheffieldHomePage(_driver, _wait);
        }





    }

        

}
