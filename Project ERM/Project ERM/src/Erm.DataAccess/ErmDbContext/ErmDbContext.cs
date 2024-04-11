using Project_ERM.Erm.DataAccess.Configurations;

namespace Project_ERM.Erm.DataAccess.ErmDbContext
{
    public sealed class ErmDbContext : DbContext
    {
        private const string ConnectionString = "Server=BAKHACOMP;Database=ErmDb;Trusted_Connection=True;";

        //#nullable disable - этим способом можно выключить nullable в определенных местах а не во всем проекте
        public DbSet<BusinessProcess> BusinessProcesses { get; set; } =  null!; /*=> Set<BusinessProcess>(); этот метод используется если ругается анализатор*/

        public DbSet<RiskProfile> RiskProfiles { get; set; } = null!;
        //#nullable enable -- и надо обязательно включать обратно
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(ConnectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BusinessProcessConfiguration());
            modelBuilder.ApplyConfiguration(new RiskProfileConfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // если у нас в конфигурации будет много конфигураций, то мы можем использовать этот метод, и этот метод будет читать сборку которую мы передаем во входной параметр и находить все классы которые наследуются от интерфейса IEntityTypeConfiguration и каждый класс применять в конфигурации
            // typeof(BusinessProcessConfiguration).Assembly;
        }
    }
}