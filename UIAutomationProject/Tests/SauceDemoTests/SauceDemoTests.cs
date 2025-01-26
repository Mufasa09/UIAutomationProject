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
        }

        SauceDemoLoginPage SauceDemoLoginPage { get; set; }


        public void EnterUserCredSauceDemo(BaseData baseData)
        {
            driver.FindElement(SauceDemoLoginPage.UserNameTextBox).SendKeys(baseData.UserName);
            driver.FindElement(SauceDemoLoginPage.PasswordTextBox).SendKeys(baseData.Password);
        }
    }
}