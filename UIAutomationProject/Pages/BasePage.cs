using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomationProject.Pages
{
    public class BasePage
    {

        public BasePage() {}


        public By CustomXpath(String identifier, String name, String type = "*")
        {
            return By.XPath($"//{type}[contains(@{identifier},{name})]");
        }
    }
}
