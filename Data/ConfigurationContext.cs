using ASPNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCore.Data
{
    public class ConfigurationContext : DbContext
    { 
        public ConfigurationContext(DbContextOptions options) : base(options) 
        {

        }       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Configuration>().ToTable("configs").HasKey(x => x.Id);
            modelBuilder.Entity<Configuration>().Property(x => x.Id).IsRequired().HasColumnName("id");
            modelBuilder.Entity<Configuration>().Property(x => x.Name).HasColumnName("name");
        }

        public DbSet<Configuration> Configurations {get;set;}
    }
}