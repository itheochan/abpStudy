/*
 * using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Theo.ModuleTemplate.EntityFrameworkCore;

public class ModuleTemplateHttpApiHostMigrationsDbContext : AbpDbContext<ModuleTemplateHttpApiHostMigrationsDbContext>
{
    public ModuleTemplateHttpApiHostMigrationsDbContext(DbContextOptions<ModuleTemplateHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureModuleTemplate();
    }
}

*/