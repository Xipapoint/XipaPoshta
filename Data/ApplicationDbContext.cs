using Microsoft.EntityFrameworkCore;
using Xipa_Poshta.Model;
using Xipa_Poshta.Utils;

namespace Xipa_Poshta.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        DbSet<User> Users { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Transaction>  Transactions { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Product>  Products { get; set; }
        DbSet<PaymentInfo> PaymetnInfo { get; set; }
        DbSet<PostOffice> PostOffices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
           .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);


            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(15);
                
        }




    }
}
