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
            Console.WriteLine("Knappen triggas");
            access.DeleteEvent(int.Parse(tBdelete.Text));
        }

        private void tBdelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateEvent_Click(object sender, EventArgs e)
        {
            Event e1 = new Event();
            e1.EventId = int.Parse(tBeventId.Text);
            e1.EventName = tBeventName.Text;
            e1.EventTime = tBeventTime.Text;
            e1.Location = tBlocation.Text;
            e1.Note = tBnote.Text;
            e1.OpenSlots = int.Parse(tBopenSlots.Text);

            access.UpdateEvent(int.Parse(tBeventId.Text), tBeventName.Text, tBeventTime.Text, tBlocation.Text, tBnote.Text, int.Parse(tBopenSlots.Text));
        }

        private void tBeventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBeventTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBlocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBnote_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBopenSlots_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBeventId_TextChanged(object sender, EventArgs e)
        {

        }

        private void EventLocationButton_Click(object sender, EventArgs e)
        {
           // access.findEventsByLocation(tBfindEventByLocation.Text)

        }

        private void tBfindEventByLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBdisplayEvent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
