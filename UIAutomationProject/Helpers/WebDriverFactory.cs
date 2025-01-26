using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomationProject.Helpers
{
    public class WebDriverFactory
    {

        public IWebDriver ChooseDriver(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    ChromeOptions option = new ChromeOptions();
                    option.AddArguments("start-maximized");

                    return new ChromeDriver(option); 
                case BrowserType.Edge:
                case BrowserType.IE:
                case BrowserType.Firefox:
                    return null;

                default:
                    throw new ArgumentOutOfRangeException("No browser was found");
            }
        }
        

        public enum BrowserType
        {
            Chrome,
            Edge,
            IE,
            Firefox
        }
    }
}
