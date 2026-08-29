using System;
using System.Collections.Generic;
using System.Text;
using EFCore2.Enums;

namespace EFCore2.Entities
{
    public class Badge
    {
        public int Number { get; set; }
        public DateTime IssuedDate { get; set; }
        public BadgeType Tier { get; set; }

        //  navigation property  (one to one relationship between Attendee and Badge)
        public int AttendeeId { get; set; } 
        public Attendee Attendee { get; set; } = null!;
    }
}
