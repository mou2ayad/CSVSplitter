using CSVSplitter.Logging;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CSVSplitter.ErrorHandling
{
    public class ErrorHandlers
    {

        /// <summary>
        /// Handle the UI exceptions by showing a dialog box and log exception in txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public static void UnhandledErrorHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception exception = (Exception)args.ExceptionObject;
            exception.Log();
            MessageBox.Show(exception.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    
        /// <summary>
        /// Handle the UI exceptions by showing a dialog box, and asking the user whether
        /// or not they wish to abort execution. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public static void ThreadErrorHandler(object sender, ThreadExceptionEventArgs args)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                Exception exception = args.Exception;
                exception.Log();
                result = MessageBox.Show(exception.Message, "Erro:", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            }
            catch
            {
                try
                {
                    MessageBox.Show("Fatal Error",
                        "Sorry Looks like you are facing a fatal Error, the application will be closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Application.Exit();
                }
            }
            if (result == DialogResult.Abort)
                Application.Exit();
        }
        
    }
}
