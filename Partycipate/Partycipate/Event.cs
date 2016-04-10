using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    class Event
    {
        private int eventId;
        private String location;
        private double eventTime;
        private int zipCode;
        private int openSlots;
        private String note;
        private User owner;
        private Set<EventAttendee> eventAttendees;
    }
}
