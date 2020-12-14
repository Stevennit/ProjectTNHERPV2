using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menus");

            builder.HasKey(x => x.MenuID);
            builder.Property(x => x.MenuID).UseIdentityColumn();

            builder.Property(x => x.MenuName).HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Url).HasMaxLength(200);
            builder.Property(x => x.IconClass).HasMaxLength(50);
        }
    }
}
