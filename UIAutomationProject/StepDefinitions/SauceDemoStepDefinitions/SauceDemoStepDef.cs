using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UIAutomationProject.Tests.SauceDemoTests;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.StepDefinitions.SauceDemoStepDefinitions
{
    [Binding]
    public class SauceDemoStepDef
    {

        public SauceDemoStepDef(IWebDriver driver)
        {
            SauceDemoTests = new SauceDemoTests(driver);
        }
        SauceDemoTests SauceDemoTests { get; }

        [Given("Navigate to SauceDemo site")]
        public void NavigateToSauceDemoSite()
        {
            SauceDemoTests.NavigateToSDSite();
        }

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

        [Then(@"I verify user is on the main page")]
        public void ThenIVerifyUserIsOnTheMainPage()
        {
            SauceDemoTests.VerifyProductPage();
        }
    }
}