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

        SauceDemoLoginPage SauceDemoLoginPage { get; set; }
        SauceDemoInventoryPage SauceDemoInventoryPage { get; set; }


        public void EnterUserCredSauceDemo(BaseData baseData)
        {

            Wait(2000);
            driver.FindElement(SauceDemoLoginPage.UserNameTextBox).SendKeys(baseData.UserName);
            driver.FindElement(SauceDemoLoginPage.PasswordTextBox).SendKeys(baseData.Password);
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
    }
}