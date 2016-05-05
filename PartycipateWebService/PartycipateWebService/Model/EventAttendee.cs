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
            this.amount = amount;
            this.party = party;
            this.user = user;
            this.eventId = eventId;
            this.userId = userId;
        }
        /* Constructors end */

        /* Members start */
        public bool isInitialized;
        private int amount;
        private Event party;
        private User user;
        private String eventId;
        private String userId;
        /* Members end */

        /* Properties start */
        public int Amount
        {
            get { return amount; }
            set { this.amount = value; }
        }
        public Event Party
        {
            get { return party; }
            set { this.party = value; }
        }
        public User User
        {
            get { return user; }
            set { this.user = value; }
        }
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
