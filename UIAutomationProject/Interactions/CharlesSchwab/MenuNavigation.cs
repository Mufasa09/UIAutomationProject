using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UIAutomationProject.Helpers;
using UIAutomationProject.Pages;
using UIAutomationProject.Utilities.Data;


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
                        case "Fixed Income Overview":
                        case "Checking Overview":
                        case "Education and Custodial":
                        case "Home Loans & Rates Overview":
                        case "Trading Overview":
                        case "Options Overview":
                        case "Schwab Coaching Overview":
                        case "Schwab Wealth Advisory Overview":
                        case "Schwab Intelligent Portfolios":
                        case "Retirement Accounts (IRAs)":
                            MainMenuOption4(actor, driver, "//*[@id=\"«r45»\"]/ul/li[1]/a");
                            break;
                        case "Home Loans & Rates Products":
                        case "Schwab Intelligent Portfolios Premium":
                            MainMenuOption4(actor, driver, "//*[@id=\"«r45»\"]/ul/li[2]/a");
                            break;
                        case "Home Loans & Rates Rates":
                        case "Education":
                        case "Complimentary Plan":
                            MainMenuOption4(actor, driver, "//*[@id=\"«r45»\"]/ul/li[3]/a");
                            break;
                        case "Why Trade Futures Through Us":
                        case "Support":
                            MainMenuOption4(actor, driver, "//*[@id=\"«r45»\"]/ul/li[4]/a");
                            break;
                        case "Trading Platforms Trading Overview":
                            MainMenuOption4(actor, driver, "//*[@id=\"«r46»\"]/ul/li[1]/a");
                            break;
                        case "Trading Platforms Education":
                            MainMenuOption4(actor, driver, "//*[@id=\"«r46»\"]/ul/li[3]/a");
                            break;
                        case "Trading Platforms Support":
                            MainMenuOption4(actor, driver, "//*[@id=\"«r46»\"]/ul/li[4]/a");
                            break;
                        case "Annuities Overview":
                        case "Around the Clock Trading":
                        case "Brokerage and Trading Account":
                        case "Calculators & Tools":
                        case "College Savings Calculator":
                        case "Comprehensive Wealth Management":
                        case "Education Savings Account":
                        case "ETF Overview":
                        case "Experienced Team":
                        case "FAQs":
                        case "Fixed Deferred Annuities":
                        case "Fraud and Security Video Library":
                        case "Get Started":
                        case "How to reach your goals":
                        case "Income Annuity Estimator":
                        case "Invest in a Portfolio Solution":
                        case "Investment Research":
                        case "Mutual Funds Overview":
                        case "Order Routing Process":
                        case "Other IRAs":
                        case "Our commitment to your security":
                        case "Overview":
                        case "Personalized Approach":
                        case "Price Improvement":
                        case "Pricing":
                        case "Products":
                        case "Protecting senior investors":
                        case "Rates":
                        case "Research Tools":
                        case "Resources to keep you safe online":
                        case "Rollover IRA":
                        case "Sample Scenarios":
                        case "Schwab Bank Debit Card":
                        case "Schwab Intelligent Income":
                        case "Schwab IRA Calculators":
                        case "Schwab Order Execution Advantage":
                        case "Schwab Security Guarantee":
                        case "Selecting ETFs":
                        case "Selecting Fixed Income":
                        case "Select List":
                        case "Send Money with Zelle":
                        case "Start Your Loan":
                        case "Stocks Overview":
                        case "Types of Brokerage Accounts":
                        case "What is a Brokerage Account":
                        case "Why Trade Options at Schwab":
                        case "In-person Events":
                        case "On-demand Webcasts":
                        case "Live webcasts & virtual workshops":
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
                        case "International Stocks":
                        case "Why Trade Stocks at Schwab":
                        case "Understanding Stocks":
                        case "Traditional IRA":
                        case "Roth IRA":
                        case "Schwab Trading Activity Index":
                        case "Introduction to Options":
                        case "Find Mutual Funds":
                        case "Understanding Mutual Funds":
                        case "Types of Mutual Funds":
                        case "Types of ETFs":
                        case "Understanding ETFs":
                        case "ETFs at Schwab":
                        case "Fixed Income Products":
                            MenuOption2(actor, driver);
                            break;
                        case "Active Trading":
                        case "thinkorswim Platforms":
                            if(BaseData.FeatureName.Contains("Active Trading")
                                || BaseData.FeatureName.Contains("Education")
                                || BaseData.FeatureName.Contains("Trading Platform")
                                || BaseData.FeatureName.Contains("Schwab Trading Powered by Ameritrade")
                                || BaseData.FeatureName.Contains("Support"))
                            {
                                MenuOption2(actor, driver);
                            }
                            else
                            {
                                MenuOption1(actor, driver);
                            }
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
            switch(SubMenu)
            {
                case "thinkorswim Overview":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r47»\"]/ul/li[1]/a")).Click();
                    break;
                case "Mutual Funds Overview":
                case "Custodial Account Overview":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r4a»\"]/ul/li[1]/a")).Click();
                    break;
                case "Resources Education":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r4a»\"]/ul/li[3]/a")).Click();
                    break;
                case "Environmental, Social and Governance (ESG) ETFs":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r4a»\"]/ul/li[6]/a")).Click();
                    break;
                case "Commodity ETFs":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r4a»\"]/ul/li[8]/a")).Click();
                    break;
                case "529 Savings Plan Overview":
                case "Trading Platform thinkorswim Overview":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r48»\"]/ul/li[1]/a")).Click();
                    break;
                case "Withdrawal Rules":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r48»\"]/ul/li[3]/a")).Click();
                    break;
                case "Contribution Limits":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r48»\"]/ul/li[4]/a")).Click();
                    break;
                case "Order Execution":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r49»\"]/ul/li[2]/a")).Click();
                    break;
                case "Roth IRA Contribution Limits":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r48»\"]/ul/li[4]/a")).Click();
                    break;
                case "Traditional IRA Contribution Limits":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r47»\"]/ul/li[3]/a")).Click();
                    break;
                case "Roth IRA Withdrawal Rules":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r48»\"]/ul/li[3]/a")).Click();
                    break;
                case "Traditional IRA Withdrawal Rules":
                    driver.FindElement(BasePage.Xpath("//*[@id=\"«r47»\"]/ul/li[2]/a")).Click();
                    break;
                default:
                    driver.FindElement(BasePage.CustomTextXpath(SubMenu, "a")).Click();
                    break;
            }
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

        public void MainMenuOption4(IActor actor, IWebDriver driver, string path)
        {
            actor.WaitsUntil(Appearance.Of(BasePage.LocatorXpath(path)), IsEqualTo.True());
            driver.FindElement(BasePage.Xpath(path)).Click();
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
                case "Investment Products Stocks":
                    return BasePage.Xpath("//*[@id=\"«Rhdlb6H2»\"]/ul/li[3]/a");
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
