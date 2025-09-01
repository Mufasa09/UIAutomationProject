using TechTalk.SpecFlow;
using UIAutomationProject.Helpers;
using UIAutomationProject.Tests.CharlesSchwabTests;

namespace UIAutomationProject.StepDefinitions.CharlesSchwabStepDefinitions
{
    [Binding]
    public class IntelligentPortfolioStepDefinitions
    {

        public IntelligentPortfolioStepDefinitions()
        {

            IntelligentPortfolioTests = new IntelligentPortfolioTests(DriverFactory.getWebDriver());
        }
        IntelligentPortfolioTests IntelligentPortfolioTests { get; }



        [Given(@"I navigate to (.*) from (.*)")]
        [When(@"I navigate to (.*) from (.*)")]
        public void WhenINavigateToIntelligentPortfolio(String subMenu, String menu)
        {
            IntelligentPortfolioTests.NavigateToPages(subMenu, menu);
        }

        [When(@"I access the Get Started button")]
        [Then(@"I access the Get Started button")]
        public void ThenIAccessGetStartedButton()
        {
            IntelligentPortfolioTests.AccessGetStartedButton();
        }




    }
}
