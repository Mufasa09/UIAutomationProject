using Boa.Constrictor.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UIAutomationProject.Helpers;
using UIAutomationProject.Pages.SauceDemo;
using UIAutomationProject.Questions;
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
            SauceDemoCartPage = new SauceDemoCartPage();
            User = new User("SauceDemoTests", driver);
            User.Can(Boa.Constrictor.Selenium.BrowseTheWeb.With(driver));
        }

        #region Variables
        SauceDemoLoginPage SauceDemoLoginPage { get; set; }
        SauceDemoInventoryPage SauceDemoInventoryPage { get; set; }
        SauceDemoCartPage SauceDemoCartPage { get; set; }
        User User { get; set; }
        #endregion


        #region Methods

        public void EnterUserCredSauceDemo(BaseData baseData)
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Time: {DateTime.Now}");
            User.AttemptsTo(SendKeys.To(SauceDemoLoginPage.UserNameTextBox, baseData.Role));
            User.AttemptsTo(SendKeys.To(SauceDemoLoginPage.PasswordTextBox, "secret_sauce"));
            User.AttemptsTo(Click.On(SauceDemoLoginPage.LoginButton));
        }

        public void EnterUserCredSauceDemo(string role)
        {
            Wait(2000);
            User.AttemptsTo(SendKeys.To(SauceDemoLoginPage.UserNameTextBox, role));
            User.AttemptsTo(SendKeys.To(SauceDemoLoginPage.PasswordTextBox, "secret_sauce"));
            User.AttemptsTo(Click.On(SauceDemoLoginPage.LoginButton));
        }

        public void VerifyProductPage()                
        {
            //if(driver.FindElements(SauceDemoLoginPage.LoginErrorContainer).Count() > 0)
                //VerifyTextData(SauceDemoLoginPage.LoginErrorContainer, "Epic sadface: Sorry, this user has been locked out.", true);
            if(User.AsksFor(Count.Of(SauceDemoLoginPage.LoginErrorContainer)) > 0)
                User.AsksFor(TextVerification.Of(SauceDemoLoginPage.LoginErrorContainer, true, "Epic sadface: Sorry, this user has been locked out."));
            else
                User.AsksFor(TextVerification.Of(SauceDemoInventoryPage.Title, true, "Products"));
                //VerifyTextData(SauceDemoInventoryPage.Title, "Products", true);
        }

        public void VerifyICanLogout()
        {
            User.AttemptsTo(Click.On(SauceDemoInventoryPage.MenuButton));
            User.AttemptsTo(Click.On(SauceDemoInventoryPage.LogoutLink));
            Assert.IsTrue(User.AsksFor(Appearance.Of(SauceDemoLoginPage.LoginButton)));
            //VerifyDataIsPresent(SauceDemoLoginPage.LoginButton,true);
        }

        public void AddItemToCart(string item, string action = "add")
        {
            switch (item)
            {
                case "Sauce Labs Backpack":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsBackpack(action)));
                    break;
                case "Sauce Labs Bike Light":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsBikeLight(action)));
                    break;
                case "Sauce Labs Bolt T-Shirt":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsBoltTshirt(action)));
                    break;
                case "Sauce Labs Fleece Jacket":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsFleeceJacket(action)));
                    break;
                case "Sauce Labs Onesie":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsOnsie(action)));
                    break;                
                case "Test.allTheThings() T-Shirt (Red)":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsTshirtRed(action)));
                    break;
                default:
                    throw new NotFoundException();
            }
        }


        public void AddItemToCart(InventoryData item, string action = "add")
        {
            switch (item.ItemName)
            {
                case "Sauce Labs Backpack":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsBackpack(action)));
                    break;
                case "Sauce Labs Bike Light":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsBikeLight(action)));
                    break;
                case "Sauce Labs Bolt T-Shirt":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsBoltTshirt(action)));
                    break;
                case "Sauce Labs Fleece Jacket":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsFleeceJacket(action)));
                    break;
                case "Sauce Labs Onesie":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsOnsie(action)));
                    break;
                case "Test.allTheThings() T-Shirt (Red)":
                    User.AttemptsTo(Click.On(SauceDemoInventoryPage.SauceLabsTshirtRed(action)));
                    break;
                default:
                    throw new NotFoundException();
            }
        }

        public void VerifyItemsInCart(string data)
        {
            //VerifyTextData(SauceDemoInventoryPage.CartDescription,data, true);
            User.AsksFor(TextVerification.Of(SauceDemoInventoryPage.CartDescription, true, data));

        }

        public void VerifyItemsInCart(InventoryData data)
        {
            User.AttemptsTo(Click.On(SauceDemoInventoryPage.ShoppingCartLink));
            User.AsksFor(Text.Of(SauceDemoInventoryPage.CartDescription));
            //VerifyTextData(SauceDemoInventoryPage.CartDescription, data.ItemName, true);
            User.AsksFor(TextVerification.Of(SauceDemoInventoryPage.CartDescription, true, data.ItemName));
        }

        public void ClearCart()
        {
            int finalCount = CartCount();
            for (int cartCount = 1; cartCount <= finalCount; cartCount++)
                User.AttemptsTo(Click.On(SauceDemoInventoryPage.RemoveButton));
        }

        public int CartCount()
        {
            // string count = GrabText(SauceDemoInventoryPage.ShoppingCartBadge);
            string count = User.AskingFor(Text.Of(SauceDemoInventoryPage.ShoppingCartBadge));
            return Int32.Parse(count);
        }
        #endregion
    }
}