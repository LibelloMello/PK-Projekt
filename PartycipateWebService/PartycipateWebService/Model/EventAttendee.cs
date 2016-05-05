using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartycipateWebService
{
    public class EventAttendee
    {
        /* Constructors start */
        public EventAttendee() { }
        public EventAttendee(int amount, Event party, User user, String eventId, String userId)
        {   
            this.eventId = eventId;
            this.userId = userId;
        }
        /* Constructors end */

        /* Members start */
       
        private String eventId;
        private String userId;
        /* Members end */

        /* Properties start */
        
        public String EventId
        {
            get { return eventId; }
            set { this.eventId = value; }
        }
        public String UserId
        {
            get { return userId; }
            set { this.userId = value; }
        }
        /* Properties end */
    }

}
