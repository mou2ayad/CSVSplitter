using System;
using System.IO;

namespace CSVSplitter.Logging
{
    public static class Logger
    {
        // reading the log folder path from app.config
        public static readonly string ErrorsFolderPath = AppConfiguration.AppSettings.GetErrorsLogspath();

        /// <summary>
        /// Log the exceptions in log Files (new file daily)
        /// </summary>
        /// <param name="exception"></param>
        public static void LogException(Exception exception)
        {
            if (!Directory.Exists(ErrorsFolderPath))
                Directory.CreateDirectory(ErrorsFolderPath);
            string logPath = string.Format("{1}/{0}.txt",DateTime.Today.ToString("yyyy-MM-dd"), ErrorsFolderPath);

            using (StreamWriter logWriter = new StreamWriter(logPath, true))
            {
                logWriter.WriteLine("Date :" + DateTime.Now.ToString() +"\nError Message :" + exception.Message + "\n" + Environment.NewLine + "StackTrace :" + exception.StackTrace);
                logWriter.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
            }
        }
        // extension method to facilitate logging the exceptions 
        public static void Log(this Exception exception)
        {
            LogException(exception);
        }
    }
}
