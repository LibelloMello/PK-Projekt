namespace Partycipate.View
{
    partial class EventsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByLocationToolStrip = new System.Windows.Forms.ToolStrip();
            this.locationToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.locationToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByLocationToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.eVENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPENSLOTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oWNERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trappaDataSet = new Partycipate.trappaDataSet();
            this.pARTYTableAdapter = new Partycipate.trappaDataSetTableAdapters.PARTYTableAdapter();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByLocationToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trappaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eVENTIDDataGridViewTextBoxColumn,
            this.eVENTNAMEDataGridViewTextBoxColumn,
            this.eVENTTIMEDataGridViewTextBoxColumn,
            this.lOCATIONDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.oPENSLOTSDataGridViewTextBoxColumn,
            this.oWNERDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pARTYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 193);
            this.dataGridView1.TabIndex = 1;
            // 
            // fillByLocationToolStrip
            // 
            this.fillByLocationToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationToolStripLabel,
            this.toolStripComboBox1,
            this.fillByLocationToolStripButton,
            this.locationToolStripTextBox});
            this.fillByLocationToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByLocationToolStrip.Name = "fillByLocationToolStrip";
            this.fillByLocationToolStrip.Size = new System.Drawing.Size(789, 25);
            this.fillByLocationToolStrip.TabIndex = 2;
            this.fillByLocationToolStrip.Text = "fillByLocationToolStrip";
            this.fillByLocationToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByLocationToolStrip_ItemClicked);
            // 
            // locationToolStripLabel
            // 
            this.locationToolStripLabel.Name = "locationToolStripLabel";
            this.locationToolStripLabel.Size = new System.Drawing.Size(56, 22);
            this.locationToolStripLabel.Text = "Location:";
            // 
            // locationToolStripTextBox
            // 
            this.locationToolStripTextBox.Name = "locationToolStripTextBox";
            this.locationToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.locationToolStripTextBox.Click += new System.EventHandler(this.locationToolStripTextBox_Click);
            // 
            // fillByLocationToolStripButton
            // 
            this.fillByLocationToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByLocationToolStripButton.Name = "fillByLocationToolStripButton";
            this.fillByLocationToolStripButton.Size = new System.Drawing.Size(85, 22);
            this.fillByLocationToolStripButton.Text = "FillByLocation";
            this.fillByLocationToolStripButton.Click += new System.EventHandler(this.fillByLocationToolStripButton_Click);
            // 
            // eVENTIDDataGridViewTextBoxColumn
            // 
            this.eVENTIDDataGridViewTextBoxColumn.DataPropertyName = "EVENT_ID";
            this.eVENTIDDataGridViewTextBoxColumn.HeaderText = "EVENT_ID";
            this.eVENTIDDataGridViewTextBoxColumn.Name = "eVENTIDDataGridViewTextBoxColumn";
            // 
            // eVENTNAMEDataGridViewTextBoxColumn
            // 
            this.eVENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EVENT_NAME";
            this.eVENTNAMEDataGridViewTextBoxColumn.HeaderText = "EVENT_NAME";
            this.eVENTNAMEDataGridViewTextBoxColumn.Name = "eVENTNAMEDataGridViewTextBoxColumn";
            // 
            // eVENTTIMEDataGridViewTextBoxColumn
            // 
            this.eVENTTIMEDataGridViewTextBoxColumn.DataPropertyName = "EVENT_TIME";
            this.eVENTTIMEDataGridViewTextBoxColumn.HeaderText = "EVENT_TIME";
            this.eVENTTIMEDataGridViewTextBoxColumn.Name = "eVENTTIMEDataGridViewTextBoxColumn";
            // 
            // lOCATIONDataGridViewTextBoxColumn
            // 
            this.lOCATIONDataGridViewTextBoxColumn.DataPropertyName = "LOCATION";
            this.lOCATIONDataGridViewTextBoxColumn.HeaderText = "LOCATION";
            this.lOCATIONDataGridViewTextBoxColumn.Name = "lOCATIONDataGridViewTextBoxColumn";
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            // 
            // oPENSLOTSDataGridViewTextBoxColumn
            // 
            this.oPENSLOTSDataGridViewTextBoxColumn.DataPropertyName = "OPEN_SLOTS";
            this.oPENSLOTSDataGridViewTextBoxColumn.HeaderText = "OPEN_SLOTS";
            this.oPENSLOTSDataGridViewTextBoxColumn.Name = "oPENSLOTSDataGridViewTextBoxColumn";
            // 
            // oWNERDataGridViewTextBoxColumn
            // 
            this.oWNERDataGridViewTextBoxColumn.DataPropertyName = "OWNER";
            this.oWNERDataGridViewTextBoxColumn.HeaderText = "OWNER";
            this.oWNERDataGridViewTextBoxColumn.Name = "oWNERDataGridViewTextBoxColumn";
            // 
            // pARTYBindingSource
            // 
            this.pARTYBindingSource.DataMember = "PARTY";
            this.pARTYBindingSource.DataSource = this.trappaDataSet;
            // 
            // trappaDataSet
            // 
            this.trappaDataSet.DataSetName = "trappaDataSet";
            this.trappaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pARTYTableAdapter
            // 
            this.pARTYTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 372);
            this.Controls.Add(this.fillByLocationToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByLocationToolStrip.ResumeLayout(false);
            this.fillByLocationToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trappaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private trappaDataSet trappaDataSet;
        private System.Windows.Forms.BindingSource pARTYBindingSource;
        private trappaDataSetTableAdapters.PARTYTableAdapter pARTYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPENSLOTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oWNERDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByLocationToolStrip;
        private System.Windows.Forms.ToolStripLabel locationToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox locationToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByLocationToolStripButton;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}