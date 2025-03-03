using OpenQA.Selenium;


namespace UIAutomationProject.Pages.SauceDemo
{
    public class SauceDemoBasePage
    {
        public By MenuButton => By.Id("react-burger-menu-btn");
        public By AllItemsLink => By.Id("inventory_sidebar_link");
        public By AboutLink => By.Id("about_sidebar_link");
        public By ResetAppState => By.Id("reset_sidebar_link");
        public By LogoutLink => By.Id("logout_sidebar_link");
        public By ShoppingCart => By.XPath("//a[contains(@class,'shopping_cart_link')]");


    }
}
