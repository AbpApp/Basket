using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Abp.Module.Basket.EntityFrameworkCore
{
    public class BasketHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<BasketHttpApiHostMigrationsDbContext>
    {
        public BasketHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BasketHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Basket"));

            return new BasketHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
