using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        Controller c = new Controller();
        public Form()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            displayFile.Text = c.ReadFile(fileName.Text);
        }
    }
}
