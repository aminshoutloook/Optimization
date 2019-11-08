
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimization.DataLayer.EfClasses.Projects;

namespace Optimization.DataLayer.EfCode.Configurations
{
    class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(ac => ac.Id);

            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.CreatedDate).IsRequired();
            builder.Property(p => p.UpdatedDate).IsRequired();

            builder.ToTable("Project", "Production");

            builder.HasMany(p => p.Pieces).WithOne(p => p.Project).HasForeignKey(p => p.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.Cups).WithOne(p => p.Project).HasForeignKey(p => p.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
