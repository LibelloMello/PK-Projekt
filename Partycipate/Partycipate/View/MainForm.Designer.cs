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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tbUserNameLogin = new System.Windows.Forms.TextBox();
            this.tbUserPasswordLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toTestForm = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.tbUpdateAge = new System.Windows.Forms.TextBox();
            this.tbUpdateEmail = new System.Windows.Forms.TextBox();
            this.tbUpdatePassword = new System.Windows.Forms.TextBox();
            this.tbUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.updateAccountInfo = new System.Windows.Forms.Label();
            this.buttonUpdateInfo = new System.Windows.Forms.Button();
            this.labelLoggedInUser = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelYourEvents = new System.Windows.Forms.Label();
            this.buttonDeleteEvent = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonCreateEvent = new System.Windows.Forms.Button();
            this.buttonUpdateEvent = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(317, 56);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 8;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(317, 82);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbPhoneNumber.TabIndex = 9;
            this.tbPhoneNumber.TextChanged += new System.EventHandler(this.tbPhoneNumber_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(317, 108);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 10;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(317, 134);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 11;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(317, 160);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 12;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(317, 186);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(100, 20);
            this.tbSex.TabIndex = 13;
            this.tbSex.TextChanged += new System.EventHandler(this.tbSex_TextChanged);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(317, 212);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 14;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sex";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(254, 215);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(26, 13);
            this.Age.TabIndex = 21;
            this.Age.Text = "Age";
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(319, 267);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(100, 23);
            this.buttonCreateUser.TabIndex = 22;
            this.buttonCreateUser.Text = "Create User";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(76, 143);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(77, 23);
            this.buttonLogin.TabIndex = 23;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // tbUserNameLogin
            // 
            this.tbUserNameLogin.Location = new System.Drawing.Point(61, 78);
            this.tbUserNameLogin.Name = "tbUserNameLogin";
            this.tbUserNameLogin.Size = new System.Drawing.Size(113, 20);
            this.tbUserNameLogin.TabIndex = 24;
            this.tbUserNameLogin.TextChanged += new System.EventHandler(this.tbUserNameLogin_TextChanged);
            // 
            // tbUserPasswordLogin
            // 
            this.tbUserPasswordLogin.Location = new System.Drawing.Point(61, 110);
            this.tbUserPasswordLogin.Name = "tbUserPasswordLogin";
            this.tbUserPasswordLogin.Size = new System.Drawing.Size(113, 20);
            this.tbUserPasswordLogin.TabIndex = 25;
            this.tbUserPasswordLogin.TextChanged += new System.EventHandler(this.tbUserPasswordLogin_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Please login using your credentials";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Not a member? Join us today!";
            // 
            // toTestForm
            // 
            this.toTestForm.Location = new System.Drawing.Point(50, 211);
            this.toTestForm.Name = "toTestForm";
            this.toTestForm.Size = new System.Drawing.Size(75, 23);
            this.toTestForm.TabIndex = 29;
            this.toTestForm.Text = "Testform";
            this.toTestForm.UseVisualStyleBackColor = true;
            this.toTestForm.Click += new System.EventHandler(this.toTestForm_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.labelError);
            this.loginPanel.Controls.Add(this.tbPassword);
            this.loginPanel.Controls.Add(this.toTestForm);
            this.loginPanel.Controls.Add(this.tbUserName);
            this.loginPanel.Controls.Add(this.tbPhoneNumber);
            this.loginPanel.Controls.Add(this.label7);
            this.loginPanel.Controls.Add(this.label8);
            this.loginPanel.Controls.Add(this.tbUserPasswordLogin);
            this.loginPanel.Controls.Add(this.tbName);
            this.loginPanel.Controls.Add(this.tbUserNameLogin);
            this.loginPanel.Controls.Add(this.buttonLogin);
            this.loginPanel.Controls.Add(this.tbEmail);
            this.loginPanel.Controls.Add(this.tbSex);
            this.loginPanel.Controls.Add(this.tbAge);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.buttonCreateUser);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.Age);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.label6);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.label5);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(714, 452);
            this.loginPanel.TabIndex = 30;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.buttonUpdateEvent);
            this.userPanel.Controls.Add(this.buttonCreateEvent);
            this.userPanel.Controls.Add(this.textBox6);
            this.userPanel.Controls.Add(this.textBox5);
            this.userPanel.Controls.Add(this.textBox4);
            this.userPanel.Controls.Add(this.textBox3);
            this.userPanel.Controls.Add(this.textBox2);
            this.userPanel.Controls.Add(this.textBox1);
            this.userPanel.Controls.Add(this.buttonDeleteEvent);
            this.userPanel.Controls.Add(this.labelYourEvents);
            this.userPanel.Controls.Add(this.dataGridView1);
            this.userPanel.Controls.Add(this.labelLoggedInUser);
            this.userPanel.Controls.Add(this.buttonUpdateInfo);
            this.userPanel.Controls.Add(this.updateAccountInfo);
            this.userPanel.Controls.Add(this.tbUpdatePhoneNumber);
            this.userPanel.Controls.Add(this.tbUpdatePassword);
            this.userPanel.Controls.Add(this.tbUpdateEmail);
            this.userPanel.Controls.Add(this.tbUpdateAge);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(714, 452);
            this.userPanel.TabIndex = 30;
            // 
            // tbUpdateAge
            // 
            this.tbUpdateAge.Location = new System.Drawing.Point(471, 56);
            this.tbUpdateAge.Name = "tbUpdateAge";
            this.tbUpdateAge.Size = new System.Drawing.Size(100, 20);
            this.tbUpdateAge.TabIndex = 0;
            // 
            // tbUpdateEmail
            // 
            this.tbUpdateEmail.Location = new System.Drawing.Point(471, 82);
            this.tbUpdateEmail.Name = "tbUpdateEmail";
            this.tbUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.tbUpdateEmail.TabIndex = 1;
            // 
            // tbUpdatePassword
            // 
            this.tbUpdatePassword.Location = new System.Drawing.Point(471, 108);
            this.tbUpdatePassword.Name = "tbUpdatePassword";
            this.tbUpdatePassword.Size = new System.Drawing.Size(100, 20);
            this.tbUpdatePassword.TabIndex = 2;
            // 
            // tbUpdatePhoneNumber
            // 
            this.tbUpdatePhoneNumber.Location = new System.Drawing.Point(471, 134);
            this.tbUpdatePhoneNumber.Name = "tbUpdatePhoneNumber";
            this.tbUpdatePhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbUpdatePhoneNumber.TabIndex = 4;
            // 
            // updateAccountInfo
            // 
            this.updateAccountInfo.AutoSize = true;
            this.updateAccountInfo.Location = new System.Drawing.Point(442, 33);
            this.updateAccountInfo.Name = "updateAccountInfo";
            this.updateAccountInfo.Size = new System.Drawing.Size(161, 13);
            this.updateAccountInfo.TabIndex = 6;
            this.updateAccountInfo.Text = "Update your account information";
            // 
            // buttonUpdateInfo
            // 
            this.buttonUpdateInfo.Location = new System.Drawing.Point(471, 163);
            this.buttonUpdateInfo.Name = "buttonUpdateInfo";
            this.buttonUpdateInfo.Size = new System.Drawing.Size(100, 23);
            this.buttonUpdateInfo.TabIndex = 7;
            this.buttonUpdateInfo.Text = "Update your info";
            this.buttonUpdateInfo.UseVisualStyleBackColor = true;
            this.buttonUpdateInfo.Click += new System.EventHandler(this.buttonUpdateInfo_Click);
            // 
            // labelLoggedInUser
            // 
            this.labelLoggedInUser.AutoSize = true;
            this.labelLoggedInUser.Location = new System.Drawing.Point(483, 12);
            this.labelLoggedInUser.Name = "labelLoggedInUser";
            this.labelLoggedInUser.Size = new System.Drawing.Size(0, 13);
            this.labelLoggedInUser.TabIndex = 8;
            this.labelLoggedInUser.Click += new System.EventHandler(this.labelLoggedInUser_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(205, 267);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(41, 13);
            this.labelError.TabIndex = 30;
            this.labelError.Text = "asdasd";
            this.labelError.Click += new System.EventHandler(this.labelError_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(258, 98);
            this.dataGridView1.TabIndex = 9;
            // 
            // labelYourEvents
            // 
            this.labelYourEvents.AutoSize = true;
            this.labelYourEvents.Location = new System.Drawing.Point(12, 33);
            this.labelYourEvents.Name = "labelYourEvents";
            this.labelYourEvents.Size = new System.Drawing.Size(64, 13);
            this.labelYourEvents.TabIndex = 10;
            this.labelYourEvents.Text = "Your events";
            // 
            // buttonDeleteEvent
            // 
            this.buttonDeleteEvent.Location = new System.Drawing.Point(159, 165);
            this.buttonDeleteEvent.Name = "buttonDeleteEvent";
            this.buttonDeleteEvent.Size = new System.Drawing.Size(84, 21);
            this.buttonDeleteEvent.TabIndex = 11;
            this.buttonDeleteEvent.Text = "Delete event";
            this.buttonDeleteEvent.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 244);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 270);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 296);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(176, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(15, 322);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(176, 20);
            this.textBox6.TabIndex = 17;
            // 
            // buttonCreateEvent
            // 
            this.buttonCreateEvent.Location = new System.Drawing.Point(15, 348);
            this.buttonCreateEvent.Name = "buttonCreateEvent";
            this.buttonCreateEvent.Size = new System.Drawing.Size(85, 23);
            this.buttonCreateEvent.TabIndex = 18;
            this.buttonCreateEvent.Text = "Create event";
            this.buttonCreateEvent.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateEvent
            // 
            this.buttonUpdateEvent.Location = new System.Drawing.Point(106, 348);
            this.buttonUpdateEvent.Name = "buttonUpdateEvent";
            this.buttonUpdateEvent.Size = new System.Drawing.Size(85, 23);
            this.buttonUpdateEvent.TabIndex = 19;
            this.buttonUpdateEvent.Text = "Update event";
            this.buttonUpdateEvent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 452);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.userPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox tbUserNameLogin;
        private System.Windows.Forms.TextBox tbUserPasswordLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button toTestForm;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.TextBox tbUpdatePassword;
        private System.Windows.Forms.TextBox tbUpdateEmail;
        private System.Windows.Forms.TextBox tbUpdateAge;
        private System.Windows.Forms.Label updateAccountInfo;
        private System.Windows.Forms.TextBox tbUpdatePhoneNumber;
        private System.Windows.Forms.Button buttonUpdateInfo;
        private System.Windows.Forms.Label labelLoggedInUser;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelYourEvents;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCreateEvent;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonDeleteEvent;
        private System.Windows.Forms.Button buttonUpdateEvent;
    }
}

