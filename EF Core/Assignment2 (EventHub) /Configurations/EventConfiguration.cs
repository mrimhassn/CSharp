using EFCore2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore2.Configurations;
public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        //configure the primary key relationship for the Event entity
        // one to many relationship between Organizer and Event
        builder
            .HasOne(e => e.Organizer)
            .WithMany(o => o.Events)
            .HasForeignKey(e => e.OrganizerId)
            .IsRequired();

        //configure the self-referencing relationship for parent and child events
        builder
            .HasOne(e => e.ParentEvent)
            .WithMany(e => e.ChildEvents)
            .HasForeignKey(e => e.ParentEventId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
