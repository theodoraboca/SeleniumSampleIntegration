using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;
using Xunit.Sdk;

namespace SeleniumSampleIntegration
{
       public class NGEN_Tests
    {
        [Fact]
        public void LoginFunctionality()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Url = "https://ngen-uat.rgiseu.com";
            driver.Navigate();
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElementById(Constants.Ngen.LoginPage.EventId).SendKeys(Constants.Ngen.LoginPage.User);
            driver.FindElementById(Constants.Ngen.LoginPage.EventCodeId).SendKeys(Constants.Ngen.LoginPage.Password);
            driver.FindElementById(Constants.Ngen.LoginPage.BadgeId).SendKeys("theo");
            driver.FindElementByClassName(Constants.Ngen.LoginPage.RadioButtonClass).Click();
            driver.FindElementByClassName(Constants.Ngen.LoginPage.SubmitButtonClass).Click();
            string newUrl = "https://ngen-uat.rgiseu.com/#/prepare/start/inventory-properties";
            Thread.Sleep(2000);
            Assert.True( driver.Url == newUrl);
            driver.Close();
        }
    }
}
