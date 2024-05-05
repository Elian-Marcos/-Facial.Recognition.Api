using Meeting.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meeting.Management.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> User { get ; set; }
    }
}
