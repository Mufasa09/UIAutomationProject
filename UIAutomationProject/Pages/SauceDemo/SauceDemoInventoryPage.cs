using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UIAutomationProject.Pages.SauceDemo
{
    public class SauceDemoInventoryPage : SauceDemoBasePage
    {
        public string title = "Products";
        public By Menu => By.Id("react-burger-menu-btn");
        public By Title => By.XPath("//span[contains(@class,'title')]");

        #region Products
        public By SauceLabsBackpack(string action = "add") => By.Id($"{action}-to-cart-sauce-labs-backpack");
        public By SauceLabsBikeLight(string action) => By.Id($"{action}-to-cart-sauce-labs-bike-light");
        public By SauceLabsBoltTshirt(string action) => By.Id($"{action}-to-cart-sauce-labs-bolt-t-shirt");
        public By SauceLabsFleeceJacket(string action) => By.Id($"{action}-to-cart-sauce-labs-fleece-jacket");
        public By SauceLabsOnsie(string action) => By.Id($"{action}-to-cart-sauce-labs-onesie");
        public By SauceLabsTshirtRed(string action) => By.Id($"{action}-to-cart-test.allthethings()-t-shirt-(red)");

        #endregion

        public By ShoppingCartLink => By.XPath("//a[contains(@class,'shopping_cart_link')]");
        public By CartDescription => By.XPath("//div[contains(@class,'cart_list')]");
        public By ShoppingCartBadge => By.XPath("//span[contains(@class,'shopping_cart_badge')]");
        public By RemoveButton => By.XPath("//button[contains(text(),'Remove')]");

    }
}
