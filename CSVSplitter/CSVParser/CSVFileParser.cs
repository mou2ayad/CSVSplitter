using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace CSVSplitter.CSVParser
{
    public class CSVFileParser
    {
        public static DataTable ParseFullCSV(IEnumerable<string> csvlines, char separator)
        {
            var lines = csvlines.ToArray();
            CSVLineCoordinator cSVLineCoordinator = null;
            DataTable dataTable = new DataTable();
            if (lines == null && lines.Length == 0)
                return dataTable;
            cSVLineCoordinator = new CSVLineCoordinator(lines[0], separator);
            dataTable.Columns.AddRange(cSVLineCoordinator.headers.Select(e => new DataColumn(e.Key)).ToArray());
            CSVLineParser cSVLineParser = new CSVLineParser(cSVLineCoordinator);
            for (int i = 1; i < lines.Length; i++)
            {
                var linedata = cSVLineParser.ParseCSVLine(lines[i]);
                var dr = dataTable.NewRow();
                foreach (var ln in linedata)
                    dr[ln.Key] = ln.Value;
                dataTable.Rows.Add(dr);
            }
            return dataTable;
        }
    }
}
