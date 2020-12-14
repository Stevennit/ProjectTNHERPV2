using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hiver.Data.EF
{
    public class HiverDbContextFactory : IDesignTimeDbContextFactory<HiverDbContext>
    {
        public HiverDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("HiverDbContext");

            var optionsBuilder = new DbContextOptionsBuilder<HiverDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new HiverDbContext(optionsBuilder.Options);
        }
    }
}
