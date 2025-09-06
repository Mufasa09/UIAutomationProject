using Boa.Constrictor.Selenium;
using OpenQA.Selenium;

namespace UIAutomationProject.Pages.CharlesSchwab
{
    public class IPBasePage : BasePage
    {

        #region Common variable
        private string identifier = "data-dl-link.name";
        #endregion


        public WebLocator OpenAnAccountButton => Locator("type", "open-an-account");
        public WebLocator SearchBar => Locator("type", "search");
        public WebLocator ChatLink => Locator("id", "chatGlobalHeader");
        public WebLocator FindBranchButton => Locator(identifier, "Find a Branch");
        public WebLocator LoginButton => Locator("data-dl-component.title", "Log In menu");



        #region Menu Options

        #region Accounts & Products

        #endregion

        #region Advice

        #endregion

        #region Pricing

        #endregion

        #region Why Schwab

        #endregion

        #region Learn

        #endregion


        public WebLocator SchwabIntelligentPortfolios => Locator(identifier, "Schwab Intelligent Portfolios");
        public WebLocator SchwabIntelligentPortfoliosPremium => Locator(identifier, "Schwab Intelligent Portfolios Premium");
        public WebLocator SchwabIntelligentIncome => Locator(identifier, "Schwab Intelligent Income");

        #region Compare Soultions
        public WebLocator CompareSoultions => Locator(identifier, "Compare Solutions");
        public WebLocator CompareOurSoultions => Locator(identifier, "Compare our Solutions");
        public WebLocator CompareUsToOthers => Locator(identifier, "Compare us to others");
        #endregion

        #region Resources
        public WebLocator Resources => Locator(identifier, "Resources");
        public WebLocator RoboAdvice => Locator(identifier, "An Introduction to Robo-Advice");
        public WebLocator RoboAdvisorMyths => Locator(identifier, "Robo Advisor Myths");
        public WebLocator Education => Locator(identifier, "Education");
        #endregion

        #endregion

    }
}
