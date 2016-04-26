using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Partycipate;

namespace Partycipate.View
{
    public partial class TestForm : Form
    {
        EventAccess access = new EventAccess();
        public TestForm()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            access.DeleteEvent(int.Parse(tBdelete.Text));
        }

        private void tBdelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
