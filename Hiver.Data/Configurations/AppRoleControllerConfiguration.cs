using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Configurations
{
    public class AppRoleControllerConfiguration : IEntityTypeConfiguration<AppRoleController>
    {
        public void Configure(EntityTypeBuilder<AppRoleController> builder)
        {
            builder.ToTable("AppRoleControllers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Description).HasMaxLength(200);

            builder.Property(x => x.Controller).IsRequired();
            builder.Property(x => x.Action).IsRequired();
            builder.Property(x => x.AppUser).IsRequired();

        }
    }
}
