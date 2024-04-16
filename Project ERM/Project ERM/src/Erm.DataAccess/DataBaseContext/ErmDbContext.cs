using System.Reflection;
namespace Project_ERM.Erm.DataAccess.DataBaseContext
{
    public sealed class ErmDbContext(DbContextOptions options) : DbContext(options)
    {
        private const string ConnectionString = "Server=BAKHACOMP;Database=ErmDb;Trusted_Connection=True;TrustServerCertificate=True;";
            
        //#nullable disable - этим способом можно выключить nullable в определенных местах а не во всем проекте
        public DbSet<RiskProfile> RiskProfiles { get; set; }
        public DbSet<BusinessProcess> BusinessProcesses { get; set; } /*=> Set<BusinessProcess>(); этот метод используется если ругается анализатор*/
        //#nullable enable -- и надо обязательно включать обратно
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(ConnectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RiskProfile>()
                .ToTable("RiskProfile");

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

                
            /*//modelBuilder.ApplyConfiguration(new BusinessProcessConfiguration());
            //modelBuilder.ApplyConfiguration(new RiskProfileConfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // если у нас в конфигурации будет много конфигураций, то мы можем использовать этот метод, и этот метод будет читать сборку которую мы передаем во входной параметр и находить все классы которые наследуются от интерфейса IEntityTypeConfiguration и каждый класс применять в конфигурации
            // typeof(BusinessProcessConfiguration).Assembly;*/
        }
    }
}