using OpenQA.Selenium;

namespace UIAutomationProject.Pages.SauceDemo
{
    public class SauceDemoCartPage : SauceDemoInventoryPage
    {
        new public string title = "Cart";
        public By Checkout => By.Id("checkout");
        public By ContinueShopping => By.Id("continue-shopping");

    }
}
