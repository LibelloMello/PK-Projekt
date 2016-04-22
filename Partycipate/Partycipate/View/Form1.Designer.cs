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
            this.listOfEvents = new System.Windows.Forms.ListView();
            this.tbSearchStudentInput = new System.Windows.Forms.TextBox();
            this.btSearchUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btSearchUser.Location = new System.Drawing.Point(254, 48);
            this.btSearchUser.Name = "btSearchUser";
            this.btSearchUser.Size = new System.Drawing.Size(75, 23);
            this.btSearchUser.TabIndex = 4;
            this.btSearchUser.Text = "Search User";
            this.btSearchUser.UseVisualStyleBackColor = true;
            this.btSearchUser.Click += new System.EventHandler(this.btSearchUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 375);
            this.Controls.Add(this.btSearchUser);
            this.Controls.Add(this.tbSearchStudentInput);
            this.Controls.Add(this.listOfEvents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listOfEvents;
        private System.Windows.Forms.TextBox tbSearchStudentInput;
        private System.Windows.Forms.Button btSearchUser;
    }
}

