using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.IO;
using TechTalk.SpecFlow;

/// <summary>
/// Purpose of this class is to create screenshots during and after scenarios
/// </summary>
namespace UIAutomationProject.Support
{
    [Binding]
    public class Screenshots
    {
        private readonly IWebDriver driver;
        private static string? Date;
        private String testName;
        private string featureName;
        private string stepName;
        private ScenarioContext scenarioContext;
        private FeatureContext featureContext;
        public Screenshots(IWebDriver _driver, ScenarioContext _scenarioContext, FeatureContext _featureContext)
        {
            driver = _driver;
            scenarioContext = _scenarioContext;
            featureContext = _featureContext;
        }



        [AfterStep]
        public void MakeScreenshotAfterStep()
        {
            if (driver is not ITakesScreenshot takesScreenshot)
            {
                return;
            }
            Date = DateTime.Now.ToString("MMddyyyy");

            testName = scenarioContext.ScenarioInfo.Title;
            testName = testName.Substring(0, Math.Min(testName.Length, 30));
            featureName = featureContext.FeatureInfo.Title;
            stepName = scenarioContext.StepContext.StepInfo.Text;
            stepName = testName.Substring(0, Math.Min(testName.Length, 30));
            Directory.CreateDirectory(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @$"..\..\..\\Screenshots\{Date}\{featureName}\{testName}")));
            var screenshot = takesScreenshot.GetScreenshot();
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Path.GetTempFileName());
            string fileName = $"{stepName}.png";
            //string fileName = $"{fileNameWithoutExtension}.png";
            string directoryName = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @$"..\..\..\\Screenshots\{Date}\{featureName}\{testName}"));
            string tempFileName = Path.Combine(directoryName, fileName);
            screenshot.SaveAsFile(tempFileName);

            Console.WriteLine($"SCREENSHOT[ file:///{tempFileName} ]SCREENSHOT");
        }
    }
}
