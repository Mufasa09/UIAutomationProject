using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UIAutomationProject.Tests;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.StepDefinitions.API
{
    [Binding]
    public class APIStepDef
    {

        public APIStepDef(IWebDriver driver)
        {
            APITests = new APITests();
        }
        APITests APITests { get; }

        [Given("I navigate to API site")]
        public void BasicAPICall()
        {
            APITests.NavigateToAPISite("https://apidog.com/");
        }

        [When(@"I verify successful api call")]
        public void WhenIVerifySuccessfulApiCall(Table data)
        {
            APITests.VerifySuccessMessage(data.CreateInstance<APIData>());
        }

        [Then(@"I verify response body")]
        public void ThenIVerifyResponseBody(Table data)
        {
            APITests.VerifyResponseBody(data.CreateInstance<APIData>());
        }

    }
}