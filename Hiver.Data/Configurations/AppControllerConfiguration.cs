using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Configurations
{
    public class AppControllerConfiguration : IEntityTypeConfiguration<AppController>
    {
        public void Configure(EntityTypeBuilder<AppController> builder)
        {
            builder.ToTable("AppControllers");

            builder.HasKey(x => new { x.Controller, x.Action });

            builder.Property(x => x.Description).HasMaxLength(200);

            builder.Property(x => x.Controller).IsRequired();
            builder.Property(x => x.Action).IsRequired();
            builder.Property(x => x.Licensed).IsRequired();



        }
    }
}
