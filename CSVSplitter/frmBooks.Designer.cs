namespace CSVSplitter
{
    partial class frmBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.txRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.clTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInStock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clBinding = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnDescription = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdCSVFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.btnUploadBinding = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvBooks);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Image = global::CSVSplitter.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(456, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 58);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Table";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUploadFile);
            this.groupBox1.Controls.Add(this.btnUploadBinding);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load and Parse..";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txFileName,
            this.txRows});
            this.statusStrip1.Location = new System.Drawing.Point(0, 327);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txFileName
            // 
            this.txFileName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txFileName.Name = "txFileName";
            this.txFileName.Size = new System.Drawing.Size(0, 17);
            // 
            // txRows
            // 
            this.txRows.Margin = new System.Windows.Forms.Padding(100, 3, 0, 2);
            this.txRows.Name = "txRows";
            this.txRows.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToResizeRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTitle,
            this.clAuthor,
            this.clYear,
            this.clPrice,
            this.clInStock,
            this.clBinding,
            this.btnDescription,
            this.clDescription});
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(800, 349);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // clTitle
            // 
            this.clTitle.DataPropertyName = "Title";
            this.clTitle.HeaderText = "Title";
            this.clTitle.Name = "clTitle";
            // 
            // clAuthor
            // 
            this.clAuthor.DataPropertyName = "Author";
            this.clAuthor.HeaderText = "Author";
            this.clAuthor.Name = "clAuthor";
            // 
            // clYear
            // 
            this.clYear.DataPropertyName = "Year";
            this.clYear.HeaderText = "Year";
            this.clYear.Name = "clYear";
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "Price";
            this.clPrice.HeaderText = "Price";
            this.clPrice.Name = "clPrice";
            // 
            // clInStock
            // 
            this.clInStock.DataPropertyName = "In Stock";
            this.clInStock.FalseValue = "no";
            this.clInStock.HeaderText = "In Stock";
            this.clInStock.Name = "clInStock";
            this.clInStock.ReadOnly = true;
            this.clInStock.TrueValue = "yes";
            // 
            // clBinding
            // 
            this.clBinding.DataPropertyName = "Binding";
            this.clBinding.HeaderText = "Binding";
            this.clBinding.Name = "clBinding";
            // 
            // btnDescription
            // 
            this.btnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnDescription.FillWeight = 40F;
            this.btnDescription.HeaderText = "Description";
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDescription.Text = "Info....";
            this.btnDescription.UseColumnTextForButtonValue = true;
            // 
            // clDescription
            // 
            this.clDescription.DataPropertyName = "Description";
            this.clDescription.HeaderText = "";
            this.clDescription.Name = "clDescription";
            this.clDescription.Visible = false;
            // 
            // fdCSVFileDialog
            // 
            this.fdCSVFileDialog.Filter = "CSV files (*.csv)|*.csv";
            this.fdCSVFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fdCSVFileDialog_FileOk);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewButtonColumn1.DataPropertyName = "Description";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewButtonColumn1.FillWeight = 40F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "Description";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Text = "info..";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUploadFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUploadFile.FlatAppearance.BorderSize = 3;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadFile.Image = global::CSVSplitter.Properties.Resources.CSV;
            this.btnUploadFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUploadFile.Location = new System.Drawing.Point(6, 17);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(126, 56);
            this.btnUploadFile.TabIndex = 0;
            this.btnUploadFile.Text = "Parse Async";
            this.btnUploadFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // btnUploadBinding
            // 
            this.btnUploadBinding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUploadBinding.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUploadBinding.FlatAppearance.BorderSize = 3;
            this.btnUploadBinding.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadBinding.Image = global::CSVSplitter.Properties.Resources.CSV;
            this.btnUploadBinding.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUploadBinding.Location = new System.Drawing.Point(138, 17);
            this.btnUploadBinding.Name = "btnUploadBinding";
            this.btnUploadBinding.Size = new System.Drawing.Size(106, 56);
            this.btnUploadBinding.TabIndex = 2;
            this.btnUploadBinding.Text = "Parse Sync";
            this.btnUploadBinding.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUploadBinding.UseVisualStyleBackColor = false;
            this.btnUploadBinding.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemove.Location = new System.Drawing.Point(284, 24);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(151, 58);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Delete Books (Not in stock) ";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmBooks";
            this.ShowIcon = false;
            this.Text = "CSVSplitter Books";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txFileName;
        private System.Windows.Forms.OpenFileDialog fdCSVFileDialog;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolStripStatusLabel txRows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUploadBinding;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clInStock;
        private System.Windows.Forms.DataGridViewComboBoxColumn clBinding;
        private System.Windows.Forms.DataGridViewButtonColumn btnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription;
        private System.Windows.Forms.Button btnClear;
    }
}

