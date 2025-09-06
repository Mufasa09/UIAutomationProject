using Boa.Constrictor.RestSharp;
using Boa.Constrictor.Screenplay;
using OpenQA.Selenium;
using RestSharp;

namespace UIAutomationProject.Helpers
{
    internal class CallRestApi : AbstractRestSharpAbility
    {

        private CallRestApi(RestClient restClient) : base(restClient) { }
        private CallRestApi(string baseUrl) : base(baseUrl) { }

        public static CallRestApi At(string baseUrl) =>
            new CallRestApi(baseUrl);

        public static CallRestApi Using(RestClient restClient) =>
            new CallRestApi(restClient);
    }
}
