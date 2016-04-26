using Partycipate;
using Partycipate.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partycipate
{
    public partial class Form1 : Form
    {
        private static string loggedInUser = null;
        UserAccess access = new UserAccess();
        public Form1()
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

            if (access.GetLoginAuthentication(tbUserNameLogin.Text, tbUserPasswordLogin.Text))
            {
                Authenticated = true;
                loggedInUser = tbUserNameLogin.Text;
                loginPanel.Visible = false;
                userPanel.Visible = true;


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

            //access.CreateUser(tbUserName.Text, int.Parse(tbAge.Text), tbName.Text, tbEmail.Text, tbPassword.Text, tbPhoneNumber.Text, tbSex.Text);
            // access.CreateUser(u);
            MessageBox.Show("Hej");
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
            labelLoggedInUser.Text = loggedInUser;
        }

        private void labelError_Click(object sender, EventArgs e)
        {
            
        }
    }
}
