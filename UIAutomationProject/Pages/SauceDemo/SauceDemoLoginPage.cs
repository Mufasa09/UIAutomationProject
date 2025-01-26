using OpenQA.Selenium;

namespace UIAutomationProject.Pages.SauceDemo
{
    public class SauceDemoLoginPage
    {
        public string title = "Swag Labs";
        public By UserNameTextBox => By.Id("user-name");
        public By PasswordTextBox => By.Id("password");
        public By LoginButton => By.Id("login-button");
        public By LoginUserCredentialsText => By.Id("login_credentials");
        public By LoginPasswordCredentialsText => By.Id("login_password");
    }
}
