using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClientERP
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void comboBoxOptions(object sender, EventArgs e)
        {
            Choice();
            /* THIS NEEDS TO BE MOVED
            comboBox.Items.Add("All Employees");
            comboBox.Items.Add("All Employees Relatives");
            comboBox.Items.Add("Sick Employees 2004");
            comboBox.Items.Add("Employee With Most Absence");
            comboBox.Items.Add("All Keys");
            comboBox.Items.Add("All Indexes");
            comboBox.Items.Add("All Table Constraints");
            comboBox.Items.Add("All Table Names 1");
            comboBox.Items.Add("All Table Names 2");
            comboBox.Items.Add("All Column Names In Employee 1");
            comboBox.Items.Add("All Column Names In Employee 2");
            comboBox.SelectedIndex = 0;
            */
        }
        private void Choice()
        {
            switch (switch_on)
            {
                default:
            }
        }
    }
}
