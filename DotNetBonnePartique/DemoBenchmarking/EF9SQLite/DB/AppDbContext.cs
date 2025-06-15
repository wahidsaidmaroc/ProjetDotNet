using Microsoft.EntityFrameworkCore;

namespace EF9SQLite.DB
{


    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients => Set<Client>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                Enumerable.Range(1, 10000).Select(i => new Client { Id = i, Nom = $"Client {i}" , Prenom = $"Client {i}", Email = "contact@zonetolearn.com"})
            );
        }
    }

}
