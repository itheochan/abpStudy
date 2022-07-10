﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Theo.ModuleTemplate.EntityFrameworkCore;

public class IdentityServerHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<IdentityServerHostMigrationsDbContext>
{
    public IdentityServerHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<IdentityServerHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new IdentityServerHostMigrationsDbContext(builder.Options);
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
