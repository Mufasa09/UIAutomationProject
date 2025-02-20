using FluentAssertions;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.Tests
{
    public class APITests
    {
        public APITests() { }

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
            _StatusCode = response.StatusCode.ToString();
            _StatusCode.Should().Contain(data.StatusCode);
        }

        public void VerifyResponseBody(APIData data)
        {

            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string directoryName = Path.GetFullPath(Path.Combine(path, @$"..\..\..\\Utilities\API\{data.TxtFile}.txt"));

            //Reads in file
            using (StreamReader DataFile = new StreamReader(@directoryName))
            {

                //Read the first line of text
                string line = DataFile.ReadLine();
                if (response == null)
                    throw new Exception("Response is null");
                else
                    _ResponseBody = response.Content.ReadAsStringAsync().Result;
                _ResponseBody.Should().Contain(line); ;
                //close the file
                DataFile.Close();
            }

        }

        #endregion

    }
}
