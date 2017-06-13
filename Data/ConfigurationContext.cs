using ASPNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCore.Data
{
    public class ConfigurationContext : DbContext
    {
        public ConfigurationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ConfigurationValue> Values {get;set;}
    }
}