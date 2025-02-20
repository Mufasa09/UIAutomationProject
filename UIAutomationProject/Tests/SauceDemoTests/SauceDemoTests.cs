using NUnit.Framework;
using OpenQA.Selenium;
using UIAutomationProject.Pages.SauceDemo;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.Tests.SauceDemoTests
{
    public class SauceDemoTests : BaseTests
    {
        private IWebDriver driver;

        public SauceDemoTests(IWebDriver _driver) : base(_driver)
        {
            driver = _driver;
            SauceDemoLoginPage = new SauceDemoLoginPage();
            SauceDemoInventoryPage = new SauceDemoInventoryPage();
        }

        #region Variables
        SauceDemoLoginPage SauceDemoLoginPage { get; set; }
        SauceDemoInventoryPage SauceDemoInventoryPage { get; set; }
        #endregion


        #region Methods
        public void NavigateToSDSite()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        public void EnterUserCredSauceDemo(BaseData baseData)
        {
            Wait(2000);
            driver.FindElement(SauceDemoLoginPage.UserNameTextBox).SendKeys(UserAccountName(baseData.Role));
            driver.FindElement(SauceDemoLoginPage.PasswordTextBox).SendKeys(UserAccountPassword(baseData.Role));
            driver.FindElement(SauceDemoLoginPage.LoginButton).Click();
        }

        public void EnterUserCredSauceDemo(string role)
        {
            Wait(2000);
            driver.FindElement(SauceDemoLoginPage.UserNameTextBox).SendKeys(UserAccountName(role));
            driver.FindElement(SauceDemoLoginPage.PasswordTextBox).SendKeys(UserAccountPassword(role));
            driver.FindElement(SauceDemoLoginPage.LoginButton).Click();
        }

        public void VerifyProductPage()                
        {
            Wait(3000);
            if(driver.FindElements(SauceDemoLoginPage.LoginErrorContainer).Count() > 0)
                Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginErrorContainer).Text.Contains("Epic sadface: Sorry, this user has been locked out."));
            else
                Assert.IsTrue(driver.FindElement(SauceDemoInventoryPage.Title).Text.Contains("Products"));
        }
        #endregion
    }
}