using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Context;
using Meetings.Management.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Meetings.Management.Infrastructure.Repository
{
    public class PersonLevelsRepository : IPersonLevelsRepository
    {
        private readonly AppDbContext _dbContext;

        public PersonLevelsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Level level)
        {
            await _dbContext.Level.AddAsync(level);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Level>> GetAll()
        {
            return await _dbContext.Level.ToListAsync();
        }

        public async Task<Level> GetById(Guid id)
        {
            var query = from u in _dbContext.Level
                        where u.Id.Equals(id)
                        select u;

            return await query.FirstAsync();
        }

        public async Task DeleteAsync(Level level)
        {
            _dbContext.Level.Remove(level);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Level level)
        {
            _dbContext.Entry(level).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }



    }
}
