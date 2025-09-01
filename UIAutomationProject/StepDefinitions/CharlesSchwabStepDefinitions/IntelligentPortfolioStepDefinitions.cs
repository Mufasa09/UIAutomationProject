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

        [When(@"I access the (.*) button")]
        [Then(@"I access the (.*) button")]
        public void ThenIAccessButton(String button)
        {
            IntelligentPortfolioTests.AccessButton(button);
        }




    }
}
