using Microsoft.EntityFrameworkCore;
using SmartWallet.Web.Data.Configurations;
using SmartWallet.Web.Data.Entities;

namespace SmartWallet.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomerConfiguration.Build(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
