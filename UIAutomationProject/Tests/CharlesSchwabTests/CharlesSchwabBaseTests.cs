using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using UIAutomationProject.Helpers;
using UIAutomationProject.Interactions.CharlesSchwab;
using UIAutomationProject.Pages;
using UIAutomationProject.Pages.CharlesSchwab;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.Tests.CharlesSchwabTests
{
    public class CharlesSchwabBaseTests : BaseTests
    {
        IWebDriver driver;
        public CharlesSchwabBaseTests(IWebDriver _driver) : base(_driver)
        {
            driver = _driver;
            IntelligentPortfoliosPage = new IntelligentPortfoliosPage();
            User = new User("CharlesSchwabBaseTests", driver);
            User.Can(Boa.Constrictor.Selenium.BrowseTheWeb.With(driver));
        }

        IntelligentPortfoliosPage IntelligentPortfoliosPage { get; set; }
        User User { get; set; }

        public void NavigateToPages(string subMenu, string menu)
        {
            User.AttemptsTo(MenuNavigation.To(menu, subMenu));
        }

        public void SecondaryNavigationPages(string menu, BaseData baseData)
        {
            User.AttemptsTo(MenuNavigation.To(menu, baseData.Item1, true));
        }

        public void SecondaryNavigationPages(string menu)
        {
            User.AttemptsTo(MenuNavigation.To(menu, "", true));
        }

        public void AccessButton(String button)
        {
            switch (button)
            {
                case "Get Started":
                    User.AttemptsTo(Click.On(IntelligentPortfoliosPage.GetStartedButton));
                    SwitchNewWindow();
                    break;
                case "Take a deeper dive":
                    User.AttemptsTo(Click.On(IntelligentPortfoliosPage.TakeADeeperDive));
                    break;
                case "See how we stack up":
                    User.AttemptsTo(Click.On(IntelligentPortfoliosPage.StackUpButton));
                    break;
                case "Open an account":
                    User.AttemptsTo(Click.On(IntelligentPortfoliosPage.OpenAnAccountButton));
                    SwitchNewWindow();
                    break;
                case "Find a local branch to apply in person":
                    User.AttemptsTo(Click.On(IntelligentPortfoliosPage.FindBranch));
                    SwitchNewWindow();
                    break;

                default: 
                    throw new NotFoundException("Not found");
            }
        }
    }
}
