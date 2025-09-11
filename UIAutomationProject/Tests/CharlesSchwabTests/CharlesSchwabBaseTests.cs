using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using UIAutomationProject.Helpers;
using UIAutomationProject.Interactions.CharlesSchwab;
using UIAutomationProject.Pages;
using UIAutomationProject.Pages.CharlesSchwab;

namespace UIAutomationProject.Tests.CharlesSchwabTests
{
    public class CharlesSchwabBaseTests : BaseTests
    {
        IWebDriver driver;
        public CharlesSchwabBaseTests(IWebDriver _driver) : base(_driver)
        {
            driver = _driver;
            IntelligentPortfoliosPage = new IntelligentPortfoliosPage();
        }

        IntelligentPortfoliosPage IntelligentPortfoliosPage { get; set; }
        User User { get; set; }

        public void NavigateToPages(String subMenu, String menu)
        {
            User = new User("NavigateToPages", driver);
            User.Can(Boa.Constrictor.Selenium.BrowseTheWeb.With(driver));
            User.AttemptsTo(MenuNavigation.To(menu, subMenu));
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
