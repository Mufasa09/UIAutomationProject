using OpenQA.Selenium;
using Boa.Constrictor.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;

namespace UIAutomationProject.Pages.CharlesSchwab
{
    public class IntelligentPortfoliosPage : BasePage
    {
        #region Common variable
        private string identifier = "data-dl-link.name";
        #endregion

        public IWebLocator GetStartedButton => Locator(identifier, "Get started");
        public IWebLocator LiveChatButton => Locator(identifier, "Live chat");
        public IWebLocator OpenAnAccountButton => Locator(identifier, "Open an account");
        public IWebLocator FindBranch => Locator(identifier, "Find a local branch to apply in person");
        public IWebLocator StackUpButton => Locator(identifier, "See how we stack up");
        public IWebLocator TakeADeeperDive => Locator(identifier, "Take a deeper dive");
        public IWebLocator RebalancingMoreInformation => Locator(identifier, "More information about automatic rebalancing");
        public IWebLocator AccountsMoreInformation => Locator("aria-label","More information about the range of accounts");
    }
}
