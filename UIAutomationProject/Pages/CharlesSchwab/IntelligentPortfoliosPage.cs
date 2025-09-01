using OpenQA.Selenium;


namespace UIAutomationProject.Pages.CharlesSchwab
{
    public class IntelligentPortfoliosPage
    {

        public By GetStartedButton => By.XPath("//*[contains(@data-dl-link.name,'Get started')]");
        public By LiveChatButton => By.XPath("//*[contains(@data-dl-link.name,'Live chat')]");
        public By OpenAnAccountButton => By.XPath("//*[contains(@data-dl-link.name,'Open an account')]");
        public By FindBranch => By.XPath("//*[contains(@data-dl-link.name,'Find a local branch to apply in person')]");
        public By StackUpButton => By.XPath("//*[contains(@data-dl-link.name,'See how we stack up')]");
        public By TakeADeeperDive => By.XPath("//*[contains(@data-dl-link.name,'Take a deeper dive')]");
        public By RebalancingMoreInformation => By.XPath("//*[contains(@data-dl-link.name,'More information about automatic rebalancing')]");
        public By AccountsMoreInformation => By.XPath("//*[contains(@aria-label,'More information about the range of accounts')]");
    }
}
