using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using UIAutomationProject.Helpers;
using UIAutomationProject.Pages;


namespace UIAutomationProject.Interactions.CharlesSchwab
{
    public class MenuNavigation : ITask
    {
        private string Menu { get; }
        private string SubMenu { get; }
        private bool SecondaryNavigation { get; }
        User User { get; set; }

        public MenuNavigation(string menu, string subMenu) 
        {
            Menu = menu;
            SubMenu = subMenu;
        }

        public MenuNavigation(string menu, string subMenu, bool secondaryNavigation)
        {
            Menu = menu;
            SubMenu = subMenu;
            SecondaryNavigation = secondaryNavigation;
        }

        public static MenuNavigation To(string menu, string subMenu) => 
            new MenuNavigation(menu, subMenu);

        public static MenuNavigation To(string menu, string subMenu = "", bool secondaryNavigation =  true) =>
            new MenuNavigation(menu, subMenu, secondaryNavigation);

        public void PerformAs(IActor actor)
        {
            var driver = actor.Using<Boa.Constrictor.Selenium.BrowseTheWeb>().WebDriver;
            if (SecondaryNavigation)
            {
                User = new User("SecondaryMenuNavigation", driver);
                actor.WaitsUntil(Appearance.Of(ConvertMenuStringToWebLocator(Menu)), IsEqualTo.True());
                driver.FindElement(ConvertMenuStringToBy(Menu)).Click();
                Thread.Sleep(500);
                if(!SubMenu.Contains(""))
                    driver.FindElement(ConvertMenuStringToBy(SubMenu)).Click();
            }
            else
            {
                User = new User("MenuNavigation", driver);
                actor.WaitsUntil(Appearance.Of(ConvertMenuStringToWebLocator(Menu)), IsEqualTo.True());
                driver.FindElement(ConvertMenuStringToBy(Menu)).Click();
                Thread.Sleep(500);
                driver.FindElement(ConvertMenuStringToBy(SubMenu)).Click();
            }
        }

        #region Helper functions
        public By ConvertMenuStringToBy(string item)
        {
            switch (item)
            {
                case "More Advice Solutions":
                case "Schwab Wealth Advisory":
                case "Self-Directed Investing":
                case "Schwab Trading Powered by Ameritrade":
                case "Trading Platforms":
                case "Schwab Starter Kit":
                case "Schwab Investing Themes":
                case "Schwab Stock Slices":
                case "Schwab Personalized Indexing":
                    return BasePage.CustomXpath("data-dl-link.name", item);
                case "Advice Solutions Automated Investing":
                    return BasePage.Xpath("//*[@id=\"«Ridlb6»\"]/ul/li[3]/a");
                case "ETFs":
                    return BasePage.Xpath("//*[@id=\"«Rldlb6»\"]/ul/li[3]/a");
                case "Investment ETFs":
                    return BasePage.Xpath("//*[@id=\"«Rhdlb6H2»\"]/ul/li[2]/a");
                case "Futures":
                    return BasePage.Xpath("//*[@id=\"«Rldlb6»\"]/ul/li[9]/a");
                case "Investment Futures":
                    return BasePage.Xpath("//*[@id=\"«Rhdlb6H2»\"]/ul/li[5]/a");
                case "Mutual Funds":
                    return BasePage.Xpath("//*[@id=\"«Rldlb6»\"]/ul/li[4]/a");
                case "Investment Mutual Funds":
                    return BasePage.Xpath("//*[@id=\"«Rhdlb6H2»\"]/ul/li[1]/a");
                case "Options":
                    return BasePage.Xpath("//*[@id=\"«Rldlb6»\"]/ul/li[8]/a");
                case "Investment Options":
                    return BasePage.Xpath("//*[@id=\"«Rhdlb6H2»\"]/ul/li[4]/a");
                case "I&E Overview":
                    return BasePage.Xpath("//*[@id=\"«Rldlb6»\"]/ul/li[1]/a");
                case "Stocks":
                    return BasePage.Xpath("//*[@id=\"«Rldlb6»\"]/ul/li[2]/a");
                case "Investment Stocks":
                    return BasePage.Xpath("//*[@id=\"«Rhdlb6H2»\"]/ul/li[3]/a");
                case "Automated Investing":
                    return BasePage.Xpath("//*[@id=\"«Rkdlb6H1»\"]/ul/li[4]/a");
                case "Trading Overview":
                    return BasePage.Xpath("//*[@id=\"«Rldlb6H1»\"]/ul/li[1]/a");
                case "Market Commentary Overview":
                    return BasePage.Xpath("//*[@id=\"«Rldlb6H2»\"]/ul/li[1]/a");
                default:
                    return BasePage.CustomExactXpath("data-dl-link.name", item);
            }
        }
       
        public static WebLocator ConvertMenuStringToWebLocator(string item)
        {
            switch (item)
            {
                case "More Advice Solutions":
                    return BasePage.Locator("data-dl-link.name", item);
                default:
                    return BasePage.ExactLocator("data-dl-link.name", item);
            }
                
        }
        #endregion
    }
}
