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
        UserAccess access = new UserAccess();
        public Form1()
        {

            InitializeComponent();
        }

        private void cbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listOfEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void tbSearchStudentInput_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void btSearchUser_Click(object sender, EventArgs e)
        {
            
           User u = access.FindUser(tbSearchStudentInput.Text);
            MessageBox.Show(u.UserName);




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
       
            access.CreateUser(tbUserName.Text, int.Parse(tbAge.Text), tbName.Text, tbEmail.Text, tbPassword.Text, tbPhoneNumber.Text, tbSex.Text);
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
    }
}
