using OpenQA.Selenium;


namespace UIAutomationProject.Helpers
{
    public static class DriverFactory
    {
        public static ThreadLocal<IWebDriver> _driver = new();

        public static IWebDriver getWebDriver()
        {
            return _driver.Value;
        }
        
        public static void setDriver(IWebDriver driverInstance)
        {
            _driver.Value = driverInstance;
        }
        public static void removeDriver()
        {
            IWebDriver driverInstance = _driver.Value;
            if (driverInstance != null)
            {
                driverInstance.Quit();
                driverInstance.Dispose();
                driverInstance = null;
            }
        }
    }
}
