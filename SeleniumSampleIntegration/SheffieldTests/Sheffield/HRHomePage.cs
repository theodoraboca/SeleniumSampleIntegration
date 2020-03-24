using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumSampleIntegration.Models.Sheffield
{
    public class HRHomePage : PageBase
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public HRHomePage(IWebDriver driver, WebDriverWait wait)
            :base(driver, wait)
        {
            _driver = driver;
            _wait = wait;
        }
    }
}