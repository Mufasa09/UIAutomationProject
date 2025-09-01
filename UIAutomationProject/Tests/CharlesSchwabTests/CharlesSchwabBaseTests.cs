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

        public void AccessGetStartedButton()
        {
            Click(IntelligentPortfoliosPage.GetStartedButton);
            Wait(2000);
            SwitchNewWindow();
        }


        #region Helper functions
        public By ConvertMenuStringToBy(String item)
        {
            return By.XPath($"//*[@data-dl-link.name='{item}']");
        }
        #endregion
    }
}
