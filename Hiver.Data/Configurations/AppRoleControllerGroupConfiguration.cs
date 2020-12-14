using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Configurations
{
    public class AppRoleControllerGroupConfiguration : IEntityTypeConfiguration<AppRoleControllerGroup>
    {
        public void Configure(EntityTypeBuilder<AppRoleControllerGroup> builder)
        {
            builder.ToTable("AppRoleControllerGroups");

            builder.HasKey(x => x.Id);


        }
    }
}
