using OpenQA.Selenium;
using Boa.Constrictor.Selenium;



namespace UIAutomationProject.Pages.SauceDemo
{
    public class SauceDemoInventoryPage : SauceDemoBasePage
    {
        public string title = "Products";
        public WebLocator Menu => Locator("id", "react-burger-menu-btn");
        public WebLocator Title => Locator("class", "title","span");

        #region Products
        public WebLocator SauceLabsBackpack(string action = "add") => Locator("id",$"{action}-to-cart-sauce-labs-backpack");
        public WebLocator SauceLabsBikeLight(string action) => Locator("id",$"{action}-to-cart-sauce-labs-bike-light");
        public WebLocator SauceLabsBoltTshirt(string action) => Locator("id",$"{action}-to-cart-sauce-labs-bolt-t-shirt");
        public WebLocator SauceLabsFleeceJacket(string action) => Locator("id",$"{action}-to-cart-sauce-labs-fleece-jacket");
        public WebLocator SauceLabsOnsie(string action) => Locator("id",$"{action}-to-cart-sauce-labs-onesie");
        public WebLocator SauceLabsTshirtRed(string action) => Locator("id", $"{action}-to-cart-test.allthethings()-t-shirt-(red)");

        #endregion

        public WebLocator ShoppingCartLink => Locator("class", "shopping_cart_link", "a");
        public WebLocator CartDescription => Locator("class", "cart_list", "div");
        public WebLocator ShoppingCartBadge => Locator("class", "shopping_cart_badge", "span");
        public WebLocator RemoveButton => ButtonLocator("text()", "Remove");

    }
}
