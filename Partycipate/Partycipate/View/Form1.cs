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
    }
}
