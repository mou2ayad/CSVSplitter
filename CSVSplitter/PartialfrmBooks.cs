using CSVSplitter.AppConfiguration;
using CSVSplitter.CSVParser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVSplitter
{
    public partial class frmBooks : Form
    {
        #region Private Methods

        /// <summary>
        /// clear the Grid and delete all rows
        /// </summary>
        private void clearGrid()
        {
            if (dgvBooks.DataSource != null)
                dgvBooks.DataSource = null;

            dgvBooks.Rows.Clear();
            pricecells.Clear();
        }

        /// <summary>
        /// To add new empty row to the grid view and return row id
        /// </summary>
        /// <returns></returns>
        private object CreateRow()
        {
            if (dgvBooks.InvokeRequired)
            {
                var del = new SafeCallDelegate(CreateRow);
                return dgvBooks.Invoke(del);
            }
            return dgvBooks.Rows.Add();

        }
        /// <summary>
        /// To update the number of grid view rows in "Rows count" lable in statusStrip
        /// </summary>
        private void updateRowCount()
        {
            if (statusStrip1.InvokeRequired)
            {
                var del = new SafeCallDelegateVoid(updateRowCount);
                statusStrip1.Invoke(del);
            }
            else
            {
                statusStrip1.Items[1].Text = string.Format("Rows Count:{0}", dgvBooks.Rows.Count);
            }
        }

        /// <summary>
        /// To enable and disable the browse button while parsing the csv file  
        /// </summary>
        private void EnableDisableBrowse()
        {
            if (btnUploadFile.InvokeRequired)
            {
                var del = new SafeCallDelegateVoid(EnableDisableBrowse);
                btnUploadFile.Invoke(del);
            }
            else
            {
                btnUploadFile.Enabled = !btnUploadFile.Enabled;
            }

        }
        /// <summary>
        /// To enable and disable the browse button while parsing the csv file, and deleting (not in stock) books records  
        /// </summary>
        private void EnableDisableDelete()
        {
            if (btnRemove.InvokeRequired)
            {
                var del = new SafeCallDelegateVoid(EnableDisableDelete);
                btnRemove.Invoke(del);
            }
            else
            {
                btnRemove.Enabled = !btnRemove.Enabled;
            }

        }
        /// <summary>
        /// to convert the price from text to float
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        private float PriceConvert(string price)
        {
            float pricenum;
            if (float.TryParse(price, out pricenum))
            {
                return pricenum;
            }
            return -1;
        }
        private void loadDataSync()
        {
            var lines = File.ReadAllLines(filename);
            DataTable datatable = CSVFileParser.ParseFullCSV(lines, AppSettings.GetSeparator());
            dgvBooks.DataSource = datatable;

            //for(int i=0;i<datatable.Columns.Count; i++)
            //{
            //    datatable.Columns[i].ColumnName = string.Format("cl{0}", datatable.Columns[i].ColumnName.Replace(" ", ""));
            //}

            for (int i = 0; i < dgvBooks.Rows.Count; i++)
            {
                addToPricesDictinary(dgvBooks.Rows[i].Cells["clPrice"]);
                highlightingNotInStock(dgvBooks.Rows[i]);
            }
            updateRowCount();
            addPriceColors();
        }
        /// <summary>
        /// to call CSV Parser to parse the file and fill the grid view
        /// </summary>
        private void loadDataAsync()
        {
            EnableDisableBrowse();
            EnableDisableDelete();
            using (StreamReader stream = new StreamReader(filename))
            {
                CSVLineCoordinator cSVLineCoordinator = null;
                string line = stream.ReadLine();
                if (string.IsNullOrEmpty(line))
                    return;

                cSVLineCoordinator = new CSVLineCoordinator(line, AppSettings.GetSeparator());

                line = stream.ReadLine();
                CSVLineParser parse = new CSVLineParser(cSVLineCoordinator);

                while (!string.IsNullOrEmpty(line))
                {
                    var values = parse.ParseCSVLine(line);
                    int rowid = (int)CreateRow();
                    var row = dgvBooks.Rows[rowid];
                    row.Cells["clTitle"].Value = values["Title"];
                    row.Cells["clAuthor"].Value = values["Author"];
                    row.Cells["clYear"].Value = values["Year"];
                    row.Cells["clPrice"].Value = values["Price"];

                    #region price ordering preparation
                    addToPricesDictinary(row.Cells["clPrice"]);
                    #endregion

                    row.Cells["clDescription"].Value = values["Description"];
                    row.Cells["clBinding"].Value = values["Binding"];
                    row.Cells["clInStock"].Value = inStockMapping(values["In Stock"]);

                    // highlighting "not in stock rows"
                    highlightingNotInStock(row);

                    // updating the rows count after adding each row
                    updateRowCount();

                    line = stream.ReadLine();

                }
                //calling: decorating the prices(color gradient from highest to lowest price))
                addPriceColors();
            }
            EnableDisableBrowse();
            EnableDisableDelete();
        }
        /// <summary>
        /// To remove (no in stock) books records
        /// </summary>
        public void remove()
        {
            EnableDisableBrowse();
            EnableDisableDelete();
            if (dgvBooks.InvokeRequired)
            {
                var del = new SafeCallDelegateVoid(remove);
                dgvBooks.Invoke(del);
            }
            else
            {
                int orgCount = dgvBooks.Rows.Count;
                for (int i = 0; i < dgvBooks.Rows.Count; i++)
                {
                    if (!(bool)inStockMapping(dgvBooks.Rows[i].Cells["clInStock"].Value.ToString()))
                    {
                        dgvBooks.Rows.RemoveAt(i);
                        updateRowCount();
                        i--;
                    }
                }
                MessageBox.Show(string.Format("{0} records have been deleted", orgCount - dgvBooks.Rows.Count), "Done..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            EnableDisableBrowse();
            EnableDisableDelete();

        }
        /// <summary>
        /// to return true if the book is in stock (in case the text in csv is yes) otherwise returning "false"
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool inStockMapping(string str)
        {
            if (str.ToLower() == "yes" || str.ToLower() == "true")
                return true;
            return false;

        }

        /// <summary>
        ///  decorating the prices(color gradient from highest to lowest price))
        /// </summary>
        private void addPriceColors()
        {
            int rMax = Color.Chocolate.R;
            int rMin = Color.Black.R;

            int size = pricecells.Count;
            int i = pricecells.Count;

            foreach (var Price in pricecells)
            {
                var rAvg = rMin + (int)((rMax - rMin) * i / size);
                foreach (var cell in Price.Value)
                {
                    cell.Style.ForeColor = Color.FromArgb(rAvg, rAvg, rAvg);
                }
                i--;
            }
        }
        private void addToPricesDictinary(DataGridViewCell cell)
        {
            float price = PriceConvert(cell.Value.ToString());
            if (pricecells.ContainsKey(price))
                pricecells[price].Add(cell);
            else
                pricecells.Add(price, new List<DataGridViewCell>() { cell });
        }
        private void highlightingNotInStock(DataGridViewRow row)
        {
            if (!inStockMapping(row.Cells["clInStock"].Value.ToString()))
                row.DefaultCellStyle.BackColor = Color.Lavender;
        }
        #endregion

    }
}
