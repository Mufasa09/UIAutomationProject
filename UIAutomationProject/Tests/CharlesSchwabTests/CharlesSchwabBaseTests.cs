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


        public By ConvertMenuStringToBy(String item)
        {
            return By.XPath($"//*[contains(@data-dl-link.name,'{item}')]");
        }
    }
}
