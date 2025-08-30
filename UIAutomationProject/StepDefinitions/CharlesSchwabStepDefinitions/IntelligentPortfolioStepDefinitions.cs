using UIAutomationProject.Tests.CharlesSchwabTests;

namespace UIAutomationProject.StepDefinitions.CharlesSchwabStepDefinitions
{
    public class IntelligentPortfolioStepDefinitions
    {

        public IntelligentPortfolioStepDefinitions()
        {

            IntelligentPortfolioTests = new IntelligentPortfolioTests(DriverFactory.getWebDriver());
        }
        IntelligentPortfolioTests IntelligentPortfolioTests { get; }

        //[When("I enter (.*) user credentials on SauceDemo site")]
        //[Then("I enter (.*) user credentials on SauceDemo site")]
        //public void EnterUserCredentials(Table data)
        //{
        //    SauceDemoTests.EnterUserCredSauceDemo(data.CreateInstance<BaseData>());

        //}

        [When("I enter (.*) user credentials on SauceDemo site")]
        [Then("I enter (.*) user credentials on SauceDemo site")]
        public void EnterUserCredentials(string role)
        {
            SauceDemoTests.EnterUserCredSauceDemo(role);
        }

    }
}
