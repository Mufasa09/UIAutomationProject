using OpenQA.Selenium;
using UIAutomationProject.Pages.CharlesSchwab;

namespace UIAutomationProject.Tests.CharlesSchwabTests
{
    public class IntelligentPortfolioTests : BaseTests
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
