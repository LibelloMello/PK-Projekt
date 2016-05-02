using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApplication
{
    public partial class Form : System.Windows.Forms.Form
    {
        Controller c = new Controller();
        public Form()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayData.Text = c.GetUsers();
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            displayData.Text = c.GetEvents();
        }
    }
}
