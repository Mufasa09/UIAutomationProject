using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UIAutomationProject.Pages.SauceDemo
{
    public class SauceDemoInventoryPage
    {
        public string title = "Products";
        public By Menu => By.Id("react-burger-menu-btn");
        public By ShoppingCart => By.XPath("//a[contains(@class,'shopping_cart_link')]");
        public By Title => By.XPath("//span[contains(@class,'title')]");
    }
}
