using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DbConfigurations;

public class UserClassesConfig : IEntityTypeConfiguration<UserClass>
{
    public void Configure(EntityTypeBuilder<UserClass> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasIndex(x => new { x.UserId, x.classesId });

        builder
            .HasOne(x => x.ApplicationUser)
            .WithMany(x => x.UserClasses)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(x => x.Class)
            .WithMany(x => x.UserClasses)
            .HasForeignKey(x => x.classesId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}