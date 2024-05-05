using Meeting.Management.Domain.Entities;
using Meeting.Management.Infrastructure.Context;
using Meeting.Management.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Meeting.Management.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Person user)
        {
            await _dbContext.User.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _dbContext.User.ToListAsync();
        }
    }
}
