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
        private void timer()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(function);
            // check every 1 minuut
            timer.Interval = 60000;
            timer.Enabled = true;
            timer.Start();
            Refresh();
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
            string bajs = tbUserNameLogin.Text;
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
            cbLocations.InitializeLifetimeService();
            cbLocations.Items.Add("Lund");
            cbLocations.Items.Add("Malmö");
            cbLocations.Items.Add("Borås");
            cbLocations.Items.Add("Stockholm");
            cbLocations.Refresh();

        }
     
    }

}
