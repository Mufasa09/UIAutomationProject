using BoDi;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Reflection;
using TechTalk.SpecFlow;
using UIAutomationProject.Utilities.API;

namespace UIAutomationProject.Helpers
{
    [Binding]
    public class Hooks
    {
        protected IWebDriver Driver { get; private set; }
        public IAPIStorage _APIStorage { get; set; }
        private readonly IObjectContainer _objectContainer;
        public string baseUrl = "";
        private FeatureContext featureContext;
        private string featureName = "";
        string browser = "Chrome";
        string returnString;
        bool useRemote, headless = false;
        public HttpClient _httpClient;
        public IConfiguration Configuration { get; }

        public Hooks(ObjectContainer objectContainer, FeatureContext _featureContext)
        {
            _objectContainer = objectContainer;
            featureContext = _featureContext;
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string baseDir = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName;
            string directoryName = Path.Combine(baseDir, "Utilities");

            //Directory.SetCurrentDirectory(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @$"..\..\..\\Utilities\")));

            Configuration = new ConfigurationBuilder()
            .SetBasePath(directoryName)
            .AddJsonFile("testsettings.json", optional: true)
            .AddJsonFile($"testsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
            .AddEnvironmentVariables()
            .Build();
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
             headless = Configuration.GetValue<bool>("Headless");
             browser = Configuration.GetValue<string>("Browser");
            useRemote = Configuration.GetValue<bool>("Remote");

            featureName = featureContext.FeatureInfo.Title;

            baseUrl = Configuration.GetValue<string>(WebsiteSelector(featureName) + "Url");
            if (featureName.Contains("API"))
                headless = true;

            _APIStorage = new APIStorage
            {
                BaseUrl = baseUrl
            };
            _APIStorage.response = _APIStorage.GetResponse(baseUrl);
            DriverFactory.setDriver(new WebDriverFactory().ChooseDriver(browser, headless, useRemote));
            Driver = DriverFactory.getWebDriver();
            Console.WriteLine($"LOG:[Thread {Thread.CurrentThread.ManagedThreadId}] Launching browser...");

            //// Use reflection to get the "service" field
            //var serviceField = typeof(ChromeDriver)
            //    .GetField("service", BindingFlags.NonPublic | BindingFlags.Instance);
            //var service = serviceField.GetValue(Driver);

            //// Get process via reflection
            //var processField = service.GetType().GetField("process", BindingFlags.NonPublic | BindingFlags.Instance);
            //var process = (Process)processField.GetValue(service);

            //Console.WriteLine($"ChromeDriver PID: {process.Id}");
            _objectContainer.RegisterInstanceAs(Driver);
            _objectContainer.RegisterInstanceAs(_APIStorage);
            _objectContainer.RegisterInstanceAs(Configuration);
            Driver.Manage().Window.Maximize();
            if (featureName.Contains("API"))
            {
                _APIStorage.GetResponse(baseUrl);
            }
            else
                Driver.Navigate().GoToUrl(baseUrl);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverFactory.removeDriver();
        }

        public string WebsiteSelector(string featureName)
        {
            switch (featureName)
            {
                case string a when a.Contains("SauceDemo"):
                    returnString = "SauceDemo";
                    return returnString;
                case string a when a.Contains("UltimateQA"):
                    returnString = "UltimateQA";
                    return returnString;
                case string a when a.Contains("APIDog"):
                    returnString = "APIDog";
                    return returnString;
                case string a when a.Contains("Charles Schwab"):
                    returnString = "CharlesSchwab";
                    return returnString;
                default:
                    throw new NotFoundException();
            }

        }

    }
}