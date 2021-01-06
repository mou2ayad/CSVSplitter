
using System.Configuration;


namespace CSVSplitter.AppConfiguration
{
    public static class AppSettings
    {
        public static char GetSeparator()
        {
            return ConfigurationManager.AppSettings["CSVSeparator"].ToCharArray()[0];
        }
        public static string GetErrorsLogspath()
        {
            return ConfigurationManager.AppSettings["ErrorsFolderPath"];
        }
    }
}
