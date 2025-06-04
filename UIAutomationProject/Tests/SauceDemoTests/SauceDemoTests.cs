using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UIAutomationProject.Pages.SauceDemo;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.Tests.SauceDemoTests
{
    public class SauceDemoTests : BaseTests
    {
        private IWebDriver driver;
        private string URL = "";

        public SauceDemoTests(IWebDriver _driver) : base(_driver)
        {
            driver = _driver;
            SauceDemoLoginPage = new SauceDemoLoginPage();
            SauceDemoInventoryPage = new SauceDemoInventoryPage();
            SauceDemoCartPage = new SauceDemoCartPage();
        }

        #region Variables
        SauceDemoLoginPage SauceDemoLoginPage { get; set; }
        SauceDemoInventoryPage SauceDemoInventoryPage { get; set; }
        SauceDemoCartPage SauceDemoCartPage { get; set; }
        #endregion


        #region Methods

        public void EnterUserCredSauceDemo(BaseData baseData)
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Time: {DateTime.Now}");
            Wait(2000);
            Enter(SauceDemoLoginPage.UserNameTextBox, baseData.Role);
            Enter(SauceDemoLoginPage.PasswordTextBox, "secret_sauce");
            Click(SauceDemoLoginPage.LoginButton);
        }

        public void EnterUserCredSauceDemo(string role)
        {
            Wait(2000);
            Enter(SauceDemoLoginPage.UserNameTextBox, role);
            Enter(SauceDemoLoginPage.PasswordTextBox, "secret_sauce");
            Click(SauceDemoLoginPage.LoginButton);
        }

        public void VerifyProductPage()                
        {
            Wait(3000);
            if(driver.FindElements(SauceDemoLoginPage.LoginErrorContainer).Count() > 0)
                VerifyTextData(SauceDemoLoginPage.LoginErrorContainer, "Epic sadface: Sorry, this user has been locked out.", true);
            else
                VerifyTextData(SauceDemoInventoryPage.Title, "Products", true);
        }

        public void VerifyICanLogout()
        {
            Wait(2000);
            Click(SauceDemoInventoryPage.MenuButton);
            Wait(500);
            Click(SauceDemoInventoryPage.LogoutLink);
            Wait(2000);
            VerifyDataIsPresent(SauceDemoLoginPage.LoginButton,true);
        }

        public void AddItemToCart(string item, string action = "add")
        {
            Wait(3000);
            switch (item)
            {
                case "Sauce Labs Backpack":
                    Click(SauceDemoInventoryPage.SauceLabsBackpack(action));
                    break;
                case "Sauce Labs Bike Light":
                    Click(SauceDemoInventoryPage.SauceLabsBikeLight(action));
                    break;
                case "Sauce Labs Bolt T-Shirt":
                    Click(SauceDemoInventoryPage.SauceLabsBoltTshirt(action));
                    break;
                case "Sauce Labs Fleece Jacket":
                    Click(SauceDemoInventoryPage.SauceLabsFleeceJacket(action));
                    break;
                case "Sauce Labs Onesie":
                    Click(SauceDemoInventoryPage.SauceLabsOnsie(action));
                    break;                
                case "Test.allTheThings() T-Shirt (Red)":
                    Click(SauceDemoInventoryPage.SauceLabsTshirtRed(action));
                    break;
                default:
                    throw new NotFoundException();
            }
        }


        public void AddItemToCart(InventoryData item, string action = "add")
        {
            Wait(3000);
            switch (item.ItemName)
            {
                case "Sauce Labs Backpack":
                    Click(SauceDemoInventoryPage.SauceLabsBackpack(action));
                    break;
                case "Sauce Labs Bike Light":
                    Click(SauceDemoInventoryPage.SauceLabsBikeLight(action));
                    break;
                case "Sauce Labs Bolt T-Shirt":
                    Click(SauceDemoInventoryPage.SauceLabsBoltTshirt(action));
                    break;
                case "Sauce Labs Fleece Jacket":
                    Click(SauceDemoInventoryPage.SauceLabsFleeceJacket(action));
                    break;
                case "Sauce Labs Onesie":
                    Click(SauceDemoInventoryPage.SauceLabsOnsie(action));
                    break;
                case "Test.allTheThings() T-Shirt (Red)":
                    Click(SauceDemoInventoryPage.SauceLabsTshirtRed(action));
                    break;
                default:
                    throw new NotFoundException();
            }
        }

        public void VerifyItemsInCart(string data)
        {
            VerifyTextData(SauceDemoInventoryPage.CartDescription,data, true);
        }

        public void VerifyItemsInCart(InventoryData data)
        {
            Click(SauceDemoCartPage.ShoppingCartLink);
            VerifyTextData(SauceDemoInventoryPage.CartDescription, data.ItemName, true);
        }

        public void ClearCart()
        {
            int finalCount = CartCount();
            for (int cartCount = 1; cartCount <= finalCount; cartCount++)
                Click(SauceDemoInventoryPage.RemoveButton);
        }

        public int CartCount()
        {
            string count = GrabText(SauceDemoInventoryPage.ShoppingCartBadge);
            return Int32.Parse(count);
        }
        #endregion
    }
}