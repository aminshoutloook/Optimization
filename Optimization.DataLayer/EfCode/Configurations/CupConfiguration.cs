using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimization.DataLayer.EfClasses.Equipment;

namespace Optimization.DataLayer.EfCode.Configurations
{
    public class CupConfiguration : IEntityTypeConfiguration<Cup>
    {
        public void Configure(EntityTypeBuilder<Cup> builder)
        {
            builder.HasKey(ac => ac.Id);

            builder.Property(p => p.Width).IsRequired();
            builder.Property(p => p.Height).IsRequired();
            builder.Property(p => p.CreatedDate).IsRequired();
            builder.Property(p => p.UpdatedDate).IsRequired();

            builder.ToTable("Cup", "Production");
        }
    }
}
