using OpenQA.Selenium;


namespace UIAutomationProject.Pages.SauceDemo
{
    public class SauceDemoInventoryPage
    {
        public string title = "Products";
        public By Title => By.XPath("//span[contains(@class,'title')]");
    }
}
