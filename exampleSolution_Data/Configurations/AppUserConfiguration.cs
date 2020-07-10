using exampleSolution_Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace exampleSolution_Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");

            builder.HasKey(x=>x.UserId);

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Dob).IsRequired();
        }
    }
}
