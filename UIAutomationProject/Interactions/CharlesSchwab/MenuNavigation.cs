using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using UIAutomationProject.Helpers;
using UIAutomationProject.Pages;


namespace UIAutomationProject.Interactions.CharlesSchwab
{
    public class MenuNavigation : ITask
    {
        private string Menu { get; }
        private string SubMenu { get; }
        User User { get; set; }

        public MenuNavigation(string menu, string subMenu) 
        {
            Menu = menu;
            SubMenu = subMenu;
        }

        public static MenuNavigation To(string menu, string subMenu) => 
            new MenuNavigation(menu, subMenu);

        public void PerformAs(IActor actor)
        {
            var driver = actor.Using<Boa.Constrictor.Selenium.BrowseTheWeb>().WebDriver;
            User = new User("MenuNavigation", driver);
            actor.WaitsUntil(Appearance.Of(ConvertMenuStringToWebLocator(Menu)), IsEqualTo.True());
            driver.FindElement(ConvertMenuStringToBy(Menu)).Click();
            actor.WaitsUntil(Appearance.Of(ConvertMenuStringToWebLocator(SubMenu)), IsEqualTo.True());
            driver.FindElement(ConvertMenuStringToBy(SubMenu)).Click();
            //User.AttemptsTo(Click.On(ConvertMenuStringToWebLocator(Menu)));
            //User.AttemptsTo(Click.On(ConvertMenuStringToWebLocator(SubMenu)));
        }

        #region Helper functions
        public By ConvertMenuStringToBy(string item)
        {
            return BasePage.CustomExactXpath("data-dl-link.name", item);
        }

        public static WebLocator ConvertMenuStringToWebLocator(string item)
        {
            return BasePage.ExactLocator("data-dl-link.name", item);
        }
        #endregion
    }
}
