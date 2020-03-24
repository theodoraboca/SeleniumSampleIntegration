using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumSampleIntegration.Models.Sheffield
{
    public class SystemAdminHomePage : PageBase
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public SystemAdminHomePage(IWebDriver driver, WebDriverWait wait)
            :base(driver, wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public IWebElement SystemAdminTab => _driver.FindElement(By.ClassName("dropdown-icon"));
        public IWebElement SystemAdminDropdown => _driver.FindElement(By.CssSelector(".sidebar-sticky ul"));

        public SystemAdminHomePage OpenSystemAdminDropdown()
        {
            SystemAdminTab.Click();
            return this;
        }

        public SystemAdminHomePage SelectFromSystemAdminDropdown(string dropdownElement)
        {
            var systemAdminDropdownElement = new SelectElement(SystemAdminDropdown);
            systemAdminDropdownElement.SelectByText(dropdownElement);
            return this;               
        }



        

    }
}