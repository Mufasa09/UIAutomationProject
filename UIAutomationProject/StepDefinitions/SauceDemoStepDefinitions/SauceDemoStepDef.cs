using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UIAutomationProject.Tests.SauceDemoTests;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.StepDefinitions.SauceDemoStepDefinitions
{
    [Binding]
    public class APIStepDef
    {

        public APIStepDef(IWebDriver driver)
        {
            SauceDemoTests = new SauceDemoTests(driver);
        }
        SauceDemoTests SauceDemoTests { get; }

        [When("I enter (.*) user credentials on SauceDemo site")]
        [Then("I enter (.*) user credentials on SauceDemo site")]
        public void EnterUserCredentials(string role, Table data)
        {
            SauceDemoTests.EnterUserCredSauceDemo(data.CreateInstance<BaseData>());

        }

        [When("I enter (.*) user credentials on SauceDemo site")]
        [Then("I enter (.*) user credentials on SauceDemo site")]
        public void EnterUserCredentials(string role)
        {
            SauceDemoTests.EnterUserCredSauceDemo(role);
        }

        [When(@"I verify user is on the main page")]
        [Then(@"I verify user is on the main page")]
        public void ThenIVerifyUserIsOnTheMainPage()
        {
            SauceDemoTests.VerifyProductPage();
        }

        [Then(@"I logout")]
        public void ThenILogout()
        {
            SauceDemoTests.VerifyICanLogout();
        }


        [Then(@"I (.*) the item (.*) to the cart")]
        public void ThenIAddAnItemToTheCart(string action, string item)
        {
            SauceDemoTests.AddItemToCart(item, action);
        }

        [Then(@"I (.*) the item to the cart")]
        public void ThenIAddAnItemToTheCart(string action, Table data)
        {
            SauceDemoTests.AddItemToCart(data.CreateInstance<InventoryData>(), action);
        }

        [Then(@"I verify it was added to the cart")]
        public void ThenIVerifyItWasAddedToTheCart(Table data)
        {
            SauceDemoTests.VerifyItemsInCart(data.CreateInstance<InventoryData>());
        }

        [Then(@"I clear the cart")]
        public void ThenIClearTheCart()
        {
            SauceDemoTests.ClearCart();
        }

        [Then(@"I verify items in cart before removing")]
        public void ThenIVerifyItemsInCartBeforeRemoving(Table data)
        {
            SauceDemoTests.VerifyItemsInCart(data.CreateInstance<InventoryData>());
            SauceDemoTests.ClearCart();
        }
    }
}