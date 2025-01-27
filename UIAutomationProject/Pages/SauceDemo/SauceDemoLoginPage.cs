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
        public By LoginPasswordCredentialsText => By.XPath("//div[contains(@class,'login_password')]");
        public By LoginFailureText => By.XPath("//*[contains(@text,'Epic sadface: Sorry, this user has been locked out.')]");
        public By LoginErrorContainer => By.XPath("//h3[contains(@data-test,'error')]");
    }
}
