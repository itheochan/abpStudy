using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Theo.ModuleTemplate.EntityFrameworkCore
{
    public class ModuleTemplateMigrationsDbContextFactory : IDesignTimeDbContextFactory<ModuleTemplateDbContext>
    {
        public ModuleTemplateDbContext CreateDbContext(string[] args)
        {
            ModuleTemplateDbContextEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();
            var builder = new DbContextOptionsBuilder<ModuleTemplateDbContext>()
                .UseSqlServer(configuration.GetConnectionString("ModuleTemplate"),
                    b => b.MigrationsAssembly(this.GetType().Assembly.GetName().Name));

            return new ModuleTemplateDbContext(builder.Options);

        }

        private static IConfigurationRoot BuildConfiguration()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile("appsettings.secrets.json", optional: false);
            return builder.Build();
        }
    }
}
