using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore2.Entities
{
    public class Registration
    {
        // new table for many to many relationship between Event and Attendee
        // foreign key to Event entity ( navigation property )
        public int EventId { get; set; }
        public Event Event { get; set; } = null!;

        // foreign key to Attendee entity ( navigation property )
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;

        // Optional note left by the attendee
        public string? Note { get; set; }

        // Exact date and time when registration was completed
        public DateTime RegistrationDateTime { get; set; }
    }
}
