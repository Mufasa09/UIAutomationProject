using Boa.Constrictor.Selenium;
using OpenQA.Selenium;

namespace UIAutomationProject.Pages.SauceDemo
{
    public class SauceDemoLoginPage : BasePage
    {
        public string title = "Swag Labs";

        public string AccountUserName = "";
        public string AccountPassword = "";
        public int RandomIndex = 0;
        public WebLocator UserNameTextBox => Locator("id","user-name");
        public WebLocator PasswordTextBox => Locator("id","password");
        public WebLocator LoginButton => Locator("id","login-button");
        public WebLocator LoginUserCredentialsText => Locator("id","login_credentials");
        public WebLocator LoginPasswordCredentialsText => Locator("class", "login_password", "div");
        public WebLocator LoginFailureText => Locator("text", "Epic sadface: Sorry, this user has been locked out.");
        public WebLocator LoginErrorContainer => Locator("data-test", "error", "h3");
    }
}
