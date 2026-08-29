using EFCore2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore2.Configurations
{
    internal class BadgeConfiguration :
    IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            // define the primary key for the Badge entity
            builder
                .HasKey(b => b.Number);

            // one to one relationship between Attendee and Badge
            builder
                .HasOne(b => b.Attendee)
                .WithOne(a => a.Badge)
                .HasForeignKey<Badge>(b => b.AttendeeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasIndex(b => b.AttendeeId)
                .IsUnique();


        }
    }
}
