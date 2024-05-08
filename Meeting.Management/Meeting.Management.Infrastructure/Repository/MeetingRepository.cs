using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Context;
using Meetings.Management.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Meetings.Management.Infrastructure.Repository
{
    public class MeetingRepository : IMeetingRepository
    {
        private readonly AppDbContext _dbContext;

        public MeetingRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Meeting meeting)
        {
            await _dbContext.Meeting.AddAsync(meeting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Meeting>> GetAll()
        {
            return await _dbContext.Meeting.ToListAsync();
        }

        public async Task<Meeting> GetById(Guid id)
        {
            var query = from u in _dbContext.Meeting
                        where u.Id.Equals(id)
                        select u;

            return await query.FirstAsync();
        }

        public async Task DeleteAsync(Meeting meeting)
        {
            _dbContext.Meeting.Remove(meeting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Meeting meeting)
        {
            _dbContext.Entry(meeting).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }



    }
}
