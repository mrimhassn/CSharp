using EFCore2.Entities;
using EFCore2.Configurations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace EFCore2.DbContexts;
    internal class EventHubDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=. ; Database = EventHubdb ; Trusted_Connection = true; TrustServerCertificate = true");
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations from the assembly containing the EventHubDBContext
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(EventHubDBContext).Assembly);

            

        }

        // add DbSet properties for each entity
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<PublicFacingProfile> PublicFacingProfiles { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<Registration> EventAttendees { get; set; }

    }