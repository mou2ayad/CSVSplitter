using System.Collections.Generic;

namespace CSVSplitter.CSVParser
{
    public class CSVLineParser
    {
        CSVLineCoordinator map;
        public CSVLineParser(CSVLineCoordinator coordinator)
        {
            this.map = coordinator;
        }
        /// <summary>
        ///  parsing non-header line from CSV file based on the header map (CSVLineCoordinator)
        ///  and return dictinary (Header Name, value from line)
        /// </summary>
        /// <param name="line">csv line as string</param>
        /// <returns></returns>
        public IDictionary<string, string> ParseCSVLine(string line)
        {
            var splits = line.Split(map.separator);
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            foreach (var keypair in map.headers)
            {
                pairs.Add(keypair.Key, ValidateValue(splits[keypair.Value]));
            }
            return pairs;
        }

        /// <summary>
        /// to Validate Value coming from csv before passing it to the dictinary
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string ValidateValue(string value)
        {
            string output = value.Trim();
            if (string.IsNullOrEmpty(output))
                return string.Empty;
            return output;
        }

    }
}
