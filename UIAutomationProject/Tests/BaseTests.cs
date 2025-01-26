using OpenQA.Selenium;
using UIAutomationProject.Pages.SauceDemo;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.Tests
{
    public class BaseTests 
    {
        private IWebDriver driver;

        public BaseTests(IWebDriver _driver) 
        {
            driver = _driver;
        }

        SauceDemoLoginPage SauceDemoLoginPage { get; set; }

       public void NavigateToSite(string site)
        {
            driver.Navigate().GoToUrl(site);
        }

        public void VerifyTitle(string title)
        {
            driver.Title.Contains(title);
        }

        public void EnterUserCred(BaseData baseData, string userNameTextBox, string passwordTextBox)
        {
            driver.FindElement(By.Id(userNameTextBox)).SendKeys(baseData.UserName);
            driver.FindElement(By.Id(passwordTextBox)).SendKeys(baseData.Password);
        }
    }
}