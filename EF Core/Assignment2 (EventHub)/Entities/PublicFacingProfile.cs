using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore2.Entities
{
    public class PublicFacingProfile
    {
        public int Id { get; set; }
        public string Biography { get; set; } = null!;
        public string Website { get; set; } = null!;
        public string Logo { get; set; } = null!;

        // Foreign key ( navigation property )
        // one to one relationship between Organizer and PublicFacingProfile
        public int OrganizerId { get; set; } 
        public Organizer Organizer { get; set; } = null!;


    }
}
