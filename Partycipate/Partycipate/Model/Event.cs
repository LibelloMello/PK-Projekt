using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    public class Event
    {
        private int eventId;
        private String location;
        private string eventTime;
        private int openSlots;
        private String note;
        private User owner;
        private List<EventAttendee> eventAttendees;

        public int EventId
        {
            get
            {
                return eventId;
            }

            set
            {
                eventId = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public string EventTime
        {
            get
            {
                return eventTime;
            }

            set
            {
                eventTime = value;
            }
        }

        public int OpenSlots
        {
            get
            {
                return openSlots;
            }

            set
            {
                openSlots = value;
            }
        }

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public User Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value;
            }
        }
        public List<EventAttendee> EventAttendees
        {
            get { return eventAttendees; }
        }
    }
}
