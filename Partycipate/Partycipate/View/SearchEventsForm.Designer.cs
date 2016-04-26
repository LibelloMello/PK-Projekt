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
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.listEventsTable = new System.Windows.Forms.DataGridView();
            this.buttonSearchEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listEventsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLocations
            // 
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(48, 35);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(101, 21);
            this.cbLocations.TabIndex = 0;
            // 
            // listEventsTable
            // 
            this.listEventsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEventsTable.Location = new System.Drawing.Point(48, 84);
            this.listEventsTable.Name = "listEventsTable";
            this.listEventsTable.Size = new System.Drawing.Size(216, 95);
            this.listEventsTable.TabIndex = 1;
            // 
            // buttonSearchEvents
            // 
            this.buttonSearchEvents.Location = new System.Drawing.Point(155, 35);
            this.buttonSearchEvents.Name = "buttonSearchEvents";
            this.buttonSearchEvents.Size = new System.Drawing.Size(109, 22);
            this.buttonSearchEvents.TabIndex = 2;
            this.buttonSearchEvents.Text = "Search events";
            this.buttonSearchEvents.UseVisualStyleBackColor = true;
            this.buttonSearchEvents.Click += new System.EventHandler(this.buttonSearchEvents_Click);
            // 
            // SearchEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 261);
            this.Controls.Add(this.buttonSearchEvents);
            this.Controls.Add(this.listEventsTable);
            this.Controls.Add(this.cbLocations);
            this.Name = "SearchEventsForm";
            this.Text = "SearchEventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.listEventsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.DataGridView listEventsTable;
        private System.Windows.Forms.Button buttonSearchEvents;
    }
}