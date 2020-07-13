namespace MeasurementsPolak
{
    partial class Measurements
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonIns = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.textBoxVal = new System.Windows.Forms.TextBox();
            this.textBoxComm = new System.Windows.Forms.TextBox();
            this.labelVal = new System.Windows.Forms.Label();
            this.labelComm = new System.Windows.Forms.Label();
            this.listBoxID = new System.Windows.Forms.ListBox();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.listBoxVal = new System.Windows.Forms.ListBox();
            this.listBoxComm = new System.Windows.Forms.ListBox();
            this.databaseMeasurementsDataSet = new MeasurementsPolak.DatabaseMeasurementsDataSet();
            this.databaseMeasurementsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewMeas = new System.Windows.Forms.DataGridView();
            this.tabMeasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabMeasTableAdapter = new MeasurementsPolak.DatabaseMeasurementsDataSetTableAdapters.TabMeasTableAdapter();
            this.tableAdapterManager = new MeasurementsPolak.DatabaseMeasurementsDataSetTableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseMeasurementsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseMeasurementsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMeasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIns
            // 
            this.buttonIns.BackColor = System.Drawing.Color.Green;
            this.buttonIns.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonIns.Location = new System.Drawing.Point(344, 22);
            this.buttonIns.Name = "buttonIns";
            this.buttonIns.Size = new System.Drawing.Size(100, 60);
            this.buttonIns.TabIndex = 0;
            this.buttonIns.Text = "Insert";
            this.buttonIns.UseVisualStyleBackColor = false;
            this.buttonIns.Click += new System.EventHandler(this.buttonIns_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDel.Location = new System.Drawing.Point(450, 22);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(100, 60);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonUpd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUpd.Location = new System.Drawing.Point(556, 22);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(100, 60);
            this.buttonUpd.TabIndex = 2;
            this.buttonUpd.Text = "Update";
            this.buttonUpd.UseVisualStyleBackColor = false;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // textBoxVal
            // 
            this.textBoxVal.Location = new System.Drawing.Point(94, 22);
            this.textBoxVal.Name = "textBoxVal";
            this.textBoxVal.Size = new System.Drawing.Size(236, 20);
            this.textBoxVal.TabIndex = 4;
            // 
            // textBoxComm
            // 
            this.textBoxComm.Location = new System.Drawing.Point(94, 60);
            this.textBoxComm.Name = "textBoxComm";
            this.textBoxComm.Size = new System.Drawing.Size(236, 20);
            this.textBoxComm.TabIndex = 5;
            // 
            // labelVal
            // 
            this.labelVal.AutoSize = true;
            this.labelVal.Location = new System.Drawing.Point(22, 22);
            this.labelVal.Name = "labelVal";
            this.labelVal.Size = new System.Drawing.Size(37, 13);
            this.labelVal.TabIndex = 6;
            this.labelVal.Text = "Value:";
            // 
            // labelComm
            // 
            this.labelComm.AutoSize = true;
            this.labelComm.Location = new System.Drawing.Point(22, 60);
            this.labelComm.Name = "labelComm";
            this.labelComm.Size = new System.Drawing.Size(54, 13);
            this.labelComm.TabIndex = 7;
            this.labelComm.Text = "Comment:";
            // 
            // listBoxID
            // 
            this.listBoxID.FormattingEnabled = true;
            this.listBoxID.Location = new System.Drawing.Point(25, 107);
            this.listBoxID.Name = "listBoxID";
            this.listBoxID.Size = new System.Drawing.Size(63, 251);
            this.listBoxID.TabIndex = 8;
            // 
            // listBoxTime
            // 
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.Location = new System.Drawing.Point(94, 107);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(120, 251);
            this.listBoxTime.TabIndex = 9;
            // 
            // listBoxVal
            // 
            this.listBoxVal.FormattingEnabled = true;
            this.listBoxVal.Location = new System.Drawing.Point(220, 107);
            this.listBoxVal.Name = "listBoxVal";
            this.listBoxVal.Size = new System.Drawing.Size(118, 251);
            this.listBoxVal.TabIndex = 10;
            // 
            // listBoxComm
            // 
            this.listBoxComm.FormattingEnabled = true;
            this.listBoxComm.Location = new System.Drawing.Point(344, 107);
            this.listBoxComm.Name = "listBoxComm";
            this.listBoxComm.Size = new System.Drawing.Size(312, 251);
            this.listBoxComm.TabIndex = 11;
            // 
            // databaseMeasurementsDataSet
            // 
            this.databaseMeasurementsDataSet.DataSetName = "DatabaseMeasurementsDataSet";
            this.databaseMeasurementsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseMeasurementsDataSetBindingSource
            // 
            this.databaseMeasurementsDataSetBindingSource.DataSource = this.databaseMeasurementsDataSet;
            this.databaseMeasurementsDataSetBindingSource.Position = 0;
            // 
            // GridViewMeas
            // 
            this.GridViewMeas.AutoGenerateColumns = false;
            this.GridViewMeas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMeas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.GridViewMeas.DataSource = this.tabMeasBindingSource;
            this.GridViewMeas.Location = new System.Drawing.Point(25, 365);
            this.GridViewMeas.Name = "GridViewMeas";
            this.GridViewMeas.Size = new System.Drawing.Size(631, 150);
            this.GridViewMeas.TabIndex = 12;
            this.GridViewMeas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMeas_CellContentClick);
            // 
            // tabMeasBindingSource
            // 
            this.tabMeasBindingSource.DataMember = "TabMeas";
            this.tabMeasBindingSource.DataSource = this.databaseMeasurementsDataSet;
            // 
            // tabMeasTableAdapter
            // 
            this.tabMeasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabMeasTableAdapter = this.tabMeasTableAdapter;
            this.tableAdapterManager.UpdateOrder = MeasurementsPolak.DatabaseMeasurementsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // Measurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.GridViewMeas);
            this.Controls.Add(this.listBoxComm);
            this.Controls.Add(this.listBoxVal);
            this.Controls.Add(this.listBoxTime);
            this.Controls.Add(this.listBoxID);
            this.Controls.Add(this.labelComm);
            this.Controls.Add(this.labelVal);
            this.Controls.Add(this.textBoxComm);
            this.Controls.Add(this.textBoxVal);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonIns);
            this.Name = "Measurements";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Measurements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseMeasurementsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseMeasurementsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMeasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIns;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.TextBox textBoxVal;
        private System.Windows.Forms.TextBox textBoxComm;
        private System.Windows.Forms.Label labelVal;
        private System.Windows.Forms.Label labelComm;
        private System.Windows.Forms.ListBox listBoxID;
        private System.Windows.Forms.ListBox listBoxTime;
        private System.Windows.Forms.ListBox listBoxVal;
        private System.Windows.Forms.ListBox listBoxComm;
        private DatabaseMeasurementsDataSet databaseMeasurementsDataSet;
        private System.Windows.Forms.BindingSource databaseMeasurementsDataSetBindingSource;
        private System.Windows.Forms.DataGridView GridViewMeas;
        private System.Windows.Forms.BindingSource tabMeasBindingSource;
        private DatabaseMeasurementsDataSetTableAdapters.TabMeasTableAdapter tabMeasTableAdapter;
        private DatabaseMeasurementsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}

