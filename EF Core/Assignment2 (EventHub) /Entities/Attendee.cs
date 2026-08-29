using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCore2.Entities
{
    public class Attendee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;

        [Required]
        public string Country { get; set; } = null!;
        public string PostalCode { get; set; } = null!;

        // navigation property 
        // one to one relationship between Attendee and Badge
        public Badge? Badge { get; set; } = null!; // null cause can be zero or one badge for attendee

        // 1 to many relationship (between Attendee and Registration)
        public ICollection<Registration> Registrations { get; set; } = [];

    }
}
