

namespace UIAutomationProject.Utilities.Data
{
    public class APIData
    {
        #region Basic API Calls
        public string StatusCode { get; set; }
        public string ResponseBody { get; set; }
        public string RequestBody { get; set; }
        public string TxtFile { get; set; }
        public string APIUrl { get; set; }
        #endregion

        #region Post Body Variables
        public string userID { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        #endregion

    }
}
