using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partycipate.View
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trappaDataSet.PARTY' table. You can move, or remove it, as needed.
            this.pARTYTableAdapter.Fill(this.trappaDataSet.PARTY);
           
        }

        private void fillByLocationToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pARTYTableAdapter.FillByLocation(this.trappaDataSet.PARTY, toolStripComboBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByLocationToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
            toolStripComboBox1.Items.Add("Lund");
            toolStripComboBox1.Items.Add("Malmö");
            
        }

        private void locationToolStripTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
