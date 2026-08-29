using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCore2.Entities
{
    public class Organizer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        public string? NameOfCompany { get; set; }
        public  bool IsVerified { get; set; }

        //  navigation property 
        // one to one relationship between Organizer and PublicFacingProfile
        public PublicFacingProfile PublicFacingProfile { get; set; } = null!;

        // 1 to many relationship (between organizer and Event)
        public ICollection<Event> Events { get; set; } = [];

    }
}
