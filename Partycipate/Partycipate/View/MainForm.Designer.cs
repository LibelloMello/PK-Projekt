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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toTestForm = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.labelLoginPanelInfo = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.tbEventIdForUpdate = new System.Windows.Forms.TextBox();
            this.labelExplanationUpdate = new System.Windows.Forms.Label();
            this.labelOpenSlots = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.labelEventName = new System.Windows.Forms.Label();
            this.tbOpenSlots = new System.Windows.Forms.TextBox();
            this.buttonShowOwnEvents = new System.Windows.Forms.Button();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.buttonSearchEvents = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listOfEventsByUser = new System.Windows.Forms.DataGridView();
            this.buttonUpdateEvent = new System.Windows.Forms.Button();
            this.buttonCreateEvent = new System.Windows.Forms.Button();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbEventTime = new System.Windows.Forms.TextBox();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.tbEventId = new System.Windows.Forms.TextBox();
            this.buttonDeleteEvent = new System.Windows.Forms.Button();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelLoggedInUser = new System.Windows.Forms.Label();
            this.buttonUpdateInfo = new System.Windows.Forms.Button();
            this.updateAccountInfo = new System.Windows.Forms.Label();
            this.tbUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.tbUpdatePassword = new System.Windows.Forms.TextBox();
            this.tbUpdateEmail = new System.Windows.Forms.TextBox();
            this.tbUpdateAge = new System.Windows.Forms.TextBox();
            this.updateEventPanel = new System.Windows.Forms.Panel();
            this.buttonBackToUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbUpdateOpenSlots = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tbUpdateNote = new System.Windows.Forms.TextBox();
            this.tbUpdateLocation = new System.Windows.Forms.TextBox();
            this.tbUpdateEventTime = new System.Windows.Forms.TextBox();
            this.tbUpdateEventName = new System.Windows.Forms.TextBox();
            this.labelErrorUserPanel = new System.Windows.Forms.Label();
            this.labelErrorLogin = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.loginPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfEventsByUser)).BeginInit();
            this.updateEventPanel.SuspendLayout();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Please login using your credentials";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Not a member? Join us today!";
            // 
            // toTestForm
            // 
            this.toTestForm.Location = new System.Drawing.Point(30, 135);
            this.toTestForm.Name = "toTestForm";
            this.toTestForm.Size = new System.Drawing.Size(75, 23);
            this.toTestForm.TabIndex = 29;
            this.toTestForm.Text = "Testform";
            this.toTestForm.UseVisualStyleBackColor = true;
            this.toTestForm.Click += new System.EventHandler(this.toTestForm_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.labelErrorLogin);
            this.loginPanel.Controls.Add(this.labelLoginPanelInfo);
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
            this.userPanel.Controls.Add(this.labelErrorUserPanel);
            this.userPanel.Controls.Add(this.tbEventIdForUpdate);
            this.userPanel.Controls.Add(this.labelExplanationUpdate);
            this.userPanel.Controls.Add(this.labelOpenSlots);
            this.userPanel.Controls.Add(this.labelNote);
            this.userPanel.Controls.Add(this.labelLocation);
            this.userPanel.Controls.Add(this.labelEventTime);
            this.userPanel.Controls.Add(this.labelEventName);
            this.userPanel.Controls.Add(this.tbOpenSlots);
            this.userPanel.Controls.Add(this.buttonShowOwnEvents);
            this.userPanel.Controls.Add(this.cbLocations);
            this.userPanel.Controls.Add(this.buttonSearchEvents);
            this.userPanel.Controls.Add(this.buttonLogout);
            this.userPanel.Controls.Add(this.listOfEventsByUser);
            this.userPanel.Controls.Add(this.buttonUpdateEvent);
            this.userPanel.Controls.Add(this.buttonCreateEvent);
            this.userPanel.Controls.Add(this.tbNote);
            this.userPanel.Controls.Add(this.tbLocation);
            this.userPanel.Controls.Add(this.tbEventTime);
            this.userPanel.Controls.Add(this.tbEventName);
            this.userPanel.Controls.Add(this.tbEventId);
            this.userPanel.Controls.Add(this.buttonDeleteEvent);
            this.userPanel.Controls.Add(this.labelEvents);
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
            this.userPanel.Size = new System.Drawing.Size(677, 586);
            this.userPanel.TabIndex = 30;
            this.userPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userPanel_Paint);
            // 
            // tbEventIdForUpdate
            // 
            this.tbEventIdForUpdate.Location = new System.Drawing.Point(88, 494);
            this.tbEventIdForUpdate.Name = "tbEventIdForUpdate";
            this.tbEventIdForUpdate.Size = new System.Drawing.Size(86, 20);
            this.tbEventIdForUpdate.TabIndex = 35;
            this.tbEventIdForUpdate.TextChanged += new System.EventHandler(this.tbEventIdForUpdate_TextChanged);
            // 
            // labelExplanationUpdate
            // 
            this.labelExplanationUpdate.AutoSize = true;
            this.labelExplanationUpdate.Location = new System.Drawing.Point(84, 530);
            this.labelExplanationUpdate.Name = "labelExplanationUpdate";
            this.labelExplanationUpdate.Size = new System.Drawing.Size(248, 13);
            this.labelExplanationUpdate.TabIndex = 34;
            this.labelExplanationUpdate.Text = "Fill in the Event ID of the Event you want to update";
            // 
            // labelOpenSlots
            // 
            this.labelOpenSlots.AutoSize = true;
            this.labelOpenSlots.Location = new System.Drawing.Point(14, 387);
            this.labelOpenSlots.Name = "labelOpenSlots";
            this.labelOpenSlots.Size = new System.Drawing.Size(57, 13);
            this.labelOpenSlots.TabIndex = 32;
            this.labelOpenSlots.Text = "Open slots";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(14, 361);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(30, 13);
            this.labelNote.TabIndex = 31;
            this.labelNote.Text = "Note";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(14, 335);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 30;
            this.labelLocation.Text = "Location";
            // 
            // labelEventTime
            // 
            this.labelEventTime.AutoSize = true;
            this.labelEventTime.Location = new System.Drawing.Point(14, 309);
            this.labelEventTime.Name = "labelEventTime";
            this.labelEventTime.Size = new System.Drawing.Size(57, 13);
            this.labelEventTime.TabIndex = 29;
            this.labelEventTime.Text = "Event time";
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(14, 283);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(64, 13);
            this.labelEventName.TabIndex = 28;
            this.labelEventName.Text = "Event name";
            // 
            // tbOpenSlots
            // 
            this.tbOpenSlots.Location = new System.Drawing.Point(88, 384);
            this.tbOpenSlots.Name = "tbOpenSlots";
            this.tbOpenSlots.Size = new System.Drawing.Size(198, 20);
            this.tbOpenSlots.TabIndex = 27;
            this.tbOpenSlots.TextChanged += new System.EventHandler(this.tbOpenSlots_TextChanged);
            // 
            // buttonShowOwnEvents
            // 
            this.buttonShowOwnEvents.Location = new System.Drawing.Point(522, 241);
            this.buttonShowOwnEvents.Name = "buttonShowOwnEvents";
            this.buttonShowOwnEvents.Size = new System.Drawing.Size(100, 23);
            this.buttonShowOwnEvents.TabIndex = 26;
            this.buttonShowOwnEvents.Text = "Show your events";
            this.buttonShowOwnEvents.UseVisualStyleBackColor = true;
            this.buttonShowOwnEvents.Click += new System.EventHandler(this.buttonShowOwnEvents_Click);
            // 
            // cbLocations
            // 
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(15, 242);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(143, 21);
            this.cbLocations.TabIndex = 24;
            this.cbLocations.SelectedIndexChanged += new System.EventHandler(this.cbLocations_SelectedIndexChanged);
            // 
            // buttonSearchEvents
            // 
            this.buttonSearchEvents.Location = new System.Drawing.Point(168, 241);
            this.buttonSearchEvents.Name = "buttonSearchEvents";
            this.buttonSearchEvents.Size = new System.Drawing.Size(75, 24);
            this.buttonSearchEvents.TabIndex = 23;
            this.buttonSearchEvents.Text = "Search events";
            this.buttonSearchEvents.UseVisualStyleBackColor = true;
            this.buttonSearchEvents.Click += new System.EventHandler(this.buttonSearchEvents_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(537, 12);
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
            this.listOfEventsByUser.Location = new System.Drawing.Point(15, 58);
            this.listOfEventsByUser.Name = "listOfEventsByUser";
            this.listOfEventsByUser.Size = new System.Drawing.Size(607, 173);
            this.listOfEventsByUser.TabIndex = 20;
            this.listOfEventsByUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfEventsByUser_CellContentClick);
            // 
            // buttonUpdateEvent
            // 
            this.buttonUpdateEvent.Location = new System.Drawing.Point(180, 494);
            this.buttonUpdateEvent.Name = "buttonUpdateEvent";
            this.buttonUpdateEvent.Size = new System.Drawing.Size(106, 23);
            this.buttonUpdateEvent.TabIndex = 19;
            this.buttonUpdateEvent.Text = "Update an event";
            this.buttonUpdateEvent.UseVisualStyleBackColor = true;
            this.buttonUpdateEvent.Click += new System.EventHandler(this.buttonUpdateEvent_Click);
            // 
            // buttonCreateEvent
            // 
            this.buttonCreateEvent.Location = new System.Drawing.Point(137, 410);
            this.buttonCreateEvent.Name = "buttonCreateEvent";
            this.buttonCreateEvent.Size = new System.Drawing.Size(85, 23);
            this.buttonCreateEvent.TabIndex = 18;
            this.buttonCreateEvent.Text = "Create event";
            this.buttonCreateEvent.UseVisualStyleBackColor = true;
            this.buttonCreateEvent.Click += new System.EventHandler(this.buttonCreateEvent_Click);
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(88, 358);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(198, 20);
            this.tbNote.TabIndex = 16;
            this.tbNote.TextChanged += new System.EventHandler(this.tbNote_TextChanged);
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(88, 332);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(198, 20);
            this.tbLocation.TabIndex = 15;
            this.tbLocation.TextChanged += new System.EventHandler(this.tbLocation_TextChanged);
            // 
            // tbEventTime
            // 
            this.tbEventTime.Location = new System.Drawing.Point(88, 306);
            this.tbEventTime.Name = "tbEventTime";
            this.tbEventTime.Size = new System.Drawing.Size(198, 20);
            this.tbEventTime.TabIndex = 14;
            this.tbEventTime.TextChanged += new System.EventHandler(this.tbEventTime_TextChanged);
            // 
            // tbEventName
            // 
            this.tbEventName.Location = new System.Drawing.Point(88, 280);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(198, 20);
            this.tbEventName.TabIndex = 13;
            this.tbEventName.TextChanged += new System.EventHandler(this.tbEventName_TextChanged);
            // 
            // tbEventId
            // 
            this.tbEventId.Location = new System.Drawing.Point(88, 439);
            this.tbEventId.Name = "tbEventId";
            this.tbEventId.Size = new System.Drawing.Size(86, 20);
            this.tbEventId.TabIndex = 12;
            this.tbEventId.TextChanged += new System.EventHandler(this.tbEventId_TextChanged);
            // 
            // buttonDeleteEvent
            // 
            this.buttonDeleteEvent.Location = new System.Drawing.Point(180, 438);
            this.buttonDeleteEvent.Name = "buttonDeleteEvent";
            this.buttonDeleteEvent.Size = new System.Drawing.Size(106, 21);
            this.buttonDeleteEvent.TabIndex = 11;
            this.buttonDeleteEvent.Text = "Delete event";
            this.buttonDeleteEvent.UseVisualStyleBackColor = true;
            this.buttonDeleteEvent.Click += new System.EventHandler(this.buttonDeleteEvent_Click);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Location = new System.Drawing.Point(12, 33);
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
            this.buttonUpdateInfo.Location = new System.Drawing.Point(522, 416);
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
            this.updateAccountInfo.Location = new System.Drawing.Point(493, 286);
            this.updateAccountInfo.Name = "updateAccountInfo";
            this.updateAccountInfo.Size = new System.Drawing.Size(161, 13);
            this.updateAccountInfo.TabIndex = 6;
            this.updateAccountInfo.Text = "Update your account information";
            // 
            // tbUpdatePhoneNumber
            // 
            this.tbUpdatePhoneNumber.Location = new System.Drawing.Point(522, 387);
            this.tbUpdatePhoneNumber.Name = "tbUpdatePhoneNumber";
            this.tbUpdatePhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbUpdatePhoneNumber.TabIndex = 4;
            this.tbUpdatePhoneNumber.TextChanged += new System.EventHandler(this.tbUpdatePhoneNumber_TextChanged);
            // 
            // tbUpdatePassword
            // 
            this.tbUpdatePassword.Location = new System.Drawing.Point(522, 361);
            this.tbUpdatePassword.Name = "tbUpdatePassword";
            this.tbUpdatePassword.Size = new System.Drawing.Size(100, 20);
            this.tbUpdatePassword.TabIndex = 2;
            this.tbUpdatePassword.TextChanged += new System.EventHandler(this.tbUpdatePassword_TextChanged);
            // 
            // tbUpdateEmail
            // 
            this.tbUpdateEmail.Location = new System.Drawing.Point(522, 335);
            this.tbUpdateEmail.Name = "tbUpdateEmail";
            this.tbUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.tbUpdateEmail.TabIndex = 1;
            this.tbUpdateEmail.TextChanged += new System.EventHandler(this.tbUpdateEmail_TextChanged);
            // 
            // tbUpdateAge
            // 
            this.tbUpdateAge.Location = new System.Drawing.Point(522, 309);
            this.tbUpdateAge.Name = "tbUpdateAge";
            this.tbUpdateAge.Size = new System.Drawing.Size(100, 20);
            this.tbUpdateAge.TabIndex = 0;
            this.tbUpdateAge.TextChanged += new System.EventHandler(this.tbUpdateAge_TextChanged);
            // 
            // updateEventPanel
            // 
            this.updateEventPanel.Controls.Add(this.buttonBackToUser);
            this.updateEventPanel.Controls.Add(this.label9);
            this.updateEventPanel.Controls.Add(this.label10);
            this.updateEventPanel.Controls.Add(this.label11);
            this.updateEventPanel.Controls.Add(this.label12);
            this.updateEventPanel.Controls.Add(this.label13);
            this.updateEventPanel.Controls.Add(this.tbUpdateOpenSlots);
            this.updateEventPanel.Controls.Add(this.buttonUpdate);
            this.updateEventPanel.Controls.Add(this.tbUpdateNote);
            this.updateEventPanel.Controls.Add(this.tbUpdateLocation);
            this.updateEventPanel.Controls.Add(this.tbUpdateEventTime);
            this.updateEventPanel.Controls.Add(this.tbUpdateEventName);
            this.updateEventPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateEventPanel.Location = new System.Drawing.Point(0, 0);
            this.updateEventPanel.Name = "updateEventPanel";
            this.updateEventPanel.Size = new System.Drawing.Size(677, 586);
            this.updateEventPanel.TabIndex = 33;
            // 
            // buttonBackToUser
            // 
            this.buttonBackToUser.Location = new System.Drawing.Point(288, 306);
            this.buttonBackToUser.Name = "buttonBackToUser";
            this.buttonBackToUser.Size = new System.Drawing.Size(85, 23);
            this.buttonBackToUser.TabIndex = 44;
            this.buttonBackToUser.Text = "Back";
            this.buttonBackToUser.UseVisualStyleBackColor = true;
            this.buttonBackToUser.Click += new System.EventHandler(this.buttonBackToUser_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Open slots";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Note";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Location";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Event time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Event name";
            // 
            // tbUpdateOpenSlots
            // 
            this.tbUpdateOpenSlots.Location = new System.Drawing.Point(239, 186);
            this.tbUpdateOpenSlots.Name = "tbUpdateOpenSlots";
            this.tbUpdateOpenSlots.Size = new System.Drawing.Size(176, 20);
            this.tbUpdateOpenSlots.TabIndex = 38;
            this.tbUpdateOpenSlots.TextChanged += new System.EventHandler(this.tbUpdateOpenSlots_TextChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(288, 212);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 23);
            this.buttonUpdate.TabIndex = 37;
            this.buttonUpdate.Text = "Update event";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tbUpdateNote
            // 
            this.tbUpdateNote.Location = new System.Drawing.Point(239, 160);
            this.tbUpdateNote.Name = "tbUpdateNote";
            this.tbUpdateNote.Size = new System.Drawing.Size(176, 20);
            this.tbUpdateNote.TabIndex = 36;
            this.tbUpdateNote.TextChanged += new System.EventHandler(this.tbUpdateNote_TextChanged);
            // 
            // tbUpdateLocation
            // 
            this.tbUpdateLocation.Location = new System.Drawing.Point(239, 134);
            this.tbUpdateLocation.Name = "tbUpdateLocation";
            this.tbUpdateLocation.Size = new System.Drawing.Size(176, 20);
            this.tbUpdateLocation.TabIndex = 35;
            this.tbUpdateLocation.TextChanged += new System.EventHandler(this.tbUpdateLocation_TextChanged);
            // 
            // tbUpdateEventTime
            // 
            this.tbUpdateEventTime.Location = new System.Drawing.Point(239, 108);
            this.tbUpdateEventTime.Name = "tbUpdateEventTime";
            this.tbUpdateEventTime.Size = new System.Drawing.Size(176, 20);
            this.tbUpdateEventTime.TabIndex = 34;
            this.tbUpdateEventTime.TextChanged += new System.EventHandler(this.tbUpdateEventTime_TextChanged);
            // 
            // tbUpdateEventName
            // 
            this.tbUpdateEventName.Location = new System.Drawing.Point(239, 82);
            this.tbUpdateEventName.Name = "tbUpdateEventName";
            this.tbUpdateEventName.Size = new System.Drawing.Size(176, 20);
            this.tbUpdateEventName.TabIndex = 33;
            this.tbUpdateEventName.TextChanged += new System.EventHandler(this.tbUpdateEventName_TextChanged);
            // 
            // labelErrorUserPanel
            // 
            this.labelErrorUserPanel.AutoSize = true;
            this.labelErrorUserPanel.Location = new System.Drawing.Point(85, 462);
            this.labelErrorUserPanel.Name = "labelErrorUserPanel";
            this.labelErrorUserPanel.Size = new System.Drawing.Size(0, 13);
            this.labelErrorUserPanel.TabIndex = 36;
            this.labelErrorUserPanel.Click += new System.EventHandler(this.labelErrorUserPanel_Click);
            // 
            // labelErrorLogin
            // 
            this.labelErrorLogin.AutoSize = true;
            this.labelErrorLogin.Location = new System.Drawing.Point(105, 193);
            this.labelErrorLogin.Name = "labelErrorLogin";
            this.labelErrorLogin.Size = new System.Drawing.Size(0, 13);
            this.labelErrorLogin.TabIndex = 31;
            this.labelErrorLogin.Click += new System.EventHandler(this.labelErrorLogin_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pexels-photo-27431.jpg");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 586);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.updateEventPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfEventsByUser)).EndInit();
            this.updateEventPanel.ResumeLayout(false);
            this.updateEventPanel.PerformLayout();
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
        private System.Windows.Forms.Label labelLoginPanelInfo;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Button buttonCreateEvent;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbEventTime;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.TextBox tbEventId;
        private System.Windows.Forms.Button buttonDeleteEvent;
        private System.Windows.Forms.Button buttonUpdateEvent;
        private System.Windows.Forms.DataGridView listOfEventsByUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSearchEvents;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.Button buttonShowOwnEvents;
        private System.Windows.Forms.TextBox tbOpenSlots;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelOpenSlots;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Panel updateEventPanel;
        private System.Windows.Forms.Button buttonBackToUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbUpdateOpenSlots;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox tbUpdateNote;
        private System.Windows.Forms.TextBox tbUpdateLocation;
        private System.Windows.Forms.TextBox tbUpdateEventTime;
        private System.Windows.Forms.TextBox tbUpdateEventName;
        private System.Windows.Forms.Label labelExplanationUpdate;
        private System.Windows.Forms.TextBox tbEventIdForUpdate;
        private System.Windows.Forms.Label labelErrorUserPanel;
        private System.Windows.Forms.Label labelErrorLogin;
        private System.Windows.Forms.ImageList imageList1;
    }
}

