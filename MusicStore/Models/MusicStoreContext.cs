using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Models
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext(DbContextOptions<MusicStoreContext> options) : base(options) { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
