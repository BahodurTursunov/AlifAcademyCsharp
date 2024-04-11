using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project_ERM.Erm.DataAccess.Configurations
{
    public sealed class BusinessProcessConfiguration : IEntityTypeConfiguration<BusinessProcess>
    {
        public void Configure(EntityTypeBuilder<BusinessProcess> builder)
        {
            builder.ToTable("BusinessProcess");

            builder
               .Property(p => p.Id)// здесь к определенному свойсву мы можем --
               .HasColumnName("Id")// задать имя
               .IsRequired();

            builder
               .Property(p => p.Name)
               .HasColumnName("Name")
               .HasColumnType("NVARCHAR(50)")
               .IsRequired();

            builder
               .Property(p => p.Domain)
               .HasColumnName("Domain")
               .HasColumnType("NVARCHAR(50)")
               .IsRequired();

            builder
                .HasMany(p => p.RiskProfiles)
                .WithOne(p => p.BusinessProcess)
                .HasForeignKey(fk => fk.BusinessProcessId)
                .IsRequired();

            builder.HasKey(k => k.Id);
        }
    }
}
