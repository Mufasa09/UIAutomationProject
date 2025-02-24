

namespace UIAutomationProject.Utilities.API
{
    public class APIStorage : IAPIStorage
    {
        public APIStorage() 
        {
            httpClient = new HttpClient();
        }

        public string BaseUrl { get; set; }
        public HttpClient httpClient { get; set; }
        public HttpResponseMessage response { get; set; }

        public HttpResponseMessage GetResponse(string baseURL)
        {
            response = httpClient.GetAsync(baseURL).Result;
            return response;
        }
    }
}
