

namespace UIAutomationProject.Utilities.Data
{
    public class BaseData
    {
        public string UserName { get; set; }
        public string Password { get; set; } = "secret_sauce";
        public string Role { get; set; }
        public string Title { get; set; }
        public string TitleEnding { get; set; }
        public string TitleEnding2 { get; set; } = "";
        public string Item1 { get; set; }
        public static string FeatureName { get; set; }
    }
}
