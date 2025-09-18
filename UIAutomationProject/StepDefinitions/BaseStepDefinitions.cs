using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UIAutomationProject.Helpers;
using UIAutomationProject.Tests;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.StepDefinitions
{
    [Binding]
    public class BaseStepDefinitions 
    {

        public BaseStepDefinitions()
        {
            Tests = new BaseTests(DriverFactory.getWebDriver());
        }
        BaseTests Tests { get; }


        [Given("Navigate to site (.*)")]
        public void NavigateToSite(string site)
        {
            Tests.NavigateToSite(site);

        }

        [Then(@"I verify the page is displayed")]
        public void ThenIVerifyThePageIsDisplayed(Table data)
        {
            Tests.PageVerification(data.CreateInstance<BaseData>());
        }


        [Given("I verify the title of the site is (.*)")]
        [When("I verify the title of the site is (.*)")]
        [Then("I verify the title of the site is (.*)")]
        public void VerifySiteTitle(string title)
        {
            Tests.VerifyTitle(title);
        }

        [Given("I verify the title of the site is (.*)")]
        [When("I verify the title of the site is (.*)")]
        [Then("I verify the title of the site is (.*)")]
        public void VerifySiteTitle(string title, Table data)
        {
            Tests.VerifyTitle(title, data.CreateInstance<BaseData>());
        }

        [Given("I verify the url of the site is (.*)")]
        [When("I verify the url of the site is (.*)")]
        [Then("I verify the url of the site is (.*)")]
        public void VerifySiteURL(string url)
        {
            Tests.VerifyURL(url);
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