namespace Partycipate
{
    partial class MainForm
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
            this.labelCreateUserName = new System.Windows.Forms.Label();
            this.labelCreatePhone = new System.Windows.Forms.Label();
            this.labelCreateEmail = new System.Windows.Forms.Label();
            this.labelCreateName = new System.Windows.Forms.Label();
            this.labelCreatePassword = new System.Windows.Forms.Label();
            this.labelCreateSex = new System.Windows.Forms.Label();
            this.labelCreateAge = new System.Windows.Forms.Label();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tbUserNameLogin = new System.Windows.Forms.TextBox();
            this.tbUserPasswordLogin = new System.Windows.Forms.TextBox();
            this.labelInfoForLogin = new System.Windows.Forms.Label();
            this.labelInfoCreateUser = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.labelErrorLogin = new System.Windows.Forms.Label();
            this.labelLoginPanelInfo = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.labelPasswordUserUpdate = new System.Windows.Forms.Label();
            this.labelEmailUserUpdate = new System.Windows.Forms.Label();
            this.labelUpdatePhoneNumber = new System.Windows.Forms.Label();
            this.gbDeleteFromAttendee = new System.Windows.Forms.GroupBox();
            this.tbUnattend = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbAttendAnEvent = new System.Windows.Forms.GroupBox();
            this.buttonAttendEvent = new System.Windows.Forms.Button();
            this.tbAttendEvent = new System.Windows.Forms.TextBox();
            this.gbToUpdateEvent = new System.Windows.Forms.GroupBox();
            this.buttonUpdateEvent = new System.Windows.Forms.Button();
            this.tbEventIdForUpdate = new System.Windows.Forms.TextBox();
            this.gbDeleteAnEvent = new System.Windows.Forms.GroupBox();
            this.tbEventId = new System.Windows.Forms.TextBox();
            this.buttonDeleteEvent = new System.Windows.Forms.Button();
            this.gbUserPanelInfo = new System.Windows.Forms.GroupBox();
            this.labelInfoUserPanel = new System.Windows.Forms.Label();
            this.buttonToCreateEvent = new System.Windows.Forms.Button();
            this.labelExplanationUpdate = new System.Windows.Forms.Label();
            this.buttonShowOwnEvents = new System.Windows.Forms.Button();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.buttonSearchEvents = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listOfEventsByUser = new System.Windows.Forms.DataGridView();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelLoggedInUser = new System.Windows.Forms.Label();
            this.buttonUpdateInfo = new System.Windows.Forms.Button();
            this.updateAccountInfo = new System.Windows.Forms.Label();
            this.tbUpdatePassword = new System.Windows.Forms.TextBox();
            this.tbUpdateEmail = new System.Windows.Forms.TextBox();
            this.tbUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.updateCreateEventPanel = new System.Windows.Forms.Panel();
            this.gbUpdateEvent = new System.Windows.Forms.GroupBox();
            this.tbUpdateOpenSlots = new System.Windows.Forms.TextBox();
            this.tbUpdateEventName = new System.Windows.Forms.TextBox();
            this.tbUpdateEventTime = new System.Windows.Forms.TextBox();
            this.tbUpdateLocation = new System.Windows.Forms.TextBox();
            this.labelOpenSlotsUpdate = new System.Windows.Forms.Label();
            this.tbUpdateNote = new System.Windows.Forms.TextBox();
            this.labelNoteUpdate = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelLocationUpdate = new System.Windows.Forms.Label();
            this.labelEventNameUpdate = new System.Windows.Forms.Label();
            this.labelEventTimeUpdate = new System.Windows.Forms.Label();
            this.gbCreateEvent = new System.Windows.Forms.GroupBox();
            this.tbOpenSlots = new System.Windows.Forms.TextBox();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.labelOpenSlots = new System.Windows.Forms.Label();
            this.tbEventTime = new System.Windows.Forms.TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.buttonCreateEvent = new System.Windows.Forms.Button();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelErrorCreateUpdate = new System.Windows.Forms.Label();
            this.buttonBackToUser = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.gbDeleteFromAttendee.SuspendLayout();
            this.gbAttendAnEvent.SuspendLayout();
            this.gbToUpdateEvent.SuspendLayout();
            this.gbDeleteAnEvent.SuspendLayout();
            this.gbUserPanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfEventsByUser)).BeginInit();
            this.updateCreateEventPanel.SuspendLayout();
            this.gbUpdateEvent.SuspendLayout();
            this.gbCreateEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(444, 85);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 8;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(444, 111);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbPhoneNumber.TabIndex = 9;
            this.tbPhoneNumber.TextChanged += new System.EventHandler(this.tbPhoneNumber_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(444, 137);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 10;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(444, 163);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 11;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(444, 189);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 12;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(444, 215);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(100, 20);
            this.tbSex.TabIndex = 13;
            this.tbSex.TextChanged += new System.EventHandler(this.tbSex_TextChanged);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(444, 241);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 14;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // labelCreateUserName
            // 
            this.labelCreateUserName.AutoSize = true;
            this.labelCreateUserName.Location = new System.Drawing.Point(381, 88);
            this.labelCreateUserName.Name = "labelCreateUserName";
            this.labelCreateUserName.Size = new System.Drawing.Size(55, 13);
            this.labelCreateUserName.TabIndex = 15;
            this.labelCreateUserName.Text = "Username";
            // 
            // labelCreatePhone
            // 
            this.labelCreatePhone.AutoSize = true;
            this.labelCreatePhone.Location = new System.Drawing.Point(381, 114);
            this.labelCreatePhone.Name = "labelCreatePhone";
            this.labelCreatePhone.Size = new System.Drawing.Size(38, 13);
            this.labelCreatePhone.TabIndex = 16;
            this.labelCreatePhone.Text = "Phone";
            // 
            // labelCreateEmail
            // 
            this.labelCreateEmail.AutoSize = true;
            this.labelCreateEmail.Location = new System.Drawing.Point(381, 166);
            this.labelCreateEmail.Name = "labelCreateEmail";
            this.labelCreateEmail.Size = new System.Drawing.Size(32, 13);
            this.labelCreateEmail.TabIndex = 17;
            this.labelCreateEmail.Text = "Email";
            this.labelCreateEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelCreateName
            // 
            this.labelCreateName.AutoSize = true;
            this.labelCreateName.Location = new System.Drawing.Point(381, 140);
            this.labelCreateName.Name = "labelCreateName";
            this.labelCreateName.Size = new System.Drawing.Size(35, 13);
            this.labelCreateName.TabIndex = 18;
            this.labelCreateName.Text = "Name";
            this.labelCreateName.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelCreatePassword
            // 
            this.labelCreatePassword.AutoSize = true;
            this.labelCreatePassword.Location = new System.Drawing.Point(381, 192);
            this.labelCreatePassword.Name = "labelCreatePassword";
            this.labelCreatePassword.Size = new System.Drawing.Size(53, 13);
            this.labelCreatePassword.TabIndex = 19;
            this.labelCreatePassword.Text = "Password";
            // 
            // labelCreateSex
            // 
            this.labelCreateSex.AutoSize = true;
            this.labelCreateSex.Location = new System.Drawing.Point(381, 218);
            this.labelCreateSex.Name = "labelCreateSex";
            this.labelCreateSex.Size = new System.Drawing.Size(25, 13);
            this.labelCreateSex.TabIndex = 20;
            this.labelCreateSex.Text = "Sex";
            this.labelCreateSex.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelCreateAge
            // 
            this.labelCreateAge.AutoSize = true;
            this.labelCreateAge.Location = new System.Drawing.Point(381, 244);
            this.labelCreateAge.Name = "labelCreateAge";
            this.labelCreateAge.Size = new System.Drawing.Size(26, 13);
            this.labelCreateAge.TabIndex = 21;
            this.labelCreateAge.Text = "Age";
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(444, 270);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(100, 23);
            this.buttonCreateUser.TabIndex = 22;
            this.buttonCreateUser.Text = "Create User";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(145, 150);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(77, 23);
            this.buttonLogin.TabIndex = 23;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // tbUserNameLogin
            // 
            this.tbUserNameLogin.Location = new System.Drawing.Point(130, 85);
            this.tbUserNameLogin.Name = "tbUserNameLogin";
            this.tbUserNameLogin.Size = new System.Drawing.Size(113, 20);
            this.tbUserNameLogin.TabIndex = 24;
            this.tbUserNameLogin.TextChanged += new System.EventHandler(this.tbUserNameLogin_TextChanged);
            // 
            // tbUserPasswordLogin
            // 
            this.tbUserPasswordLogin.Location = new System.Drawing.Point(130, 117);
            this.tbUserPasswordLogin.Name = "tbUserPasswordLogin";
            this.tbUserPasswordLogin.Size = new System.Drawing.Size(113, 20);
            this.tbUserPasswordLogin.TabIndex = 25;
            this.tbUserPasswordLogin.TextChanged += new System.EventHandler(this.tbUserPasswordLogin_TextChanged);
            // 
            // labelInfoForLogin
            // 
            this.labelInfoForLogin.AutoSize = true;
            this.labelInfoForLogin.Location = new System.Drawing.Point(105, 49);
            this.labelInfoForLogin.Name = "labelInfoForLogin";
            this.labelInfoForLogin.Size = new System.Drawing.Size(169, 13);
            this.labelInfoForLogin.TabIndex = 26;
            this.labelInfoForLogin.Text = "Please login using your credentials";
            // 
            // labelInfoCreateUser
            // 
            this.labelInfoCreateUser.AutoSize = true;
            this.labelInfoCreateUser.Location = new System.Drawing.Point(381, 49);
            this.labelInfoCreateUser.Name = "labelInfoCreateUser";
            this.labelInfoCreateUser.Size = new System.Drawing.Size(147, 13);
            this.labelInfoCreateUser.TabIndex = 27;
            this.labelInfoCreateUser.Text = "Not a member? Join us today!";
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.labelErrorLogin);
            this.loginPanel.Controls.Add(this.labelLoginPanelInfo);
            this.loginPanel.Controls.Add(this.tbPassword);
            this.loginPanel.Controls.Add(this.tbUserName);
            this.loginPanel.Controls.Add(this.tbPhoneNumber);
            this.loginPanel.Controls.Add(this.labelInfoForLogin);
            this.loginPanel.Controls.Add(this.labelInfoCreateUser);
            this.loginPanel.Controls.Add(this.tbUserPasswordLogin);
            this.loginPanel.Controls.Add(this.tbName);
            this.loginPanel.Controls.Add(this.tbUserNameLogin);
            this.loginPanel.Controls.Add(this.buttonLogin);
            this.loginPanel.Controls.Add(this.tbEmail);
            this.loginPanel.Controls.Add(this.tbSex);
            this.loginPanel.Controls.Add(this.tbAge);
            this.loginPanel.Controls.Add(this.labelCreateUserName);
            this.loginPanel.Controls.Add(this.buttonCreateUser);
            this.loginPanel.Controls.Add(this.labelCreatePhone);
            this.loginPanel.Controls.Add(this.labelCreateAge);
            this.loginPanel.Controls.Add(this.labelCreateEmail);
            this.loginPanel.Controls.Add(this.labelCreateSex);
            this.loginPanel.Controls.Add(this.labelCreateName);
            this.loginPanel.Controls.Add(this.labelCreatePassword);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(677, 586);
            this.loginPanel.TabIndex = 30;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // labelErrorLogin
            // 
            this.labelErrorLogin.AutoSize = true;
            this.labelErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLogin.Location = new System.Drawing.Point(105, 193);
            this.labelErrorLogin.Name = "labelErrorLogin";
            this.labelErrorLogin.Size = new System.Drawing.Size(0, 13);
            this.labelErrorLogin.TabIndex = 31;
            this.labelErrorLogin.Click += new System.EventHandler(this.labelErrorLogin_Click);
            // 
            // labelLoginPanelInfo
            // 
            this.labelLoginPanelInfo.AutoSize = true;
            this.labelLoginPanelInfo.Location = new System.Drawing.Point(332, 296);
            this.labelLoginPanelInfo.Name = "labelLoginPanelInfo";
            this.labelLoginPanelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelLoginPanelInfo.TabIndex = 30;
            this.labelLoginPanelInfo.Click += new System.EventHandler(this.labelError_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.labelPasswordUserUpdate);
            this.userPanel.Controls.Add(this.labelEmailUserUpdate);
            this.userPanel.Controls.Add(this.labelUpdatePhoneNumber);
            this.userPanel.Controls.Add(this.gbDeleteFromAttendee);
            this.userPanel.Controls.Add(this.gbAttendAnEvent);
            this.userPanel.Controls.Add(this.gbToUpdateEvent);
            this.userPanel.Controls.Add(this.gbUserPanelInfo);
            this.userPanel.Controls.Add(this.buttonToCreateEvent);
            this.userPanel.Controls.Add(this.labelExplanationUpdate);
            this.userPanel.Controls.Add(this.buttonShowOwnEvents);
            this.userPanel.Controls.Add(this.cbLocations);
            this.userPanel.Controls.Add(this.buttonSearchEvents);
            this.userPanel.Controls.Add(this.buttonLogout);
            this.userPanel.Controls.Add(this.listOfEventsByUser);
            this.userPanel.Controls.Add(this.labelEvents);
            this.userPanel.Controls.Add(this.labelLoggedInUser);
            this.userPanel.Controls.Add(this.buttonUpdateInfo);
            this.userPanel.Controls.Add(this.updateAccountInfo);
            this.userPanel.Controls.Add(this.tbUpdatePassword);
            this.userPanel.Controls.Add(this.tbUpdateEmail);
            this.userPanel.Controls.Add(this.tbUpdatePhoneNumber);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(677, 586);
            this.userPanel.TabIndex = 30;
            this.userPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userPanel_Paint);
            // 
            // labelPasswordUserUpdate
            // 
            this.labelPasswordUserUpdate.AutoSize = true;
            this.labelPasswordUserUpdate.Location = new System.Drawing.Point(434, 369);
            this.labelPasswordUserUpdate.Name = "labelPasswordUserUpdate";
            this.labelPasswordUserUpdate.Size = new System.Drawing.Size(53, 13);
            this.labelPasswordUserUpdate.TabIndex = 48;
            this.labelPasswordUserUpdate.Text = "Password";
            // 
            // labelEmailUserUpdate
            // 
            this.labelEmailUserUpdate.AutoSize = true;
            this.labelEmailUserUpdate.Location = new System.Drawing.Point(433, 341);
            this.labelEmailUserUpdate.Name = "labelEmailUserUpdate";
            this.labelEmailUserUpdate.Size = new System.Drawing.Size(32, 13);
            this.labelEmailUserUpdate.TabIndex = 47;
            this.labelEmailUserUpdate.Text = "Email";
            // 
            // labelUpdatePhoneNumber
            // 
            this.labelUpdatePhoneNumber.AutoSize = true;
            this.labelUpdatePhoneNumber.Location = new System.Drawing.Point(433, 315);
            this.labelUpdatePhoneNumber.Name = "labelUpdatePhoneNumber";
            this.labelUpdatePhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.labelUpdatePhoneNumber.TabIndex = 46;
            this.labelUpdatePhoneNumber.Text = "Phone number";
            // 
            // gbDeleteFromAttendee
            // 
            this.gbDeleteFromAttendee.Controls.Add(this.tbUnattend);
            this.gbDeleteFromAttendee.Controls.Add(this.button1);
            this.gbDeleteFromAttendee.Location = new System.Drawing.Point(4, 315);
            this.gbDeleteFromAttendee.Name = "gbDeleteFromAttendee";
            this.gbDeleteFromAttendee.Size = new System.Drawing.Size(270, 48);
            this.gbDeleteFromAttendee.TabIndex = 45;
            this.gbDeleteFromAttendee.TabStop = false;
            this.gbDeleteFromAttendee.Text = "Stop attending";
            // 
            // tbUnattend
            // 
            this.tbUnattend.Location = new System.Drawing.Point(14, 19);
            this.tbUnattend.Name = "tbUnattend";
            this.tbUnattend.Size = new System.Drawing.Size(115, 20);
            this.tbUnattend.TabIndex = 44;
            this.tbUnattend.TextChanged += new System.EventHandler(this.tbUnattend_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 20);
            this.button1.TabIndex = 46;
            this.button1.Text = "Unattend";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.unattend_Click);
            // 
            // gbAttendAnEvent
            // 
            this.gbAttendAnEvent.Controls.Add(this.buttonAttendEvent);
            this.gbAttendAnEvent.Controls.Add(this.tbAttendEvent);
            this.gbAttendAnEvent.Location = new System.Drawing.Point(3, 261);
            this.gbAttendAnEvent.Name = "gbAttendAnEvent";
            this.gbAttendAnEvent.Size = new System.Drawing.Size(270, 48);
            this.gbAttendAnEvent.TabIndex = 44;
            this.gbAttendAnEvent.TabStop = false;
            this.gbAttendAnEvent.Text = "Attend an event";
            // 
            // buttonAttendEvent
            // 
            this.buttonAttendEvent.Location = new System.Drawing.Point(139, 19);
            this.buttonAttendEvent.Name = "buttonAttendEvent";
            this.buttonAttendEvent.Size = new System.Drawing.Size(104, 20);
            this.buttonAttendEvent.TabIndex = 42;
            this.buttonAttendEvent.Text = "Attend";
            this.buttonAttendEvent.UseVisualStyleBackColor = true;
            this.buttonAttendEvent.Click += new System.EventHandler(this.buttonAttendEvent_Click);
            // 
            // tbAttendEvent
            // 
            this.tbAttendEvent.Location = new System.Drawing.Point(14, 19);
            this.tbAttendEvent.Name = "tbAttendEvent";
            this.tbAttendEvent.Size = new System.Drawing.Size(115, 20);
            this.tbAttendEvent.TabIndex = 43;
            this.tbAttendEvent.TextChanged += new System.EventHandler(this.tbAttendEvent_TextChanged);
            // 
            // gbToUpdateEvent
            // 
            this.gbToUpdateEvent.Controls.Add(this.buttonUpdateEvent);
            this.gbToUpdateEvent.Controls.Add(this.tbEventIdForUpdate);
            this.gbToUpdateEvent.Controls.Add(this.gbDeleteAnEvent);
            this.gbToUpdateEvent.Location = new System.Drawing.Point(3, 369);
            this.gbToUpdateEvent.Name = "gbToUpdateEvent";
            this.gbToUpdateEvent.Size = new System.Drawing.Size(270, 52);
            this.gbToUpdateEvent.TabIndex = 39;
            this.gbToUpdateEvent.TabStop = false;
            this.gbToUpdateEvent.Text = "Update event";
            this.gbToUpdateEvent.Enter += new System.EventHandler(this.gbToUpdateEvent_Enter);
            // 
            // buttonUpdateEvent
            // 
            this.buttonUpdateEvent.Location = new System.Drawing.Point(137, 19);
            this.buttonUpdateEvent.Name = "buttonUpdateEvent";
            this.buttonUpdateEvent.Size = new System.Drawing.Size(106, 20);
            this.buttonUpdateEvent.TabIndex = 19;
            this.buttonUpdateEvent.Text = "Update";
            this.buttonUpdateEvent.UseVisualStyleBackColor = true;
            this.buttonUpdateEvent.Click += new System.EventHandler(this.buttonUpdateEvent_Click);
            // 
            // tbEventIdForUpdate
            // 
            this.tbEventIdForUpdate.Location = new System.Drawing.Point(14, 19);
            this.tbEventIdForUpdate.Name = "tbEventIdForUpdate";
            this.tbEventIdForUpdate.Size = new System.Drawing.Size(113, 20);
            this.tbEventIdForUpdate.TabIndex = 35;
            this.tbEventIdForUpdate.TextChanged += new System.EventHandler(this.tbEventIdForUpdate_TextChanged);
            // 
            // gbDeleteAnEvent
            // 
            this.gbDeleteAnEvent.Controls.Add(this.tbEventId);
            this.gbDeleteAnEvent.Controls.Add(this.buttonDeleteEvent);
            this.gbDeleteAnEvent.Location = new System.Drawing.Point(1, 55);
            this.gbDeleteAnEvent.Name = "gbDeleteAnEvent";
            this.gbDeleteAnEvent.Size = new System.Drawing.Size(270, 51);
            this.gbDeleteAnEvent.TabIndex = 40;
            this.gbDeleteAnEvent.TabStop = false;
            this.gbDeleteAnEvent.Text = "Delete an event";
            // 
            // tbEventId
            // 
            this.tbEventId.Location = new System.Drawing.Point(14, 19);
            this.tbEventId.Name = "tbEventId";
            this.tbEventId.Size = new System.Drawing.Size(113, 20);
            this.tbEventId.TabIndex = 12;
            this.tbEventId.TextChanged += new System.EventHandler(this.tbEventId_TextChanged);
            // 
            // buttonDeleteEvent
            // 
            this.buttonDeleteEvent.Location = new System.Drawing.Point(137, 19);
            this.buttonDeleteEvent.Name = "buttonDeleteEvent";
            this.buttonDeleteEvent.Size = new System.Drawing.Size(106, 20);
            this.buttonDeleteEvent.TabIndex = 11;
            this.buttonDeleteEvent.Text = "Delete";
            this.buttonDeleteEvent.UseVisualStyleBackColor = true;
            this.buttonDeleteEvent.Click += new System.EventHandler(this.buttonDeleteEvent_Click);
            // 
            // gbUserPanelInfo
            // 
            this.gbUserPanelInfo.Controls.Add(this.labelInfoUserPanel);
            this.gbUserPanelInfo.Location = new System.Drawing.Point(302, 466);
            this.gbUserPanelInfo.Name = "gbUserPanelInfo";
            this.gbUserPanelInfo.Size = new System.Drawing.Size(315, 43);
            this.gbUserPanelInfo.TabIndex = 38;
            this.gbUserPanelInfo.TabStop = false;
            this.gbUserPanelInfo.Text = "Information";
            this.gbUserPanelInfo.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // labelInfoUserPanel
            // 
            this.labelInfoUserPanel.AutoSize = true;
            this.labelInfoUserPanel.Location = new System.Drawing.Point(11, 16);
            this.labelInfoUserPanel.Name = "labelInfoUserPanel";
            this.labelInfoUserPanel.Size = new System.Drawing.Size(0, 13);
            this.labelInfoUserPanel.TabIndex = 36;
            this.labelInfoUserPanel.Click += new System.EventHandler(this.labelErrorUserPanel_Click);
            // 
            // buttonToCreateEvent
            // 
            this.buttonToCreateEvent.Location = new System.Drawing.Point(384, 220);
            this.buttonToCreateEvent.Name = "buttonToCreateEvent";
            this.buttonToCreateEvent.Size = new System.Drawing.Size(115, 23);
            this.buttonToCreateEvent.TabIndex = 37;
            this.buttonToCreateEvent.Text = "Create an event";
            this.buttonToCreateEvent.UseVisualStyleBackColor = true;
            this.buttonToCreateEvent.Click += new System.EventHandler(this.buttonToCreateEvent_Click);
            // 
            // labelExplanationUpdate
            // 
            this.labelExplanationUpdate.AutoSize = true;
            this.labelExplanationUpdate.Location = new System.Drawing.Point(15, 427);
            this.labelExplanationUpdate.Name = "labelExplanationUpdate";
            this.labelExplanationUpdate.Size = new System.Drawing.Size(248, 13);
            this.labelExplanationUpdate.TabIndex = 34;
            this.labelExplanationUpdate.Text = "Fill in the Event ID of the Event you want to update";
            // 
            // buttonShowOwnEvents
            // 
            this.buttonShowOwnEvents.Location = new System.Drawing.Point(515, 220);
            this.buttonShowOwnEvents.Name = "buttonShowOwnEvents";
            this.buttonShowOwnEvents.Size = new System.Drawing.Size(103, 23);
            this.buttonShowOwnEvents.TabIndex = 26;
            this.buttonShowOwnEvents.Text = "Show your events";
            this.buttonShowOwnEvents.UseVisualStyleBackColor = true;
            this.buttonShowOwnEvents.Click += new System.EventHandler(this.buttonShowOwnEvents_Click);
            // 
            // cbLocations
            // 
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(17, 223);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(116, 21);
            this.cbLocations.TabIndex = 24;
            this.cbLocations.SelectedIndexChanged += new System.EventHandler(this.cbLocations_SelectedIndexChanged);
            // 
            // buttonSearchEvents
            // 
            this.buttonSearchEvents.Location = new System.Drawing.Point(142, 223);
            this.buttonSearchEvents.Name = "buttonSearchEvents";
            this.buttonSearchEvents.Size = new System.Drawing.Size(104, 21);
            this.buttonSearchEvents.TabIndex = 23;
            this.buttonSearchEvents.Text = "Search events";
            this.buttonSearchEvents.UseVisualStyleBackColor = true;
            this.buttonSearchEvents.Click += new System.EventHandler(this.buttonSearchEvents_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(538, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 21;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // listOfEventsByUser
            // 
            this.listOfEventsByUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfEventsByUser.Location = new System.Drawing.Point(17, 41);
            this.listOfEventsByUser.Name = "listOfEventsByUser";
            this.listOfEventsByUser.Size = new System.Drawing.Size(601, 173);
            this.listOfEventsByUser.TabIndex = 20;
            this.listOfEventsByUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfEventsByUser_CellContentClick);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Location = new System.Drawing.Point(14, 22);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(64, 13);
            this.labelEvents.TabIndex = 10;
            this.labelEvents.Text = "Your events";
            this.labelEvents.Click += new System.EventHandler(this.labelEvents_Click);
            // 
            // labelLoggedInUser
            // 
            this.labelLoggedInUser.AutoSize = true;
            this.labelLoggedInUser.Location = new System.Drawing.Point(600, 252);
            this.labelLoggedInUser.Name = "labelLoggedInUser";
            this.labelLoggedInUser.Size = new System.Drawing.Size(0, 13);
            this.labelLoggedInUser.TabIndex = 8;
            this.labelLoggedInUser.Click += new System.EventHandler(this.labelLoggedInUser_Click);
            // 
            // buttonUpdateInfo
            // 
            this.buttonUpdateInfo.Location = new System.Drawing.Point(471, 398);
            this.buttonUpdateInfo.Name = "buttonUpdateInfo";
            this.buttonUpdateInfo.Size = new System.Drawing.Size(100, 23);
            this.buttonUpdateInfo.TabIndex = 7;
            this.buttonUpdateInfo.Text = "Update your info";
            this.buttonUpdateInfo.UseVisualStyleBackColor = true;
            this.buttonUpdateInfo.Click += new System.EventHandler(this.buttonUpdateInfo_Click);
            // 
            // updateAccountInfo
            // 
            this.updateAccountInfo.AutoSize = true;
            this.updateAccountInfo.Location = new System.Drawing.Point(486, 289);
            this.updateAccountInfo.Name = "updateAccountInfo";
            this.updateAccountInfo.Size = new System.Drawing.Size(161, 13);
            this.updateAccountInfo.TabIndex = 6;
            this.updateAccountInfo.Text = "Update your account information";
            this.updateAccountInfo.Click += new System.EventHandler(this.updateAccountInfo_Click);
            // 
            // tbUpdatePassword
            // 
            this.tbUpdatePassword.Location = new System.Drawing.Point(515, 364);
            this.tbUpdatePassword.Name = "tbUpdatePassword";
            this.tbUpdatePassword.Size = new System.Drawing.Size(100, 20);
            this.tbUpdatePassword.TabIndex = 2;
            this.tbUpdatePassword.TextChanged += new System.EventHandler(this.tbUpdatePassword_TextChanged);
            // 
            // tbUpdateEmail
            // 
            this.tbUpdateEmail.Location = new System.Drawing.Point(515, 338);
            this.tbUpdateEmail.Name = "tbUpdateEmail";
            this.tbUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.tbUpdateEmail.TabIndex = 1;
            this.tbUpdateEmail.TextChanged += new System.EventHandler(this.tbUpdateEmail_TextChanged);
            // 
            // tbUpdatePhoneNumber
            // 
            this.tbUpdatePhoneNumber.Location = new System.Drawing.Point(515, 312);
            this.tbUpdatePhoneNumber.Name = "tbUpdatePhoneNumber";
            this.tbUpdatePhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbUpdatePhoneNumber.TabIndex = 0;
            this.tbUpdatePhoneNumber.TextChanged += new System.EventHandler(this.tbUpdatePhoneNumber_TextChanged);
            // 
            // updateCreateEventPanel
            // 
            this.updateCreateEventPanel.Controls.Add(this.gbUpdateEvent);
            this.updateCreateEventPanel.Controls.Add(this.gbCreateEvent);
            this.updateCreateEventPanel.Controls.Add(this.labelErrorCreateUpdate);
            this.updateCreateEventPanel.Controls.Add(this.buttonBackToUser);
            this.updateCreateEventPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateCreateEventPanel.Location = new System.Drawing.Point(0, 0);
            this.updateCreateEventPanel.Name = "updateCreateEventPanel";
            this.updateCreateEventPanel.Size = new System.Drawing.Size(677, 586);
            this.updateCreateEventPanel.TabIndex = 33;
            // 
            // gbUpdateEvent
            // 
            this.gbUpdateEvent.Controls.Add(this.tbUpdateOpenSlots);
            this.gbUpdateEvent.Controls.Add(this.tbUpdateEventName);
            this.gbUpdateEvent.Controls.Add(this.tbUpdateEventTime);
            this.gbUpdateEvent.Controls.Add(this.tbUpdateLocation);
            this.gbUpdateEvent.Controls.Add(this.labelOpenSlotsUpdate);
            this.gbUpdateEvent.Controls.Add(this.tbUpdateNote);
            this.gbUpdateEvent.Controls.Add(this.labelNoteUpdate);
            this.gbUpdateEvent.Controls.Add(this.buttonUpdate);
            this.gbUpdateEvent.Controls.Add(this.labelLocationUpdate);
            this.gbUpdateEvent.Controls.Add(this.labelEventNameUpdate);
            this.gbUpdateEvent.Controls.Add(this.labelEventTimeUpdate);
            this.gbUpdateEvent.Location = new System.Drawing.Point(348, 16);
            this.gbUpdateEvent.Name = "gbUpdateEvent";
            this.gbUpdateEvent.Size = new System.Drawing.Size(317, 193);
            this.gbUpdateEvent.TabIndex = 58;
            this.gbUpdateEvent.TabStop = false;
            this.gbUpdateEvent.Text = "Update event";
            // 
            // tbUpdateOpenSlots
            // 
            this.tbUpdateOpenSlots.Location = new System.Drawing.Point(89, 128);
            this.tbUpdateOpenSlots.Name = "tbUpdateOpenSlots";
            this.tbUpdateOpenSlots.Size = new System.Drawing.Size(176, 20);
            this.tbUpdateOpenSlots.TabIndex = 38;
            this.tbUpdateOpenSlots.TextChanged += new System.EventHandler(this.tbUpdateOpenSlots_TextChanged);
            // 
            // tbUpdateEventName
            // 
            this.tbUpdateEventName.Location = new System.Drawing.Point(89, 24);
            this.tbUpdateEventName.Name = "tbUpdateEventName";
            this.tbUpdateEventName.Size = new System.Drawing.Size(176, 20);
            this.tbUpdateEventName.TabIndex = 33;
            this.tbUpdateEventName.TextChanged += new System.EventHandler(this.tbUpdateEventName_TextChanged);
            // 
            // tbUpdateEventTime
            // 
            this.tbUpdateEventTime.Location = new System.Drawing.Point(89, 50);
            this.tbUpdateEventTime.Name = "tbUpdateEventTime";
            this.tbUpdateEventTime.Size = new System.Drawing.Size(176, 20);
            this.tbUpdateEventTime.TabIndex = 34;
            this.tbUpdateEventTime.TextChanged += new System.EventHandler(this.tbUpdateEventTime_TextChanged);
            // 
            // tbUpdateLocation
            // 
            this.tbUpdateLocation.Location = new System.Drawing.Point(89, 76);
            this.tbUpdateLocation.Name = "tbUpdateLocation";
            this.tbUpdateLocation.Size = new System.Drawing.Size(176, 20);
            this.tbUpdateLocation.TabIndex = 35;
            this.tbUpdateLocation.TextChanged += new System.EventHandler(this.tbUpdateLocation_TextChanged);
            // 
            // labelOpenSlotsUpdate
            // 
            this.labelOpenSlotsUpdate.AutoSize = true;
            this.labelOpenSlotsUpdate.Location = new System.Drawing.Point(15, 131);
            this.labelOpenSlotsUpdate.Name = "labelOpenSlotsUpdate";
            this.labelOpenSlotsUpdate.Size = new System.Drawing.Size(57, 13);
            this.labelOpenSlotsUpdate.TabIndex = 43;
            this.labelOpenSlotsUpdate.Text = "Open slots";
            // 
            // tbUpdateNote
            // 
            this.tbUpdateNote.Location = new System.Drawing.Point(89, 102);
            this.tbUpdateNote.Name = "tbUpdateNote";
            this.tbUpdateNote.Size = new System.Drawing.Size(176, 20);
            this.tbUpdateNote.TabIndex = 36;
            this.tbUpdateNote.TextChanged += new System.EventHandler(this.tbUpdateNote_TextChanged);
            // 
            // labelNoteUpdate
            // 
            this.labelNoteUpdate.AutoSize = true;
            this.labelNoteUpdate.Location = new System.Drawing.Point(15, 105);
            this.labelNoteUpdate.Name = "labelNoteUpdate";
            this.labelNoteUpdate.Size = new System.Drawing.Size(30, 13);
            this.labelNoteUpdate.TabIndex = 42;
            this.labelNoteUpdate.Text = "Note";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(138, 154);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 23);
            this.buttonUpdate.TabIndex = 37;
            this.buttonUpdate.Text = "Update event";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelLocationUpdate
            // 
            this.labelLocationUpdate.AutoSize = true;
            this.labelLocationUpdate.Location = new System.Drawing.Point(15, 79);
            this.labelLocationUpdate.Name = "labelLocationUpdate";
            this.labelLocationUpdate.Size = new System.Drawing.Size(48, 13);
            this.labelLocationUpdate.TabIndex = 41;
            this.labelLocationUpdate.Text = "Location";
            // 
            // labelEventNameUpdate
            // 
            this.labelEventNameUpdate.AutoSize = true;
            this.labelEventNameUpdate.Location = new System.Drawing.Point(15, 27);
            this.labelEventNameUpdate.Name = "labelEventNameUpdate";
            this.labelEventNameUpdate.Size = new System.Drawing.Size(64, 13);
            this.labelEventNameUpdate.TabIndex = 39;
            this.labelEventNameUpdate.Text = "Event name";
            // 
            // labelEventTimeUpdate
            // 
            this.labelEventTimeUpdate.AutoSize = true;
            this.labelEventTimeUpdate.Location = new System.Drawing.Point(15, 53);
            this.labelEventTimeUpdate.Name = "labelEventTimeUpdate";
            this.labelEventTimeUpdate.Size = new System.Drawing.Size(57, 13);
            this.labelEventTimeUpdate.TabIndex = 40;
            this.labelEventTimeUpdate.Text = "Event time";
            // 
            // gbCreateEvent
            // 
            this.gbCreateEvent.Controls.Add(this.tbOpenSlots);
            this.gbCreateEvent.Controls.Add(this.tbEventName);
            this.gbCreateEvent.Controls.Add(this.labelOpenSlots);
            this.gbCreateEvent.Controls.Add(this.tbEventTime);
            this.gbCreateEvent.Controls.Add(this.labelNote);
            this.gbCreateEvent.Controls.Add(this.tbLocation);
            this.gbCreateEvent.Controls.Add(this.labelLocation);
            this.gbCreateEvent.Controls.Add(this.tbNote);
            this.gbCreateEvent.Controls.Add(this.labelEventTime);
            this.gbCreateEvent.Controls.Add(this.buttonCreateEvent);
            this.gbCreateEvent.Controls.Add(this.labelEventName);
            this.gbCreateEvent.Location = new System.Drawing.Point(12, 16);
            this.gbCreateEvent.Name = "gbCreateEvent";
            this.gbCreateEvent.Size = new System.Drawing.Size(330, 193);
            this.gbCreateEvent.TabIndex = 57;
            this.gbCreateEvent.TabStop = false;
            this.gbCreateEvent.Text = "Create event";
            // 
            // tbOpenSlots
            // 
            this.tbOpenSlots.Location = new System.Drawing.Point(100, 128);
            this.tbOpenSlots.Name = "tbOpenSlots";
            this.tbOpenSlots.Size = new System.Drawing.Size(198, 20);
            this.tbOpenSlots.TabIndex = 50;
            this.tbOpenSlots.TextChanged += new System.EventHandler(this.tbOpenSlots_TextChanged);
            // 
            // tbEventName
            // 
            this.tbEventName.Location = new System.Drawing.Point(100, 24);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(198, 20);
            this.tbEventName.TabIndex = 45;
            this.tbEventName.TextChanged += new System.EventHandler(this.tbEventName_TextChanged);
            // 
            // labelOpenSlots
            // 
            this.labelOpenSlots.AutoSize = true;
            this.labelOpenSlots.Location = new System.Drawing.Point(26, 131);
            this.labelOpenSlots.Name = "labelOpenSlots";
            this.labelOpenSlots.Size = new System.Drawing.Size(57, 13);
            this.labelOpenSlots.TabIndex = 55;
            this.labelOpenSlots.Text = "Open slots";
            // 
            // tbEventTime
            // 
            this.tbEventTime.Location = new System.Drawing.Point(100, 50);
            this.tbEventTime.Name = "tbEventTime";
            this.tbEventTime.Size = new System.Drawing.Size(198, 20);
            this.tbEventTime.TabIndex = 46;
            this.tbEventTime.TextChanged += new System.EventHandler(this.tbEventTime_TextChanged);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(26, 105);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(30, 13);
            this.labelNote.TabIndex = 54;
            this.labelNote.Text = "Note";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(100, 76);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(198, 20);
            this.tbLocation.TabIndex = 47;
            this.tbLocation.TextChanged += new System.EventHandler(this.tbLocation_TextChanged);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(26, 79);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 53;
            this.labelLocation.Text = "Location";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(100, 102);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(198, 20);
            this.tbNote.TabIndex = 48;
            this.tbNote.TextChanged += new System.EventHandler(this.tbNote_TextChanged);
            // 
            // labelEventTime
            // 
            this.labelEventTime.AutoSize = true;
            this.labelEventTime.Location = new System.Drawing.Point(26, 53);
            this.labelEventTime.Name = "labelEventTime";
            this.labelEventTime.Size = new System.Drawing.Size(57, 13);
            this.labelEventTime.TabIndex = 52;
            this.labelEventTime.Text = "Event time";
            // 
            // buttonCreateEvent
            // 
            this.buttonCreateEvent.Location = new System.Drawing.Point(149, 154);
            this.buttonCreateEvent.Name = "buttonCreateEvent";
            this.buttonCreateEvent.Size = new System.Drawing.Size(85, 23);
            this.buttonCreateEvent.TabIndex = 49;
            this.buttonCreateEvent.Text = "Create event";
            this.buttonCreateEvent.UseVisualStyleBackColor = true;
            this.buttonCreateEvent.Click += new System.EventHandler(this.buttonCreateEvent_Click);
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(26, 27);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(64, 13);
            this.labelEventName.TabIndex = 51;
            this.labelEventName.Text = "Event name";
            // 
            // labelErrorCreateUpdate
            // 
            this.labelErrorCreateUpdate.AutoSize = true;
            this.labelErrorCreateUpdate.Location = new System.Drawing.Point(299, 215);
            this.labelErrorCreateUpdate.Name = "labelErrorCreateUpdate";
            this.labelErrorCreateUpdate.Size = new System.Drawing.Size(0, 13);
            this.labelErrorCreateUpdate.TabIndex = 56;
            this.labelErrorCreateUpdate.Click += new System.EventHandler(this.labelErrorCreateUpdate_Click);
            // 
            // buttonBackToUser
            // 
            this.buttonBackToUser.Location = new System.Drawing.Point(301, 220);
            this.buttonBackToUser.Name = "buttonBackToUser";
            this.buttonBackToUser.Size = new System.Drawing.Size(85, 23);
            this.buttonBackToUser.TabIndex = 44;
            this.buttonBackToUser.Text = "Back";
            this.buttonBackToUser.UseVisualStyleBackColor = true;
            this.buttonBackToUser.Click += new System.EventHandler(this.buttonBackToUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 586);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.updateCreateEventPanel);
            this.Name = "MainForm";
            this.Text = "Partycipate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.gbDeleteFromAttendee.ResumeLayout(false);
            this.gbDeleteFromAttendee.PerformLayout();
            this.gbAttendAnEvent.ResumeLayout(false);
            this.gbAttendAnEvent.PerformLayout();
            this.gbToUpdateEvent.ResumeLayout(false);
            this.gbToUpdateEvent.PerformLayout();
            this.gbDeleteAnEvent.ResumeLayout(false);
            this.gbDeleteAnEvent.PerformLayout();
            this.gbUserPanelInfo.ResumeLayout(false);
            this.gbUserPanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfEventsByUser)).EndInit();
            this.updateCreateEventPanel.ResumeLayout(false);
            this.updateCreateEventPanel.PerformLayout();
            this.gbUpdateEvent.ResumeLayout(false);
            this.gbUpdateEvent.PerformLayout();
            this.gbCreateEvent.ResumeLayout(false);
            this.gbCreateEvent.PerformLayout();
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
        private System.Windows.Forms.Label labelCreateUserName;
        private System.Windows.Forms.Label labelCreatePhone;
        private System.Windows.Forms.Label labelCreateEmail;
        private System.Windows.Forms.Label labelCreateName;
        private System.Windows.Forms.Label labelCreatePassword;
        private System.Windows.Forms.Label labelCreateSex;
        private System.Windows.Forms.Label labelCreateAge;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox tbUserNameLogin;
        private System.Windows.Forms.TextBox tbUserPasswordLogin;
        private System.Windows.Forms.Label labelInfoForLogin;
        private System.Windows.Forms.Label labelInfoCreateUser;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.TextBox tbUpdatePassword;
        private System.Windows.Forms.TextBox tbUpdateEmail;
        private System.Windows.Forms.Label updateAccountInfo;
        private System.Windows.Forms.Button buttonUpdateInfo;
        private System.Windows.Forms.Label labelLoginPanelInfo;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.TextBox tbEventId;
        private System.Windows.Forms.Button buttonDeleteEvent;
        private System.Windows.Forms.Button buttonUpdateEvent;
        private System.Windows.Forms.DataGridView listOfEventsByUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSearchEvents;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.Button buttonShowOwnEvents;
        private System.Windows.Forms.Panel updateCreateEventPanel;
        private System.Windows.Forms.Button buttonBackToUser;
        private System.Windows.Forms.Label labelLocationUpdate;
        private System.Windows.Forms.Label labelEventTimeUpdate;
        private System.Windows.Forms.Label labelEventNameUpdate;
        private System.Windows.Forms.TextBox tbUpdateOpenSlots;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox tbUpdateNote;
        private System.Windows.Forms.TextBox tbUpdateLocation;
        private System.Windows.Forms.TextBox tbUpdateEventTime;
        private System.Windows.Forms.TextBox tbUpdateEventName;
        private System.Windows.Forms.Label labelExplanationUpdate;
        private System.Windows.Forms.TextBox tbEventIdForUpdate;
        private System.Windows.Forms.Label labelInfoUserPanel;
        private System.Windows.Forms.Label labelErrorLogin;
        private System.Windows.Forms.Label labelOpenSlots;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.TextBox tbOpenSlots;
        private System.Windows.Forms.Button buttonCreateEvent;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbEventTime;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.Label labelErrorCreateUpdate;
        private System.Windows.Forms.Button buttonToCreateEvent;
        private System.Windows.Forms.GroupBox gbUserPanelInfo;
        private System.Windows.Forms.GroupBox gbUpdateEvent;
        private System.Windows.Forms.GroupBox gbCreateEvent;
        private System.Windows.Forms.GroupBox gbToUpdateEvent;
        private System.Windows.Forms.GroupBox gbDeleteAnEvent;
        private System.Windows.Forms.TextBox tbAttendEvent;
        private System.Windows.Forms.Button buttonAttendEvent;
        private System.Windows.Forms.GroupBox gbDeleteFromAttendee;
        private System.Windows.Forms.TextBox tbUnattend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbAttendAnEvent;
        private System.Windows.Forms.Label labelLoggedInUser;
        private System.Windows.Forms.Label labelOpenSlotsUpdate;
        private System.Windows.Forms.Label labelNoteUpdate;
        private System.Windows.Forms.Label labelPasswordUserUpdate;
        private System.Windows.Forms.Label labelEmailUserUpdate;
        private System.Windows.Forms.Label labelUpdatePhoneNumber;
        private System.Windows.Forms.TextBox tbUpdatePhoneNumber;
    }
}

