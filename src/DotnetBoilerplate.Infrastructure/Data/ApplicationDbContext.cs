using DotnetBoilerplate.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetBoilerplate.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .Property(e => e.Id).ValueGeneratedOnAdd();
        }

        public DbSet<User> Users { get; set; }
    }
}