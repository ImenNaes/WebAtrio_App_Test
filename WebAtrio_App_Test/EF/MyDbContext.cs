using Microsoft.EntityFrameworkCore;
using WebAtrio_App_Test.Entities;

namespace WebAtrio_App_Test.EF
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {
        }
        public DbSet<Personne> Personnees { get; set; }    
        public DbSet<Emploi> Emplois { get; set; }
        public DbSet<PersonneEmploi> PersonneEmplois { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonneEmploi>()
                  .HasKey(m => new { m.PersonneId, m.EmploiId });
        }
    }
}
