using Meetings.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meetings.Management.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> Person { get ; set; }
        public DbSet<Level> Level { get ; set; }
        public DbSet<Meeting> Meeting { get; set; }
    }
}
