using Boa.Constrictor.Screenplay;
using OpenQA.Selenium;
using RestSharp;

namespace UIAutomationProject.Helpers
{
    public class User : Actor
    {
        private IWebDriver driver;

        /// <summary>
        /// For calling WebUI
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="_driver"></param>
        public User(String userName, IWebDriver _driver)
        {
            driver = _driver;
            IActor actor = new Actor(name: userName, logger: new ConsoleLogger());
            actor.Can(BrowseTheWeb.With(driver));
        }

        /// <summary>
        /// For calling API 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="Url"></param>
        public User(String userName, String Url = "")
        {
            IActor actor = new Actor(name: userName, logger: new ConsoleLogger());
            actor.Can(CallRestApi.Using(new RestClient(Url)));
        }

    }
}
