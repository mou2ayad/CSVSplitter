using System.Collections.Generic;

namespace CSVSplitter.CSVParser
{
    public class CSVLineCoordinator
    {
        internal Dictionary<string, int> headers { private set; get; }
        internal char separator { private set; get; }
        /// <summary>
        /// to figure out the order of the columns in the csv file and create a map
        /// </summary>
        /// <param name="firstLine">first line from csv file wihch contains the headers</param>
        /// <param name="separator">the separator</param>
        public CSVLineCoordinator(string firstLine, char separator)
        {
            this.separator = separator;
            headers = new Dictionary<string, int>();
            var splits = firstLine.Split(separator);
            for (int i = 0; i < splits.Length; i++)
            {
                headers.Add(splits[i], i);
            }
        }

    }

   
}
