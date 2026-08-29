using EFCore2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore2.Configurations
{
    internal class PublicFacingProfileConfiguration :
    IEntityTypeConfiguration<PublicFacingProfile>
    {
        public void Configure(EntityTypeBuilder<PublicFacingProfile> builder)
        {
            // one to one relationship between Organizer and PublicFacingProfile
            builder
                .HasOne(p => p.Organizer) 
                .WithOne(o => o.PublicFacingProfile)
                .HasForeignKey<PublicFacingProfile>(p => p.OrganizerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasIndex(p => p.OrganizerId)
                .IsUnique();


        }
    }
}
