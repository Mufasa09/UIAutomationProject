using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UIAutomationProject.Helpers;
using UIAutomationProject.Tests.CharlesSchwabTests;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.StepDefinitions.CharlesSchwabStepDefinitions
{
    [Binding]
    public class CharlesSchwabStepDefinition
    {

        public CharlesSchwabStepDefinition()
        {

            IntelligentPortfolioTests = new IntelligentPortfolioTests(DriverFactory.getWebDriver());
        }
        IntelligentPortfolioTests IntelligentPortfolioTests { get; }



        [Given(@"I navigate to (.*) from (.*)")]
        [When(@"I navigate to (.*) from (.*)")]
        public void WhenINavigateToIntelligentPortfolio(string subMenu, string menu)
        {
            IntelligentPortfolioTests.NavigateToPages(subMenu, menu);
        }

        [When(@"I access the (.*) button")]
        [Then(@"I access the (.*) button")]
        public void ThenIAccessButton(string button)
        {
            IntelligentPortfolioTests.AccessButton(button);
        }

        [Given(@"I navigate to the secondary link (.*)")]
        [When(@"I navigate to the secondary link (.*)")]
        public void ThenIAccessTheLink(string menu, Table data)
        {
            IntelligentPortfolioTests.SecondaryNavigationPages(menu, data.CreateInstance<BaseData>());
        }

        [Given(@"I navigate to the secondary link (.*)")]
        [When(@"I navigate to the secondary link (.*)")]
        public void ThenIAccessTheLink(string menu)
        {
            IntelligentPortfolioTests.SecondaryNavigationPages(menu);
        }

    }
}
