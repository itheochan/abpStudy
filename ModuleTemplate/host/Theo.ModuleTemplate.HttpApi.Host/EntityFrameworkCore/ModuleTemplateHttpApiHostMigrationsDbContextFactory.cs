/*
 * using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Theo.ModuleTemplate.EntityFrameworkCore;

public class ModuleTemplateHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ModuleTemplateHttpApiHostMigrationsDbContext>
{
    public ModuleTemplateHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ModuleTemplateHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("ModuleTemplate"));

        return new ModuleTemplateHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile("appsettings.secrets.json", optional: false);

        return builder.Build();
    }
}

*/