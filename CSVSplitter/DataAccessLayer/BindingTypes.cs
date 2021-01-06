using System;
namespace CSVSplitter.DataAccessLayer
{
    public class BindingTypes
    {
        /// <summary>
        /// To get binding types (from db, staic, file, API .... etc)
        /// </summary>
        /// <returns></returns>
        public static string[] GetBindingTypes()
        {
            string[] array = new string[] { "Coalwood", "Hardcover", "Paperback", "Unknown" };
            return array;

        }
    }
}
