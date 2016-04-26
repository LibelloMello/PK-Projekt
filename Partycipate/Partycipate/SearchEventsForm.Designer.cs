namespace Partycipate
{
    partial class SearchEventsForm
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
            this.eventTable = new System.Windows.Forms.DataGridView();
            this.cbEventLocations = new System.Windows.Forms.ComboBox();
            this.buttonSearchEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventTable)).BeginInit();
            this.SuspendLayout();
            // 
            // eventTable
            // 
            this.eventTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventTable.Location = new System.Drawing.Point(12, 64);
            this.eventTable.Name = "eventTable";
            this.eventTable.Size = new System.Drawing.Size(153, 70);
            this.eventTable.TabIndex = 0;
            this.eventTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventTable_CellContentClick);
            // 
            // cbEventLocations
            // 
            this.cbEventLocations.FormattingEnabled = true;
            this.cbEventLocations.Location = new System.Drawing.Point(12, 24);
            this.cbEventLocations.Name = "cbEventLocations";
            this.cbEventLocations.Size = new System.Drawing.Size(121, 21);
            this.cbEventLocations.TabIndex = 1;
            // 
            // buttonSearchEvents
            // 
            this.buttonSearchEvents.Location = new System.Drawing.Point(151, 24);
            this.buttonSearchEvents.Name = "buttonSearchEvents";
            this.buttonSearchEvents.Size = new System.Drawing.Size(106, 21);
            this.buttonSearchEvents.TabIndex = 2;
            this.buttonSearchEvents.Text = "Search events";
            this.buttonSearchEvents.UseVisualStyleBackColor = true;
            // 
            // SearchEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 261);
            this.Controls.Add(this.buttonSearchEvents);
            this.Controls.Add(this.cbEventLocations);
            this.Controls.Add(this.eventTable);
            this.Name = "SearchEventsForm";
            this.Text = "SearchEventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.eventTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eventTable;
        private System.Windows.Forms.ComboBox cbEventLocations;
        private System.Windows.Forms.Button buttonSearchEvents;
    }
}