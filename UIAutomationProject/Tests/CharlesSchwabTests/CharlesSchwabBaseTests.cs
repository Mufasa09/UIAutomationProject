using OpenQA.Selenium;
using UIAutomationProject.Pages.CharlesSchwab;

namespace UIAutomationProject.Tests.CharlesSchwabTests
{
    public class CharlesSchwabBaseTests : BaseTests
    {
        public CharlesSchwabBaseTests(IWebDriver _driver) : base(_driver)
        {
            IntelligentPortfoliosPage = new IntelligentPortfoliosPage();
        }

        IntelligentPortfoliosPage IntelligentPortfoliosPage { get; set; }

        public void NavigateToPages(String subMenu, String menu)
        {
            Click(ConvertMenuStringToBy(menu));
            Wait(200);
            Click(ConvertMenuStringToBy(subMenu));
        }

        public void AccessButton(String button)
        {
            switch (button)
            {
                case "Get Started":
                    Click(IntelligentPortfoliosPage.GetStartedButton);
                    Wait(2000);
                    SwitchNewWindow();
                    break;
                case "Take a deeper dive":
                    Click(IntelligentPortfoliosPage.TakeADeeperDive);
                    break;
                case "See how we stack up":
                    Click(IntelligentPortfoliosPage.StackUpButton);
                    break;
                case "Open an account":
                    Click(IntelligentPortfoliosPage.OpenAnAccountButton);
                    Wait(2000);
                    SwitchNewWindow();
                    break;
                case "Find a local branch to apply in person":
                    Click(IntelligentPortfoliosPage.FindBranch);
                    Wait(2000);
                    SwitchNewWindow();
                    break;

                default: 
                    throw new NotFoundException("Not found");
            }
        }


        #region Helper functions
        public By ConvertMenuStringToBy(String item)
        {
            return By.XPath($"//*[@data-dl-link.name='{item}']");
        }
        #endregion
    }
}
