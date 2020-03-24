using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSampleIntegration.Models.Sheffield
{
    public class SheffieldHomePage : PageBase
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;


        public SheffieldHomePage(IWebDriver driver, WebDriverWait wait)
            :base(driver, wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public IWebElement SystemAdmin => _driver.FindElement(By.XPath("//button[@data-choice='systemAdmin']"));

        public SystemAdminHomePage OpenSystemAdmin()
        {
            SystemAdmin.Click();
            return new SystemAdminHomePage(_driver, _wait);

        }


        public IWebElement HR => _driver.FindElement(By.XPath("//a[@data-choice='employee']"));

        public HRHomePage OpenHR()
        {
            HR.Click();
            return new HRHomePage(_driver, _wait);
        }


        public IWebElement Account => _driver.FindElement(By.XPath("//a[@data-choice='account']"));
        
        public AccountHomePage OpenAccount()
        {
            Account.Click();
            return new AccountHomePage(_driver, _wait);
        }






      


                
    }
}
