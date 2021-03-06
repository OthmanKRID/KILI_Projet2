using Kili.Models.Dons;
using Kili.Models.General;
using Microsoft.EntityFrameworkCore;

namespace Kili.Models
{
    public class BddContext : DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Association> Associations { get; set; }
        public DbSet<Donateur> Donateurs { get; set; }
        public DbSet<Don> Dons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=P@ssw0rd5;database=Kili");
        }

        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            UserAccount_Services userAccountServices = new UserAccount_Services();

            userAccountServices.CreerAdmin("Admin", "Admin", "Kili@mail.com");
            userAccountServices.CreerUserAccount("Fara", "P@ssFara1", "Fara@gmail.com", TypeRole.Utilisateur);
            userAccountServices.CreerUserAccount("Romy", "P@ssRomy1", "Romy@gmail.com", TypeRole.Utilisateur);
            userAccountServices.CreerUserAccount("Othman", "P@ssOthman1", "Othman@gmail.com", TypeRole.Utilisateur);
            userAccountServices.DesactiverUserAccount(1);

            this.SaveChanges();

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>()
                .HasIndex(p => p.PersonneID)
                .IsUnique();

            modelBuilder.Entity<Abonnement>()
                .HasIndex(p => p.AssociationId)
                .IsUnique();
        }

        public void DeleteCreateDatabase()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

    }

}

