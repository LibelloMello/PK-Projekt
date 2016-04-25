using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    public class Event
    {
        public Event() { }
        public Event(int eventId, string location, double eventTime, int openSlots, string note)
        {
            eventId = this.eventId;
            location = this.location;
            eventTime = this.eventTime;
            openSlots = this.openSlots;
            note = this.note;
        }
        public int eventId { get; set; }
        public String location { get; set; }
        public double eventTime { get; set; }
        public int openSlots { get; set; }
        public String note { get; set; }
        public User owner;
        public List<EventAttendee> eventAttendees;

    }
}
