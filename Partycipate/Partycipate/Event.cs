using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    class Event
    {
        private int eventId { get; set; }
        private String location { get; set; }
        private double eventTime { get; set; }
        private int zipCode { get; set; }
        private int openSlots { get; set; }
        private String note { get; set; }
        private User owner;
        private List<EventAttendee> eventAttendees;

    }
}
