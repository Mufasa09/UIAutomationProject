﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

/// <summary>
/// Purpose of this class is to designate which browser to run selenium automation
/// </summary>
namespace UIAutomationProject.Helpers
{
    public class WebDriverFactory
    {

        public IWebDriver ChooseDriver(string browser, bool headless)
        {
            switch (browser)
            {
                case "Chrome":
                    ChromeOptions chromeOption = new ChromeOptions();
                    chromeOption.AddArguments("start-maximized");
                    chromeOption.AddArguments("incognito");
                    if (headless)
                         chromeOption.AddArgument("headless");
                    return new ChromeDriver(chromeOption);
                case "Firefox":
                    FirefoxOptions firefoxOption = new FirefoxOptions();
                    firefoxOption.AddArguments("start-maximized");
                    if (headless)
                        firefoxOption.AddArgument("headless");
                    return new FirefoxDriver(firefoxOption);
                case "Edge":
                    var edgeOptions = new EdgeOptions();
                    edgeOptions.AddArgument("start-maximized");
                    if (headless)
                        edgeOptions.AddArgument("headless");
                    return new EdgeDriver(edgeOptions);
                default:
                    throw new NotFoundException("No browser was found");
            }
        }
    }
}
