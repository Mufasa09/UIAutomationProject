using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

/// <summary>
/// Purpose of this class is to designate which browser to run selenium automation
/// </summary>
namespace UIAutomationProject.Helpers
{
    public class WebDriverFactory
    {

        public IWebDriver ChooseDriver(string browser, bool headless, bool useRemote)
        {
            switch (browser)
            {
                case "Chrome":
                    ChromeOptions chromeOption = new ChromeOptions();
                    chromeOption.AddArguments("start-maximized");
                    chromeOption.AddArguments("incognito");
                    chromeOption.AddArguments("--no-sandbox", "--disable-dev-shm-usage");
                    //This creates a temp folder, so that you can chrome in parallel (specifically inside Azure CI/CD)
                    if (!useRemote)
                    {
                        string tempUserDataDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                        Directory.CreateDirectory(tempUserDataDir);
                        Console.WriteLine($"LOG: Using user-data-dir: {tempUserDataDir}");
                        chromeOption.AddArgument($"--user-data-dir={tempUserDataDir}");
                    }
                    if (headless)
                         chromeOption.AddArgument("headless");
                    if (useRemote)
                    {
                        return new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chromeOption.ToCapabilities());
                    }
                    else
                    {
                        return new ChromeDriver(chromeOption);
                    }
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
