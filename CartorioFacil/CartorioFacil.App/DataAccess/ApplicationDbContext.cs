using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CartorioFacil.App.Entities;

namespace CartorioFacil.App.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(nameOrConnectionString: "default") { }

        public DbSet<Casamento> Casamentos { get; set; }
        public DbSet<Nascimento> Nascimentos { get; set; }
        public DbSet<Obito> Obitos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
