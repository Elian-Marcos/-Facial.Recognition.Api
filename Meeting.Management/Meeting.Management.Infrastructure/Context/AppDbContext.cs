using Meeting.Management.Domain.Entities;
using Meeting.Management.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Meeting.Management.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> Person { get ; set; }
        public DbSet<Level> Level { get ; set; }
    }
}
