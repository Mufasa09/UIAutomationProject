using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UIAutomationProject.Helpers
{
    [Binding]
    public class Hooks
    {
        protected IWebDriver Driver { get; private set; }
        private readonly IObjectContainer _objectContainer;
        private readonly WebDriverFactory _factory;


        public Hooks (ObjectContainer objectContainer, WebDriverFactory factory)
        {
            _objectContainer = objectContainer;
            _factory = factory;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = _factory.ChooseDriver(WebDriverFactory.BrowserType.Edge);
            _objectContainer.RegisterInstanceAs(Driver);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}