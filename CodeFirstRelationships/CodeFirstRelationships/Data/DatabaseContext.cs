

using CodeFirstRelationships.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelationships.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<ElectricJob> ElectricJobs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
