using OpenQA.Selenium;
using UIAutomationProject.Pages.CharlesSchwab;

namespace UIAutomationProject.Tests.CharlesSchwabTests
{
    public class IntelligentPortfolioTests : CharlesSchwabBaseTests
    {
        private IWebDriver driver;

        public IntelligentPortfolioTests(IWebDriver _driver) : base(_driver)
        {
            driver = _driver;
            IntelligentPortfoliosPage = new IntelligentPortfoliosPage();
        }

        public IntelligentPortfoliosPage IntelligentPortfoliosPage;

        public void test()
        {

        }
    }
}
