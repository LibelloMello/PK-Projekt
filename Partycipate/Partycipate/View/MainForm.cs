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
                labelError.Text = "Wrong username or password";
                tbUserNameLogin.Clear();
                tbUserPasswordLogin.Clear();

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

            User u = new User();
            u.UserName = tbUserName.Text;
            u.PhoneNumber = tbPhoneNumber.Text;
            u.Name = tbName.Text;
            u.Email = tbEmail.Text;
            u.Password = tbPassword.Text;
            u.Sex = tbSex.Text;
            u.Age = int.Parse(tbAge.Text);

            Controller.CreateUser(tbUserName.Text, int.Parse(tbAge.Text), tbName.Text, tbEmail.Text, tbPassword.Text, tbPhoneNumber.Text, tbSex.Text);
            //Controller.CreateUser(u);
            
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

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toTestForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authenticated = true;
            TestForm tform = new TestForm();
            tform.ShowDialog();
        }

        private void buttonUpdateInfo_Click(object sender, EventArgs e)
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
            /*
            //listOfEventsByUser.DataSource = ToDataTable(Controller.FindEventsByUser(LoggedInUser));
            DataTable dataTable = new DataTable();
            dataTable.Load(Controller.GetAllEventsForUser(LoggedInUser));
            listOfEventsByUser.AutoGenerateColumns = true;
            listOfEventsByUser.DataSource = dataTable;
            listOfEventsByUser.Refresh();
            //listOfEventsByUser.DataBind();*/

            listOfEventsByUser.AutoGenerateColumns = true;
            listOfEventsByUser.DataSource = Controller.GetAllEvents();
           // listOfEventsByUser.DataSource = ds.Tables[0];



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbUpdateAge_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoggedInUser = null;
            userPanel.Visible = false;
            updateEventPanel.Visible = false;
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



        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {
            Controller.CreateEvent(tbEventName.Text, tbEventTime.Text, tbLocation.Text, tbNote.Text, int.Parse(tbOpenSlots.Text), LoggedInUser);
            listOfEventsByUser.AutoGenerateColumns = true;
            listOfEventsByUser.DataSource = Controller.GetAllEventsByUser(LoggedInUser);
            DataGridViewColumn column = listOfEventsByUser.Columns[0];
            column.Width = 60;
            cbLocations.DataSource = Controller.ShowLocations();
            labelEvents.Text = "Your events";

        }
        private void tbEventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEventTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLocation_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbOpenSlots_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNote_TextChanged(object sender, EventArgs e)
        {

        }


        private void tbUpdateEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUpdatePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUpdatePhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbEventIdForUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateEvent_Click(object sender, EventArgs e)
        {
            Event eu = Controller.FindEvent(int.Parse(tbEventIdForUpdate.Text));
            tbUpdateEventName.Text = eu.EventName;
            tbUpdateEventTime.Text = eu.EventTime;
            tbUpdateLocation.Text = eu.Location;
            tbUpdateNote.Text = eu.Note;
            tbUpdateOpenSlots.Text = eu.OpenSlots.ToString();
            userPanel.Visible = false;
            updateEventPanel.Visible = true;
 
        }



        //
        //Panel Update Event
        //

        private void buttonBackToUser_Click(object sender, EventArgs e)
        {
            updateEventPanel.Visible = false;
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
            Controller.UpdateEvent(int.Parse(tbEventIdForUpdate.Text),tbUpdateEventName.Text, tbUpdateEventTime.Text, tbUpdateLocation.Text, tbUpdateNote.Text, int.Parse(tbUpdateOpenSlots.Text));
        }
    }

}
