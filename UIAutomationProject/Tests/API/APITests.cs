using FluentAssertions;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.Tests
{
    public class APITests
    {
        private IAPIStorage _apiStorage;
        public APITests(IAPIStorage apiStorage)
        {
            _apiStorage = apiStorage;
        }

        #region Variables
        private HttpClient httpClient = new HttpClient();
        private HttpResponseMessage? response = null;
        private string? _StatusCode;
        private string? _ResponseBody;

        #endregion

        #region Methods
        public void NavigateToAPISite(string url)
        {
            response = httpClient.GetAsync(url).Result;
          
        }

        public void VerifySuccessMessage(APIData data)
        {
            _StatusCode = _apiStorage.response.StatusCode.ToString();
            _StatusCode.Should().Contain(data.StatusCode);
        }

        public void VerifyResponseBody(APIData data)
        {
            string baseDir = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName;
            string directoryName = Path.GetFullPath(Path.Combine(baseDir, $"Utilities\\API\\{data.TxtFile}.txt"));


            //Reads in file
            using (StreamReader DataFile = new StreamReader(@directoryName))
            {

                //Read the first line of text
                //string line = DataFile.ReadLine();
      

                if (_apiStorage.response == null)
                    throw new Exception("Response is null");
                else
                    _ResponseBody = _apiStorage.response.Content.ReadAsStringAsync().Result;
                string readText = File.ReadAllText(directoryName);
                //foreach (string line in readText)
                    _ResponseBody.Should().Contain(readText); 
                //close the file
                DataFile.Close();
            }
        }

        public void VerifyPostData(APIData data)
        {
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["userId"] = data.userID;
                values["id"] = data.id;
                values["title"] = data.title;
                values["body"] = data.body;


                var response = client.UploadValues(data.APIUrl, values);

                var responseString = Encoding.Default.GetString(response);

                Console.WriteLine(responseString);
            }
        }

        #endregion

    }
}
