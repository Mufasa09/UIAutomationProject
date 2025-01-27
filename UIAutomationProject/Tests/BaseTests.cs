using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using UIAutomationProject.Pages.SauceDemo;
using UIAutomationProject.Utilities.Data;

namespace UIAutomationProject.Tests
{
    public class BaseTests
    {
        private IWebDriver driver;

        public BaseTests(IWebDriver _driver)
        {
            driver = _driver;
            SauceDemoLoginPage = new SauceDemoLoginPage();
        }

        SauceDemoLoginPage SauceDemoLoginPage { get; set; }

        public void NavigateToSite(string site)
        {
            driver.Navigate().GoToUrl(site);
        }

        public void VerifyTitle(string title)
        {
            Wait(3000);
            driver.Title.Contains(title);
        }

        public void EnterUserCred(BaseData baseData, string userNameTextBox, string passwordTextBox)
        {
            driver.FindElement(By.Id(userNameTextBox)).SendKeys(baseData.UserName);
            driver.FindElement(By.Id(passwordTextBox)).SendKeys(baseData.Password);
        }


        public void VerifyLoginError(BaseData baseData)
        {
            Wait(3000);
            if (driver.FindElements(SauceDemoLoginPage.LoginErrorContainer).Count() > 0)
                if (baseData.Role != null)
                    Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginErrorContainer).Text.Contains("Epic sadface: Sorry, this user has been locked out."));
                else
                    Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginErrorContainer).Text.Contains("Epic sadface: Username is required"));
        }

        public void VerifyLoginPageElements()
        {
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.UserNameTextBox).Displayed);
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.PasswordTextBox).Displayed);
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginButton).Displayed);
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginButton).Enabled);
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginUserCredentialsText).Displayed);
            Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginPasswordCredentialsText).Displayed);
        }

        public void Wait(int number)
        {
            Thread.Sleep(number);

        }
        public void VerifyLoginError()
        {
            Wait(3000);
            if (driver.FindElements(SauceDemoLoginPage.LoginErrorContainer).Count() > 0)
                Assert.IsTrue(driver.FindElement(SauceDemoLoginPage.LoginErrorContainer).Text.Contains("Epic sadface: Sorry, this user has been locked out."));
        }

        //Use of a Tuple function. So that you can return multiple objects
        (string, string) WebsiteUserDataTransfer(string user)
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string directoryName = Path.GetFullPath(Path.Combine(path, @"..\..\..\\Utilities\Users.json"));

            //Reads in file
            using (StreamReader DataFile = new StreamReader(@directoryName))
            {
                    string json = DataFile.ReadToEnd();
                    //Converts JSON code over
                    var JsonList = JsonConvert.DeserializeObject<List<BaseData>>(json);
                    //Initliaze the Random Group Array
                    string[] UserGroup = new string[JsonList.Count];
                    //Loop to cycle through the JSON file to determine if there are the same multiple user roles
                    for (int DataTracker = 0; DataTracker < JsonList.Count; DataTracker++)
                    {
                    user = user.Replace("\"", string.Empty);
                    string role = JsonList[DataTracker].Role.ToString();
                    if (role.Equals(user))
                        {
                        UserGroup[0] = JsonList[DataTracker].UserName.ToString();
                        UserGroup[1] = JsonList[DataTracker].Password.ToString();
                        // we only expect one match on username so break out of the loop
                        break;
                         }
                     }

                SauceDemoLoginPage.AccountUserName = UserGroup[0];
                SauceDemoLoginPage.AccountPassword = UserGroup[1];
                    
                return (SauceDemoLoginPage.AccountUserName, SauceDemoLoginPage.AccountPassword);
                
            }
        }

        public string UserAccountName(string user)
        {
            var Account = WebsiteUserDataTransfer(user);
            return Account.Item1;
        }

        public string UserAccountPassword(string user)
        {
            var Account = WebsiteUserDataTransfer(user);
            return Account.Item2;
        }
    }

}