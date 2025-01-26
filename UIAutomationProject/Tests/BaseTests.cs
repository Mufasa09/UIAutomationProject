using NUnit.Framework;
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
            SauceDemoLoginPage = new SauceDemoLoginPage();
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

        public void VerifyLoginError()
        {
            Thread.Sleep(3000);
            if(driver.FindElements(SauceDemoLoginPage.LoginErrorContainer).Count() > 0)
                Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginErrorContainer).Text.Contains("Epic sadface: Sorry, this user has been locked out."));
        }
    }
}