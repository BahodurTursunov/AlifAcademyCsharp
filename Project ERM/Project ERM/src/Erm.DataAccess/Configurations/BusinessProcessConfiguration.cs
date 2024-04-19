using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project_ERM.Erm.DataAccess.Configurations
{
    public sealed class BusinessProcessConfiguration : IEntityTypeConfiguration<BusinessProcess>
    {
        public void Configure(EntityTypeBuilder<BusinessProcess> builder)
        {
            builder.ToTable("business_process");

            builder
            .Property(bp => bp.Id)
            .HasColumnName("Id")
            .IsRequired();

            builder
            .Property(bp => bp.Name)
            .HasColumnName("Name")
            .HasColumnType("VARCHAR(50)")
            .IsRequired();

            builder
            .Property(bp => bp.Domain)
            .HasColumnName("Domain")
            .HasColumnType("VARCHAR(50)")
            .IsRequired();

            builder
            .HasMany(bp => bp.RiskProfiles)
            .WithOne(bp => bp.BusinessProcess)
            .HasForeignKey(fk => fk.BusinessProcessId)
            .IsRequired();

            builder.HasKey(k => k.Id);
        }
    }
}