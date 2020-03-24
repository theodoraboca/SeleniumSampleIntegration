using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace SeleniumSampleIntegration
{
   public class SheffieldTests
    {
        ChromeDriver driver { get; set; }

        
        [Fact]
        public void LoginFunctionality()
        {
            driver = new ChromeDriver();
            driver.Url = "http://ngen-bo-dev.feelit.iasi.net";
            driver.Navigate();
            driver.Manage().Window.Maximize();
            driver.FindElementById(Constants.Sheffield.LoginPage.InputUsernameId).SendKeys(Constants.Sheffield.LoginPage.User);
            driver.FindElementById(Constants.Sheffield.LoginPage.InputPasswordId).SendKeys(Constants.Sheffield.LoginPage.Password);
            driver.FindElementByClassName(Constants.Sheffield.LoginPage.LoginButtonClass).Click();
            string newUrl = "http://ngen-bo-dev.feelit.iasi.net/home";
            Thread.Sleep(2000);
            Assert.True(driver.Url == newUrl);
            driver.Close();
            
        }

        [Fact]
        public void AccountCategorySampleTest()
        {

        } 

    }
}
