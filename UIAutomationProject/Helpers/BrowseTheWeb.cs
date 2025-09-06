using Boa.Constrictor.Screenplay;
using OpenQA.Selenium;

namespace UIAutomationProject.Helpers
{
    public class BrowseTheWeb : IAbility
    {
        public IWebDriver WebDriver { get; }

        private BrowseTheWeb(IWebDriver driver) =>
            WebDriver = driver;

        public static BrowseTheWeb With(IWebDriver driver) =>
            new BrowseTheWeb(driver);
    }
}
