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
            this.tbSearchStudentInput = new System.Windows.Forms.TextBox();
            this.btSearchUser = new System.Windows.Forms.Button();
            this.searchEventButton = new System.Windows.Forms.Button();
            this.tbEvent = new System.Windows.Forms.TextBox();
            this.lbUserInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbSearchStudentInput
            // 
            this.tbSearchStudentInput.Location = new System.Drawing.Point(28, 48);
            this.tbSearchStudentInput.Multiline = true;
            this.tbSearchStudentInput.Name = "tbSearchStudentInput";
            this.tbSearchStudentInput.Size = new System.Drawing.Size(177, 20);
            this.tbSearchStudentInput.TabIndex = 3;
            this.tbSearchStudentInput.TextChanged += new System.EventHandler(this.tbSearchStudentInput_TextChanged);
            // 
            // btSearchUser
            // 
            this.btSearchUser.Location = new System.Drawing.Point(224, 48);
            this.btSearchUser.Name = "btSearchUser";
            this.btSearchUser.Size = new System.Drawing.Size(86, 20);
            this.btSearchUser.TabIndex = 4;
            this.btSearchUser.Text = "Search User";
            this.btSearchUser.UseVisualStyleBackColor = true;
            this.btSearchUser.Click += new System.EventHandler(this.btSearchUser_Click);
            // 
            // searchEventButton
            // 
            this.searchEventButton.Location = new System.Drawing.Point(224, 154);
            this.searchEventButton.Name = "searchEventButton";
            this.searchEventButton.Size = new System.Drawing.Size(86, 23);
            this.searchEventButton.TabIndex = 5;
            this.searchEventButton.Text = "Search Event";
            this.searchEventButton.UseVisualStyleBackColor = true;
            // 
            // tbEvent
            // 
            this.tbEvent.Location = new System.Drawing.Point(28, 157);
            this.tbEvent.Name = "tbEvent";
            this.tbEvent.Size = new System.Drawing.Size(177, 20);
            this.tbEvent.TabIndex = 6;
            // 
            // lbUserInfo
            // 
            this.lbUserInfo.FormattingEnabled = true;
            this.lbUserInfo.Location = new System.Drawing.Point(28, 74);
            this.lbUserInfo.MultiColumn = true;
            this.lbUserInfo.Name = "lbUserInfo";
            this.lbUserInfo.Size = new System.Drawing.Size(282, 43);
            this.lbUserInfo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 375);
            this.Controls.Add(this.lbUserInfo);
            this.Controls.Add(this.tbEvent);
            this.Controls.Add(this.searchEventButton);
            this.Controls.Add(this.btSearchUser);
            this.Controls.Add(this.tbSearchStudentInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSearchStudentInput;
        private System.Windows.Forms.Button btSearchUser;
        private System.Windows.Forms.Button searchEventButton;
        private System.Windows.Forms.TextBox tbEvent;
        private System.Windows.Forms.ListBox lbUserInfo;
    }
}

