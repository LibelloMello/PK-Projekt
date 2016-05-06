namespace ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.displayFile = new System.Windows.Forms.RichTextBox();
            this.search = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayFile
            // 
            this.displayFile.Location = new System.Drawing.Point(15, 39);
            this.displayFile.Name = "displayFile";
            this.displayFile.Size = new System.Drawing.Size(537, 400);
            this.displayFile.TabIndex = 3;
            this.displayFile.Text = "";
            // 
            // search
            // 
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(477, 10);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "Fetch!";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(199, 12);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(272, 20);
            this.fileName.TabIndex = 1;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(12, 13);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(181, 16);
            this.description.TabIndex = 0;
            this.description.Text = "Enter name of text file to fetch:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 451);
            this.Controls.Add(this.description);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.search);
            this.Controls.Add(this.displayFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Fetch File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayFile;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label description;
    }
}

