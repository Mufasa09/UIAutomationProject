using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UIAutomationProject.Tests;
using UIAutomationProject.Utilities.Data;

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

        [Then(@"I verify login error")]
        public void ThenIVerifyUserIsOnTheMainPage()
        {
            Tests.VerifyLoginError();
        }


        [Then(@"I verify login error")]
        public void ThenIVerifyUserIsOnTheMainPage(Table data)
        {
            Tests.VerifyLoginError(data.CreateInstance<BaseData>());
        }

        [When(@"I verify login page elements")]
        [Then(@"I verify login page elements")]
        public void ThenIVerifyLoginPageElements()
        {
            Tests.VerifyLoginPageElements();
        }
    }
}