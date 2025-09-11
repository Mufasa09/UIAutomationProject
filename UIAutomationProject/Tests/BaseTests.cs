using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using UIAutomationProject.Pages.SauceDemo;
using UIAutomationProject.Utilities.Data;
using Boa.Constrictor.Screenplay;
using UIAutomationProject.Helpers;
using Boa.Constrictor.Selenium;
using UIAutomationProject.Questions;
using FluentAssertions;

namespace UIAutomationProject.Tests
{
    public class BaseTests
    {
        private IWebDriver driver;

        public BaseTests(IWebDriver _driver)
        {
            driver = _driver;
            SauceDemoLoginPage = new SauceDemoLoginPage();
            User = new User("BaseTest", _driver);
            User.Can(Boa.Constrictor.Selenium.BrowseTheWeb.With(driver));
        }

        #region Variables
        SauceDemoLoginPage SauceDemoLoginPage { get; set; }
        User User { get; set; }
        #endregion

        #region Methods
        public void NavigateToSite(string site)
        {
            User.AttemptsTo(Navigate.ToUrl(site));
            //driver.Navigate().GoToUrl(site);
        }

        public void SwitchNewWindow()
        {
            List<string> windowHandles = GrabWindowHandles();
            //for (int i = 0; i < windowHandles.Count(); i++)
            //{
            //    Console.WriteLine(windowHandles[i]);
            //}
            Thread.Sleep(3000);
            //User.AttemptsTo(Refresh.Browser());
            //User.AttemptsTo(SwitchWindowToLatest.InBrowser());
            User.AttemptsTo(SwitchWindow.To(windowHandles[1]));
            Thread.Sleep(3000);  
            //driver.SwitchTo().Window(windowHandles[1]);
        }


        public void AllWindows()
        {
            List<string> allWindows = GrabWindowHandles();

            foreach (string window in allWindows)
            {
                Console.WriteLine("Window Handle: " + window);
            }
            Console.WriteLine(allWindows.Count);
        }

        public void PageVerification(BaseData baseData)
        {
            if (baseData.Title != null)
            {
                driver.Title.Contains(baseData.Title);
            }
        }

        public List<string> GrabWindowHandles()
        {
            return new List<string>(driver.WindowHandles);
        }

        public void VerifyTitle(string title)
        {
            Wait(2000);
            // Assert.(title, driver.Title);
           // Console.WriteLine(User.AsksFor(Title.OfPage()));
            User.AsksFor(Title.OfPage()).Should().Be(title);
            
        }

        public void VerifyURL(string url)
        {
            Wait(2000);
            User.AsksFor(CurrentUrl.FromBrowser());
          //  Assert.AreEqual(url, driver.Url);
            
        }

        public void EnterUserCred(BaseData baseData, string userNameTextBox, string passwordTextBox)
        {

            Enter(By.Id(userNameTextBox), baseData.UserName);
            Enter(By.Id(passwordTextBox), baseData.Password);
        }


        public void VerifyLoginError(BaseData baseData)
        {
            //if (driver.FindElements(SauceDemoLoginPage.LoginErrorContainer).Count() > 0)
            //    if (baseData.Role != null)
            //        VerifyTextData(SauceDemoLoginPage.LoginErrorContainer, "Epic sadface: Sorry, this user has been locked out.", true);
            //    else
            //        VerifyTextData(SauceDemoLoginPage.LoginErrorContainer, "Epic sadface: Username is required", true);

            if (User.AsksFor(Count.Of(SauceDemoLoginPage.LoginErrorContainer)) > 0)
                if (baseData.Role != null)
                    User.AsksFor(TextVerification.Of(SauceDemoLoginPage.LoginErrorContainer, true, "Epic sadface: Sorry, this user has been locked out."));
                else
                    User.AsksFor(TextVerification.Of(SauceDemoLoginPage.LoginErrorContainer, true, "Epic sadface: Username is required"));

        }

        public void VerifyLoginPageElements()
        {

            Assert.IsTrue(User.AsksFor(Appearance.Of(SauceDemoLoginPage.UserNameTextBox)));
            Assert.IsTrue(User.AsksFor(Appearance.Of(SauceDemoLoginPage.PasswordTextBox)));
            Assert.IsTrue(User.AsksFor(Appearance.Of(SauceDemoLoginPage.LoginButton)));
            Assert.IsTrue(User.AsksFor(EnabledState.Of(SauceDemoLoginPage.LoginButton)));
            Assert.IsTrue(User.AsksFor(Appearance.Of(SauceDemoLoginPage.LoginUserCredentialsText)));
            Assert.IsTrue(User.AsksFor(Appearance.Of(SauceDemoLoginPage.LoginPasswordCredentialsText)));
        }

        public void Wait(int number)
        {
            Thread.Sleep(number);
        }

        #region Main Selenium Functions

        /// <summary>
        /// Enters the text into UI element 
        /// </summary>
        /// <param name="loc">UI Element</param>
        /// <param name="text">Text to send</param>
        public void Enter(By loc, string text)
        {
            driver.FindElement(loc).SendKeys(text);
        }

        /// <summary>
        /// Clicks on the UI Element
        /// </summary>
        /// <param name="loc">UI Element</param>
        //public void Click(By loc)
        //{
        //   driver.FindElement(loc).Click();
        //}

        /// <summary>
        /// Verifies if data is present
        /// </summary>
        /// <param name="loc">UI Element</param>
        /// <param name="data">User data</param>
        /// <param name="boolData">Tests whether it is present</param>
        public void VerifyTextData(By loc, string data, bool boolData)
        {
           // if(boolData)
               // Assert.IsTrue(driver.FindElement(loc).Text.Contains(data));
           // else
               // Assert.IsFalse(driver.FindElement(loc).Text.Contains(data));
        }

        /// <summary>
        /// Verifies if data is present
        /// </summary>
        /// <param name="loc">UI Element</param>
        /// <param name="data">User data</param>
        /// <param name="boolData">Tests whether it is present</param>
        public bool VerifyTextDataBool(By loc, string data, bool boolData)
        {
            if (boolData)
            {
                //Assert.IsTrue(driver.FindElement(loc).Text.Contains(data));
                return true;
            }
            else
            {
                //Assert.IsFalse(driver.FindElement(loc).Text.Contains(data));
                return false;
            }
        }

        /// <summary>
        /// Verifies if current locator is present
        /// </summary>
        /// <param name="loc">UI Element</param>
        /// <param name="boolData">Tests whether it is present</param>
        public void VerifyDataIsPresent(By loc, bool boolData)
        {
           // if (boolData)
               // Assert.IsTrue(driver.FindElement(loc).Displayed);
           // else
               // Assert.IsFalse(driver.FindElement(loc).Displayed);
        }

        /// <summary>
        /// Verifies if current locator is enabled or disbaled
        /// </summary>
        /// <param name="loc">UI Element</param>
        /// <param name="boolData">Tests whether it is present</param>
        public void VerifyDataIsEnabled(By loc, bool boolData)
        {
            //if (boolData)
               // Assert.IsTrue(driver.FindElement(loc).Enabled);
           // else
              //  Assert.IsFalse(driver.FindElement(loc).Enabled);
        }

        public string GrabText(By loc)
        {
            return driver.FindElement(loc).Text;
        }
        
        #endregion
        public void VerifyLoginError()
        {
            if (User.AsksFor(Count.Of(SauceDemoLoginPage.LoginErrorContainer)) > 0)
                    User.AsksFor(TextVerification.Of(SauceDemoLoginPage.LoginErrorContainer, true, "Epic sadface: Sorry, this user has been locked out."));
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
        #endregion
    }

}