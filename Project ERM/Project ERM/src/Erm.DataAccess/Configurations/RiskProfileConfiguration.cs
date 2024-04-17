using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project_ERM.Erm.DataAccess.Configurations
{
    public sealed class RiskProfileConfiguration : IEntityTypeConfiguration<RiskProfile>
    {
        public void Configure(EntityTypeBuilder<RiskProfile> builder)
        {
            builder.ToTable("RiskProfile");

            builder
                .Property(p => p.Id)// здесь к определенному свойсву мы можем ->
                .HasColumnName("Id")// задать имя
                .IsRequired();

            builder
               .Property(p => p.RiskName)
               .HasColumnName("Name")
               .HasColumnType("NVARCHAR(50)")
               .IsRequired();

            builder
               .Property(p => p.Description)
               .HasColumnName("Description")
               .HasColumnType("NVARCHAR(500)")
               .IsRequired();

            builder
             .Property(p => p.OccurrenceProbability)
             .HasColumnName("OccurrenceProbability")
             .HasColumnType("INTEGER)")
             .IsRequired();

            builder
             .Property(p => p.PotentialBusinessImpact)
             .HasColumnName("PotentialBusinessImpact")
             .HasColumnType("INTEGER)")
             .IsRequired();

            builder
             .Property(p => p.PotentialSolution)
             .HasColumnName("PotentialSolution")
             .HasColumnType("NVARCHAR(100)");

            builder
                .HasOne(p => p.BusinessProcess)
                .WithMany(p => p.RiskProfiles)
                .HasForeignKey(fk => fk.BusinessProcessId)
                .IsRequired();

            builder.HasKey(k => k.Id);
        }
    }
}