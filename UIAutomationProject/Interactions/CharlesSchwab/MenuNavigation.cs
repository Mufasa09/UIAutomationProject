using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using UIAutomationProject.Helpers;
using UIAutomationProject.Pages;


namespace UIAutomationProject.Interactions.CharlesSchwab
{
    public class MenuNavigation : ITask
    {
        private string Menu { get; set; }
        private string SubMenu { get; }
        private string Option { get; }
        private bool SecondaryNavigation { get; }
        User User { get; set; }

        public MenuNavigation(string menu, string subMenu) 
        {
            Menu = menu;
            SubMenu = subMenu;
        }

        public MenuNavigation(string menu, string subMenu, bool secondaryNavigation, string option)
        {
            Menu = menu;
            SubMenu = subMenu;
            SecondaryNavigation = secondaryNavigation;
            Option = option;
        }

        public static MenuNavigation To(string menu, string subMenu) => 
            new MenuNavigation(menu, subMenu);

        public static MenuNavigation To(string menu, string subMenu = "", bool secondaryNavigation =  true, string option = "none") =>
            new MenuNavigation(menu, subMenu, secondaryNavigation, option);

        public void PerformAs(IActor actor)
        {
            var driver = actor.Using<Boa.Constrictor.Selenium.BrowseTheWeb>().WebDriver;
            if (SecondaryNavigation)
            {
                User = new User("SecondaryMenuNavigation", driver);
              
                if (SubMenu.Equals(""))
                {
                    switch (Menu)
                    {
                        case "Annuities Overview":
                        case "Schwab Intelligent Income":
                        case "Schwab Intelligent Portfolios Premium":
                        case "Schwab Intelligent Portfolios":
                        case "Calculators & Tools":
                        case "Complimentary Plan":
                        case "How to reach your goals":
                        case "Education and Custodial":
                            MainMenuOption2(actor, driver);
                            break;
                        default:
                            MainMenuOption1(actor, driver);
                            break;
                    }
                }
                else
                {
                    switch (Menu)
                    {
                        case "Income Annuities":
                        case "Indexed Annuities":
                        case "Variable Annuities":
                        case "Compare Solutions":
                        case "Resources":
                        case "529 Savings Plan":
                        case "Custodial Account":
                            MenuOption2(actor, driver);
                            break;
                        case "Active Trading":
                        case "thinkorswim Platforms":
                            MenuOption1(actor, driver);
                            break;
                        default:
                            MenuOption3(actor, driver);
                            break;
                    }
                }
            }
            else
            {
                User = new User("MenuNavigation", driver);
                actor.WaitsUntil(Appearance.Of(ConvertMenuStringToWebLocator(Menu)), IsEqualTo.True());
                driver.FindElement(ConvertMenuStringToBy(Menu)).Click();
                Thread.Sleep(800);
                driver.FindElement(ConvertMenuStringToBy(SubMenu)).Click();
            }
        }

        #region Helper functions

        public void MenuOption1(IActor actor, IWebDriver driver)
        {
            if (Menu != null)
            {
                Menu = Menu.Replace(" ", "");
                Menu = "section_" + Menu;
            }
            actor.WaitsUntil(Appearance.Of(BasePage.Locator("id", Menu)), IsEqualTo.True());
            driver.FindElement(BasePage.CustomXpath("id", Menu)).Click();
            Thread.Sleep(500);
            driver.FindElement(BasePage.CustomExactTextXpath(SubMenu, "span")).Click();
        }

        public void MenuOption2(IActor actor, IWebDriver driver)
        {
            actor.WaitsUntil(Appearance.Of(BasePage.CustomTextLocator(Menu, "span")), IsEqualTo.True());
            driver.FindElement(BasePage.CustomTextXpath(Menu, "span")).Click();
            Thread.Sleep(500);
            driver.FindElement(BasePage.CustomExactTextXpath(SubMenu, "a")).Click();
        }

        public void MenuOption3(IActor actor, IWebDriver driver)
        {
            actor.WaitsUntil(Appearance.Of(BasePage.CustomTextLocator(Menu, "span")), IsEqualTo.True());
            driver.FindElement(BasePage.CustomTextXpath(Menu, "span")).Click();
            Thread.Sleep(500);
            driver.FindElement(BasePage.CustomTextXpath(SubMenu, "span")).Click();
        }

        public void MainMenuOption1(IActor actor, IWebDriver driver)
        {
            actor.WaitsUntil(Appearance.Of(BasePage.CustomTextLocator(Menu, "span")), IsEqualTo.True());
            driver.FindElement(BasePage.CustomTextXpath(Menu, "span")).Click();
            Thread.Sleep(500);
        }

        public void MainMenuOption2(IActor actor, IWebDriver driver)
        {
            actor.WaitsUntil(Appearance.Of(BasePage.CustomTextLocator(Menu, "a")), IsEqualTo.True());
            driver.FindElement(BasePage.CustomTextXpath(Menu, "a")).Click();
            Thread.Sleep(500);
        }

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
                case "Advice Automated Investing":
                    return BasePage.Xpath("//*[@id=\"«Ridlb6»\"]/ul/li[3]/a");
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
