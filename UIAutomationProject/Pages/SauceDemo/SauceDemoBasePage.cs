using Boa.Constrictor.Selenium;
using OpenQA.Selenium;


namespace UIAutomationProject.Pages.SauceDemo
{
    public class SauceDemoBasePage : BasePage
    {

        public WebLocator MenuButton => Locator("id", "react-burger-menu-btn");
        public WebLocator AllItemsLink => Locator("id", "inventory_sidebar_link");
        public WebLocator AboutLink => Locator("id", "about_sidebar_link");
        public WebLocator ResetAppState => Locator("id", "reset_sidebar_link");
        public WebLocator LogoutLink => Locator("id", "logout_sidebar_link");
        public WebLocator ShoppingCart => Locator("class", "shopping_cart_link", "a");


    }
}
