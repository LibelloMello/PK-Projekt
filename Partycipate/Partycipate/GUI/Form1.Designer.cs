namespace Partycipate
{
    partial class Form1
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
            this.listOfEvents = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbLocations
            // 
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(28, 60);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(177, 21);
            this.cbLocations.TabIndex = 0;
            this.cbLocations.SelectedIndexChanged += new System.EventHandler(this.cbLocations_SelectedIndexChanged);
            // 
            // listOfEvents
            // 
            this.listOfEvents.Location = new System.Drawing.Point(28, 111);
            this.listOfEvents.Name = "listOfEvents";
            this.listOfEvents.Size = new System.Drawing.Size(177, 207);
            this.listOfEvents.TabIndex = 1;
            this.listOfEvents.UseCompatibleStateImageBehavior = false;
            this.listOfEvents.SelectedIndexChanged += new System.EventHandler(this.listOfEvents_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 93);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listOfEvents);
            this.Controls.Add(this.cbLocations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.ListView listOfEvents;
        private System.Windows.Forms.Button button1;
    }
}

