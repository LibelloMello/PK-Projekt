using Partycipate;
using Partycipate.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Partycipate
{
    public partial class MainForm : Form
    {
        private List<TextBox> textboxes = new List<TextBox>();

        int tryInt;
        private static string loggedInUser;
        public String LoggedInUser
        {
            get
            {
                return loggedInUser;
            }
            set
            {
                loggedInUser = value;
            }
        }

        private void function(object sender, ElapsedEventArgs e)
        {
        }


        public MainForm()
        {

            InitializeComponent();
        }

        private bool _Authenticated = false;

        public bool Authenticated
        {
            get { return _Authenticated; }
            set { _Authenticated = value; }
        }
        public void Login()
        {

            if (Controller.GetLoginAuthentication(tbUserNameLogin.Text, tbUserPasswordLogin.Text))
            {
                Authenticated = true;
                LoggedInUser = tbUserNameLogin.Text;
                loginPanel.Visible = false;
                userPanel.Visible = true;
                listOfEventsByUser.AutoGenerateColumns = true;
                listOfEventsByUser.DataSource = Controller.GetAllEventsByUser(LoggedInUser);
                DataGridViewColumn column = listOfEventsByUser.Columns[0];
                column.Width = 60;
                cbLocations.DataSource = Controller.ShowLocations();

            }
            else
            {
                Authenticated = false;
                labelErrorLogin.Text = "Wrong username or password";
                tbUserNameLogin.Clear();
                tbUserPasswordLogin.Clear();
                tbEventId.Visible = true;

            }

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            if (IsFilled(tbUserName.Text) && IsFilled(tbPhoneNumber.Text) && IsFilled(tbName.Text) && IsFilled(tbEmail.Text) && IsFilled(tbSex.Text) && IsFilled(tbPassword.Text) && IsFilled(tbAge.Text) && int.TryParse(tbAge.Text, out tryInt))
            {
                User u = new User();
                u.UserName = tbUserName.Text;
                u.PhoneNumber = tbPhoneNumber.Text;
                u.Name = tbName.Text;
                u.Email = tbEmail.Text;
                u.Password = tbPassword.Text;
                u.Sex = tbSex.Text;
                u.Age = int.Parse(tbAge.Text);

                if (Controller.CreateUser(tbUserName.Text, tbPhoneNumber.Text, tbName.Text, tbEmail.Text, tbSex.Text, tbPassword.Text, int.Parse(tbAge.Text)))
                {
                    tbUserName.Clear();
                    tbPhoneNumber.Clear();
                    tbName.Clear();
                    tbEmail.Clear();
                    tbSex.Clear();
                    tbPassword.Clear();
                    tbAge.Clear();
                    labelLoginPanelInfo.Text = "User created! Use it to log in";
                }
                else
                {
                    labelLoginPanelInfo.Text = "User was not created, the username and/or email is already taken";
                }
            }
            else
            {
                labelLoginPanelInfo.Text = "Please input correct values into the fields";
            }

        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void tbSex_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbUserNameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUserPasswordLogin_TextChanged(object sender, EventArgs e)
        {
            tbUserPasswordLogin.PasswordChar = '*';

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void labelLoggedInUser_Click(object sender, EventArgs e)
        {
            labelLoggedInUser.Text = LoggedInUser;
        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }
        public static DataTable ToDataTable<Object>(List<Object> items)
        {
            DataTable dataTable = new DataTable(typeof(Object).Name);


            PropertyInfo[] Props = typeof(Object).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {

                dataTable.Columns.Add(prop.Name);
            }
            foreach (Object item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        private void listOfEventsByUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            listOfEventsByUser.AutoGenerateColumns = true;
            //listOfEventsByUser.DataSource = Controller.GetAllEvents();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void buttonUpdateInfo_Click(object sender, EventArgs e)
        {
            if (IsFilled(tbUpdatePhoneNumber.Text) && IsFilled(tbUpdateEmail.Text) && IsFilled(tbUpdatePassword.Text))
            {
                if (Controller.UpdateUser(LoggedInUser, tbUpdatePhoneNumber.Text, tbUpdateEmail.Text, tbUpdatePassword.Text))
                {
                    labelInfoUserPanel.Text = ("Successfully updated your info");
                }
                else
                {
                    labelInfoUserPanel.Text = ("Unable to update your info, try again later");
                }
            }
            else
            {
                labelInfoUserPanel.Text = "Please input values into the fields";
            }
        }

        private void tbUpdatePhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbUpdateEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUpdatePassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoggedInUser = null;
            userPanel.Visible = false;
            updateCreateEventPanel.Visible = false;
            loginPanel.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LoggedInUser);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listOfEventsByUser.DataSource = Controller.GetAllEvents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listOfEventsByUser.AutoGenerateColumns = true;
            listOfEventsByUser.DataSource = Controller.GetAllEvents();
        }

        private void userPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void buttonSearchEvents_Click(object sender, EventArgs e)
        {
            listOfEventsByUser.DataSource = Controller.FindEventsByLocation(cbLocations.Text);
            labelEvents.Text = ("Events for " + cbLocations.Text);

        }

        private void labelEvents_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowOwnEvents_Click(object sender, EventArgs e)
        {
            listOfEventsByUser.AutoGenerateColumns = true;
            listOfEventsByUser.DataSource = Controller.GetAllEventsByUser(LoggedInUser);
            DataGridViewColumn column = listOfEventsByUser.Columns[0];
            column.Width = 60;
            labelEvents.Text = "Your events";
        }


        private void tbEventIdForUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateEvent_Click(object sender, EventArgs e)
        {
            if (IsFilled(tbEventIdForUpdate.Text) && int.TryParse(tbEventIdForUpdate.Text, out tryInt))
                {
                Event eu = Controller.FindEvent(int.Parse(tbEventIdForUpdate.Text));
                tbUpdateEventName.Text = eu.EventName;
                tbUpdateEventTime.Text = eu.EventTime;
                tbUpdateLocation.Text = eu.Location;
                tbUpdateNote.Text = eu.Note;
                tbUpdateOpenSlots.Text = eu.OpenSlots.ToString();
                userPanel.Visible = false;
                updateCreateEventPanel.Visible = true;
            }
            else
            {
                labelInfoUserPanel.Text = "Please insert the ID of the event you want to update";
            }

        }
        private void selectedRowsButton_Click(object sender, System.EventArgs e)
        {
            Int32 selectedRowCount =
                listOfEventsByUser.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(listOfEventsByUser.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");
            }
        }




        //
        //Panel Update Event
        //

        private void buttonBackToUser_Click(object sender, EventArgs e)
        {
            updateCreateEventPanel.Visible = false;
            userPanel.Visible = true;

        }


        private void tbUpdateEventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUpdateEventTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUpdateLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUpdateNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUpdateOpenSlots_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Controller.UpdateEvent(int.Parse(tbEventIdForUpdate.Text), tbUpdateEventName.Text, tbUpdateEventTime.Text, tbUpdateLocation.Text, tbUpdateNote.Text, int.Parse(tbUpdateOpenSlots.Text), LoggedInUser);
            listOfEventsByUser.AutoGenerateColumns = true;
            listOfEventsByUser.DataSource = Controller.GetAllEventsByUser(LoggedInUser);
            DataGridViewColumn column = listOfEventsByUser.Columns[0];
            column.Width = 60;
            cbLocations.DataSource = Controller.ShowLocations();
            labelEvents.Text = "Your events";

            updateCreateEventPanel.Visible = false;
            loginPanel.Visible = false;
            userPanel.Visible = true;

            labelInfoUserPanel.Text = ("You are not the owner of this event or unable to find the event!");

        }

        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {
            if (IsFilled(tbEventId.Text) && int.TryParse(tbEventIdForUpdate.Text, out tryInt))
            {
                if (Controller.DeleteEvent(int.Parse(tbEventId.Text), LoggedInUser))
                {
                    listOfEventsByUser.DataSource = Controller.GetAllEventsByUser(LoggedInUser);
                    DataGridViewColumn column = listOfEventsByUser.Columns[0];
                    column.Width = 60;

                }
                else
                {
                    labelInfoUserPanel.Text = "Error, either the Event was not found or you are not the owner";
                }
            }
            else
            {
                labelInfoUserPanel.Text = "Please fill in the ID of the event you want to delete";
            }
        }

        private void tbEventIdForDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelErrorUserPanel_Click(object sender, EventArgs e)
        {

        }

        private void labelErrorLogin_Click(object sender, EventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private bool IsFilled(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            return true;
        }

        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {

            if (IsFilled(tbEventName.Text) && IsFilled(tbEventTime.Text) && IsFilled(tbLocation.Text) && IsFilled(tbNote.Text) && IsFilled(tbOpenSlots.Text))
            {



                if (Controller.CreateEvent(tbEventName.Text, tbEventTime.Text, tbLocation.Text, tbNote.Text, int.Parse(tbOpenSlots.Text), LoggedInUser))
                {

                    listOfEventsByUser.AutoGenerateColumns = true;
                    listOfEventsByUser.DataSource = Controller.GetAllEventsByUser(LoggedInUser);
                    DataGridViewColumn column = listOfEventsByUser.Columns[0];
                    column.Width = 60;
                    cbLocations.DataSource = Controller.ShowLocations();
                    labelEvents.Text = "Your events";
                    userPanel.Visible = true;
                    updateCreateEventPanel.Visible = false;
                }
                else
                {
                    labelErrorCreateUpdate.Text = "Error; please input values or another event name as it might be taken";
                }
            }
            else
            {
                labelErrorCreateUpdate.Text = "Please fill all the fields";
            }
        }

        private void tbOpenSlots_TextChanged(object sender, EventArgs e)
        {
            textboxes.Add(tbOpenSlots);
        }


        private void tbEventName_TextChanged(object sender, EventArgs e)
        {
            textboxes.Add(tbEventName);
        }

        private void tbEventTime_TextChanged(object sender, EventArgs e)
        {
            textboxes.Add(tbEventTime);
        }

        private void tbLocation_TextChanged(object sender, EventArgs e)
        {
            textboxes.Add(tbLocation);
        }

        private void tbNote_TextChanged(object sender, EventArgs e)
        {
            textboxes.Add(tbNote);
        }

        private void labelErrorCreateUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonToCreateEvent_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            updateCreateEventPanel.Visible = true;
        }

        private void gbToUpdateEvent_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAttendEvent_Click(object sender, EventArgs e)
        {

            if (IsFilled(tbAttendEvent.Text) && int.TryParse(tbAttendEvent.Text, out tryInt) )
            {

                if (Controller.AttendEvent(int.Parse(tbAttendEvent.Text), LoggedInUser))
                {
                    labelInfoUserPanel.Text = "Attended event with ID " + tbAttendEvent.Text;
                }
                else
                {

                }
            }
            else
            {
                labelInfoUserPanel.Text = "Please insert the ID of the event you want to attend to";
            }
        }

        private void tbAttendEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void unattend_Click(object sender, EventArgs e)
        {
 
            if (IsFilled(tbUnattend.Text) && int.TryParse(tbUnattend.Text, out tryInt))
                {

          
            if (Controller.DeleteFromAttendee(int.Parse(tbUnattend.Text), LoggedInUser))
            {
                
            }

            else
            {
                    labelInfoUserPanel.Text = "Please insert a correct value into the field";
            }
            }
            else
            {
                labelInfoUserPanel.Text = "Please insert the ID of the event you want to stop attending to";
            }

        }

        private void tbUnattend_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateAccountInfo_Click(object sender, EventArgs e)
        {

        }
    }

}
