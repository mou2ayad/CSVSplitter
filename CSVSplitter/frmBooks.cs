using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using CSVSplitter.DataAccessLayer;

using CSVSplitter.Logging;

namespace CSVSplitter
{

    public partial class frmBooks : Form
    {
        private const string defaultFilename = "File: ";
        SortedDictionary<float,List<DataGridViewCell>> pricecells;
        string filename;
        private delegate object SafeCallDelegate();
        private delegate void SafeCallDelegateVoid();
        private int uploadmodel;

        public frmBooks()
        {
            InitializeComponent();
            clBinding.DataSource = BindingTypes.GetBindingTypes();
            pricecells = new SortedDictionary<float, List<DataGridViewCell>>();
            
        }
        #region Controls Events
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.DataError += DgvBooks_DataError;
        }

        private void DgvBooks_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Exception.Log();
            e.ThrowException = false;
            e.Cancel = false;
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            if (((Control)sender).Name == btnUploadBinding.Name)
                uploadmodel = 1;
            else
                uploadmodel = 0;

            fdCSVFileDialog.ShowDialog();
        }
        private void fdCSVFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            clearGrid();
            txFileName.Text = defaultFilename + fdCSVFileDialog.FileName;
            filename = fdCSVFileDialog.FileName;
            if(uploadmodel==0)
            {  
                /// Start a new thread, separate from Windows Forms to load the data
                Thread thread = new Thread(new ThreadStart(loadDataAsync));
                thread.Start();
            }
            else
            {
                loadDataSync(); 
            }
        }      

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show((senderGrid.Rows[e.RowIndex].Cells["clDescription"]).Value.ToString(), "Book Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            /// Start a new thread, separate from Windows Forms to remove "not in stock"
            Thread thread = new Thread(new ThreadStart(remove));
            thread.Start();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearGrid();
            updateRowCount();

        }

        #endregion


    }
}
