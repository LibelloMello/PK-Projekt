namespace Partycipate.View
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tBdelete = new System.Windows.Forms.TextBox();
            this.tBeventName = new System.Windows.Forms.TextBox();
            this.tBopenSlots = new System.Windows.Forms.TextBox();
            this.tBnote = new System.Windows.Forms.TextBox();
            this.tBlocation = new System.Windows.Forms.TextBox();
            this.tBeventTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateEvent = new System.Windows.Forms.Button();
            this.tBeventId = new System.Windows.Forms.TextBox();
            this.EventLocationButton = new System.Windows.Forms.Button();
            this.tBfindEventByLocation = new System.Windows.Forms.TextBox();
            this.tBdisplayEvent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteButton.Location = new System.Drawing.Point(118, 42);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // tBdelete
            // 
            this.tBdelete.Location = new System.Drawing.Point(12, 42);
            this.tBdelete.Name = "tBdelete";
            this.tBdelete.Size = new System.Drawing.Size(100, 20);
            this.tBdelete.TabIndex = 1;
            this.tBdelete.TextChanged += new System.EventHandler(this.tBdelete_TextChanged);
            // 
            // tBeventName
            // 
            this.tBeventName.Location = new System.Drawing.Point(404, 42);
            this.tBeventName.Name = "tBeventName";
            this.tBeventName.Size = new System.Drawing.Size(100, 20);
            this.tBeventName.TabIndex = 2;
            this.tBeventName.TextChanged += new System.EventHandler(this.tBeventName_TextChanged);
            // 
            // tBopenSlots
            // 
            this.tBopenSlots.Location = new System.Drawing.Point(404, 146);
            this.tBopenSlots.Name = "tBopenSlots";
            this.tBopenSlots.Size = new System.Drawing.Size(100, 20);
            this.tBopenSlots.TabIndex = 3;
            this.tBopenSlots.TextChanged += new System.EventHandler(this.tBopenSlots_TextChanged);
            // 
            // tBnote
            // 
            this.tBnote.Location = new System.Drawing.Point(404, 120);
            this.tBnote.Name = "tBnote";
            this.tBnote.Size = new System.Drawing.Size(100, 20);
            this.tBnote.TabIndex = 4;
            this.tBnote.TextChanged += new System.EventHandler(this.tBnote_TextChanged);
            // 
            // tBlocation
            // 
            this.tBlocation.Location = new System.Drawing.Point(404, 94);
            this.tBlocation.Name = "tBlocation";
            this.tBlocation.Size = new System.Drawing.Size(100, 20);
            this.tBlocation.TabIndex = 5;
            this.tBlocation.TextChanged += new System.EventHandler(this.tBlocation_TextChanged);
            // 
            // tBeventTime
            // 
            this.tBeventTime.Location = new System.Drawing.Point(404, 68);
            this.tBeventTime.Name = "tBeventTime";
            this.tBeventTime.Size = new System.Drawing.Size(100, 20);
            this.tBeventTime.TabIndex = 6;
            this.tBeventTime.TextChanged += new System.EventHandler(this.tBeventTime_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Event name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Event time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Note";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Open slots";
            // 
            // UpdateEvent
            // 
            this.UpdateEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UpdateEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEvent.Location = new System.Drawing.Point(526, 153);
            this.UpdateEvent.Name = "UpdateEvent";
            this.UpdateEvent.Size = new System.Drawing.Size(75, 23);
            this.UpdateEvent.TabIndex = 12;
            this.UpdateEvent.Text = "Update event";
            this.UpdateEvent.UseVisualStyleBackColor = true;
            this.UpdateEvent.Click += new System.EventHandler(this.UpdateEvent_Click);
            // 
            // tBeventId
            // 
            this.tBeventId.Location = new System.Drawing.Point(404, 16);
            this.tBeventId.Name = "tBeventId";
            this.tBeventId.Size = new System.Drawing.Size(100, 20);
            this.tBeventId.TabIndex = 13;
            this.tBeventId.TextChanged += new System.EventHandler(this.tBeventId_TextChanged);
            // 
            // EventLocationButton
            // 
            this.EventLocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EventLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EventLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventLocationButton.Location = new System.Drawing.Point(135, 195);
            this.EventLocationButton.Name = "EventLocationButton";
            this.EventLocationButton.Size = new System.Drawing.Size(75, 23);
            this.EventLocationButton.TabIndex = 14;
            this.EventLocationButton.Text = "Search";
            this.EventLocationButton.UseVisualStyleBackColor = true;
            this.EventLocationButton.Click += new System.EventHandler(this.EventLocationButton_Click);
            // 
            // tBfindEventByLocation
            // 
            this.tBfindEventByLocation.Location = new System.Drawing.Point(12, 195);
            this.tBfindEventByLocation.Name = "tBfindEventByLocation";
            this.tBfindEventByLocation.Size = new System.Drawing.Size(100, 20);
            this.tBfindEventByLocation.TabIndex = 15;
            this.tBfindEventByLocation.TextChanged += new System.EventHandler(this.tBfindEventByLocation_TextChanged);
            // 
            // tBdisplayEvent
            // 
            this.tBdisplayEvent.Location = new System.Drawing.Point(12, 261);
            this.tBdisplayEvent.Name = "tBdisplayEvent";
            this.tBdisplayEvent.Size = new System.Drawing.Size(231, 20);
            this.tBdisplayEvent.TabIndex = 16;
            this.tBdisplayEvent.TextChanged += new System.EventHandler(this.tBdisplayEvent_TextChanged);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 391);
            this.Controls.Add(this.tBdisplayEvent);
            this.Controls.Add(this.tBfindEventByLocation);
            this.Controls.Add(this.EventLocationButton);
            this.Controls.Add(this.tBeventId);
            this.Controls.Add(this.UpdateEvent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBeventTime);
            this.Controls.Add(this.tBlocation);
            this.Controls.Add(this.tBnote);
            this.Controls.Add(this.tBopenSlots);
            this.Controls.Add(this.tBeventName);
            this.Controls.Add(this.tBdelete);
            this.Controls.Add(this.DeleteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox tBdelete;
        private System.Windows.Forms.TextBox tBeventName;
        private System.Windows.Forms.TextBox tBopenSlots;
        private System.Windows.Forms.TextBox tBnote;
        private System.Windows.Forms.TextBox tBlocation;
        private System.Windows.Forms.TextBox tBeventTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateEvent;
        private System.Windows.Forms.TextBox tBeventId;
        private System.Windows.Forms.Button EventLocationButton;
        private System.Windows.Forms.TextBox tBfindEventByLocation;
        private System.Windows.Forms.TextBox tBdisplayEvent;
    }
}