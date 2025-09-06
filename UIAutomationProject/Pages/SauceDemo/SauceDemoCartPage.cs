using Boa.Constrictor.Selenium;
using OpenQA.Selenium;

namespace UIAutomationProject.Pages.SauceDemo
{
    public class SauceDemoCartPage : SauceDemoInventoryPage
    {
        new public string title = "Cart";
        public WebLocator Checkout => Locator("id","checkout");
        public WebLocator ContinueShopping => Locator("id","continue-shopping");

    }
}
