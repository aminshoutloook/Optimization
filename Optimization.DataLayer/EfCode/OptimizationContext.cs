using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Optimization.DataLayer.EfClasses;
using Optimization.DataLayer.EfClasses.Equipment;
using Optimization.DataLayer.EfClasses.Projects;
using Optimization.DataLayer.EfCode.Configurations;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Optimization.DataLayer.EfCode
{
    public class OptimizationContext : DbContext
    {
        public OptimizationContext(
          DbContextOptions<OptimizationContext> options)
          : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Cup> Cups { get; set; }
        public DbSet<Piece> Pieces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new CupConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => e.State ==
            EntityState.Added || e.State == EntityState.Modified))
            {
                if (entry.Entity is IAuditTracker)
                {
                    if (entry.State == EntityState.Added)
                    {
                        entry.Property("CreatedDate").CurrentValue = DateTime.Now;
                        entry.Property("UpdatedDate").CurrentValue = DateTime.Now;
                    }
                    else
                    {
                        entry.Property("UpdatedDate").CurrentValue = DateTime.Now;
                    }
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => e.State ==
            EntityState.Added || e.State == EntityState.Modified))
            {
                if (entry.Entity is IAuditTracker)
                {
                    if (entry.State == EntityState.Added)
                    {
                        entry.Property("CreatedDate").CurrentValue = DateTime.Now;
                        entry.Property("UpdatedDate").CurrentValue = DateTime.Now;
                    }
                    else
                    {
                        entry.Property("UpdatedDate").CurrentValue = DateTime.Now;
                    }
                }
            }

            return base.SaveChanges();
        }
    }

    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<OptimizationContext>
    {
        public OptimizationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OptimizationContext>();
            optionsBuilder.UseSqlServer("Data Source=AminPC;Initial Catalog=Optimization.Apse;User ID=sa;Password=1221056@Am", b => b.MigrationsAssembly("Optimization.DataLayer"));

            return new OptimizationContext(optionsBuilder.Options);
        }

        public static DbContextOptions<OptimizationContext> Get()
        {
            var optionsBuilder = new DbContextOptionsBuilder<OptimizationContext>();
            optionsBuilder.UseSqlServer("Data Source=AminPc;Initial Catalog=Optimization.Apse;User ID=sa;Password=1221056@Am", b => b.MigrationsAssembly("Optimization.DataLayer"));
            return optionsBuilder.Options;
        }
    }
}
