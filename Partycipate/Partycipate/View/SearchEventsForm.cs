using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partycipate
{
    public partial class SearchEventsForm : Form
    {
        public SearchEventsForm()
        {
            InitializeComponent();
        }

        private void eventTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEventLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEventLocations.Items.Clear();
            cbEventLocations.Items.Add("Lund");
            cbEventLocations.Items.Add("Malmö");
        }
    }
}
