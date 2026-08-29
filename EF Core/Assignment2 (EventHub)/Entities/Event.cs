using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore2.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaximumAttendees { get; set; }

        //// Foreign key to Organizer entity ( navigation property )
        ///1 to m relationship
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = null!;

        /// 1 to many relationship (between Event and Registrations)
        public ICollection<Registration> Registrations { get; set; } = [];

        //self -referencing relationship for parent-child events
        public int? ParentEventId { get; set; }
        public Event? ParentEvent { get; set; }

        public ICollection<Event> ChildEvents { get; set; } = [];

    }
}
