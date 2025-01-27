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

        public void VerifyLoginError(BaseData baseData)
        {
            Thread.Sleep(3000);
            if(driver.FindElements(SauceDemoLoginPage.LoginErrorContainer).Count() > 0)
                if (baseData.UserName != null)
                    Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginErrorContainer).Text.Contains("Epic sadface: Sorry, this user has been locked out."));
                else
                    Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginErrorContainer).Text.Contains("Epic sadface: Username is required"));
        }

        public void VerifyLoginPageElements()
        {
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.UserNameTextBox).Displayed);
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.PasswordTextBox).Displayed);
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginButton).Displayed);
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginButton).Enabled);
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginUserCredentialsText).Displayed);
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginPasswordCredentialsText).Displayed);
        }
    }
}