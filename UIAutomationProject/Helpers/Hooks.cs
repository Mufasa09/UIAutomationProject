using BoDi;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
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
        private string baseUrl = "";
        private FeatureContext featureContext;
        private string featureName = "";
        public HttpClient _httpClient;
        public IConfiguration Configuration { get; }

        public Hooks(ObjectContainer objectContainer, FeatureContext _featureContext)
        {
            _objectContainer = objectContainer;
            featureContext = _featureContext;
 

            Directory.SetCurrentDirectory(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @$"..\..\..\\Utilities\")));

            Configuration = new ConfigurationBuilder()
            .SetBasePath(Environment.CurrentDirectory)
            .AddJsonFile("testsettings.json", optional: true)
            .AddJsonFile($"testsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
            .AddEnvironmentVariables()
            .Build();
            bool headless = Configuration.GetValue<bool>("Headless");

            featureName = featureContext.FeatureInfo.Title;

            baseUrl = Configuration.GetValue<string>(WebsiteSelector(featureName) + "Url");
            if (featureName.Contains("API"))
                headless = true;

            _APIStorage = new APIStorage();
            _APIStorage.BaseUrl = baseUrl;
            _APIStorage.response = _APIStorage.GetResponse(baseUrl);
            Driver = new WebDriverFactory().ChooseDriver(WebDriverFactory.BrowserType.Chrome, headless);
            _objectContainer.RegisterInstanceAs(Driver);
            _objectContainer.RegisterInstanceAs(_APIStorage);
            _objectContainer.RegisterInstanceAs(Configuration);
        }


        [BeforeScenario]
        public void BeforeScenario()
        {

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
            Driver.Quit();
        }

        public string WebsiteSelector(string featureName)
        {
            string returnString = "";
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
                default:
                    throw new NotFoundException();
            }

        }

    }
}