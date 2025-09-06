using OpenQA.Selenium;
using Boa.Constrictor.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;

namespace UIAutomationProject.Pages
{
    public class BasePage
    {

        public BasePage() {}


        public static By CustomXpath(String identifier, String name, String type = "*")
        {
            return By.XPath($"//{type}[contains(@{identifier},'{name}')]");
        }

        public static By CustomExactXpath(String identifier, String name, String type = "*")
        {
            return By.XPath($"//{type}[contains(@{identifier}='{name}')]");
        }

        public static WebLocator Locator(String locator, String name, String type = "*")
        {
            return L("", By.XPath($"//{type}[contains(@{locator},'{name}')]"));
        }

        public static WebLocator ButtonLocator(String locator, String name)
        {
            return L("", By.XPath($"//button[contains({locator},'{name}')]"));
        }

        public static WebLocator ExactLocator(String locator, String name, String type = "*")
        {
            return L("", By.XPath($"//{type}[@{locator}='{name}']"));
        }
    }
}
