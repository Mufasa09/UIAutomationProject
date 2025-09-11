using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using NUnit.Framework;

namespace UIAutomationProject.Questions
{
    public class TextVerification : IQuestion<bool>
    {
        private WebLocator Locator { get; }
        private bool BoolData { get; }
        private string Data { get; }

        public TextVerification(WebLocator locator, bool boolData, string data) 
        {
            Locator = locator;
            BoolData = boolData;
            Data = data;
        }

        public static TextVerification Of(WebLocator locator, bool boolData, string Data) =>
            new TextVerification(locator, boolData, Data);
        public bool RequestAs(IActor actor)
        {
            var driver = actor.Using<BrowseTheWeb>().WebDriver;
            return driver.FindElement(Locator.Query).Text.Contains(Data);
        }
    }
}
