using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UIAutomationProject.Tests;

namespace UIAutomationProject.StepDefinitions
{
    [Binding]
    public class BaseStepDefinitions 
    {

        public BaseStepDefinitions(IWebDriver driver)
        {
            Tests = new BaseTests(driver);
        }
        BaseTests Tests { get; }


        [Given("Navigate to site (.*)")]
        public void NavigateToSite(string site)
        {
            Tests.NavigateToSite(site);

        }

        [Given("I verify the title of the site is (.*)")]
        [When("I verify the title of the site is (.*)")]
        [Then("I verify the title of the site is (.*)")]
        public void VerifySiteTitle(string title)
        {
            Tests.VerifyTitle(title);

        }

        [When("I enter user credentials")]
        [Then("I enter user credentials")]
        public void EnterUserCredentials(Table data)
        {
        //    Tests.EnterUserCred(data.CreateInstance<>());

        }


    }
}