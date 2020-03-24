using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumSampleIntegration.Models.Sheffield
{
    public class AccountHomePage:PageBase
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
       
        public AccountHomePage(IWebDriver driver, WebDriverWait wait)
            :base(driver, wait)
        {
            _driver = driver;
            _wait = wait;
        }

    }
}