namespace FormApplication
{
    partial class Form
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
            this.userButton = new System.Windows.Forms.Button();
            this.eventButton = new System.Windows.Forms.Button();
            this.displayText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(12, 12);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(121, 23);
            this.userButton.TabIndex = 0;
            this.userButton.Text = "Show all users";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // eventButton
            // 
            this.eventButton.Location = new System.Drawing.Point(264, 12);
            this.eventButton.Name = "eventButton";
            this.eventButton.Size = new System.Drawing.Size(121, 23);
            this.eventButton.TabIndex = 1;
            this.eventButton.Text = "Show all events";
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
            // 
            // displayText
            // 
            this.displayText.Location = new System.Drawing.Point(12, 41);
            this.displayText.Name = "displayText";
            this.displayText.Size = new System.Drawing.Size(373, 358);
            this.displayText.TabIndex = 2;
            this.displayText.Text = "";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 411);
            this.Controls.Add(this.displayText);
            this.Controls.Add(this.eventButton);
            this.Controls.Add(this.userButton);
            this.Name = "Form";
            this.Text = "Show all users or events";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.RichTextBox displayText;
    }
}

