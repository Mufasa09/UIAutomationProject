using OpenQA.Selenium;

namespace UIAutomationProject.Pages.CharlesSchwab
{
    public class IPBasePage : BasePage
    {

        public By OpenAnAccountButton => CustomXpath("type", "open-an-account");
        public By SearchBar => CustomXpath("type", "search");
        public By ChatLink => CustomXpath("id", "chatGlobalHeader");
        public By FindBranchButton => CustomXpath("data-dl-link.name", "Find a Branch");
        public By LoginButton => CustomXpath("data-dl-component.title", "Log In menu");



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


        public By SchwabIntelligentPortfolios => CustomXpath("data-dl-link.name", "Schwab Intelligent Portfolios");
        public By SchwabIntelligentPortfoliosPremium => CustomXpath("data-dl-link.name", "Schwab Intelligent Portfolios Premium");
        public By SchwabIntelligentIncome => CustomXpath("data-dl-link.name", "Schwab Intelligent Income");

        #region Compare Soultions
        public By CompareSoultions => CustomXpath("data-dl-link.name", "Compare Solutions");
        public By CompareOurSoultions => CustomXpath("data-dl-link.name", "Compare our Solutions");
        public By CompareUsToOthers => CustomXpath("data-dl-link.name", "Compare us to others");
        #endregion

        #region Resources
        public By Resources => CustomXpath("data-dl-link.name", "Resources");
        public By RoboAdvice => CustomXpath("data-dl-link.name", "An Introduction to Robo-Advice");
        public By RoboAdvisorMyths => CustomXpath("data-dl-link.name", "Robo Advisor Myths");
        public By Education => CustomXpath("data-dl-link.name", "Education");
        #endregion

        #endregion

    }
}
