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

        public APIStepDef(IAPIStorage apiStorage)
        {
            APITests = new APITests(apiStorage);
        }
        APITests APITests { get; }

        [Given("I navigate to API site")]
        public void BasicAPICall()
        {
            //APITests.NavigateToAPISite("https://apidog.com/");
            APITests.NavigateToAPISite("https://jsonplaceholder.typicode.com");
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

        [Then(@"I make an api post call")]
        public void ThenIMakeAnApiPostCall(Table data)
        {
            APITests.VerifyPostData(data.CreateInstance<APIData>());
        }


    }
}